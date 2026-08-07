Namespace Utilidades

    ''' <summary>
    ''' Convierte los campos de texto libre de la tabla 'antecedentes' (antecedentes_personales,
    ''' antecedentes_familiares) en listas clasificadas para armar el Bundle RDA-Paciente.
    '''
    ''' IMPORTANTE - Esto es un mapeo "mejor esfuerzo" (best-effort), no una codificación clínica real:
    ''' el SIM actualmente NO tiene captura estructurada de alergias / medicamentos / condiciones
    ''' declaradas por el paciente (son un solo campo de texto libre). Este parser solo separa
    ''' oraciones y las clasifica por palabras clave; el resultado se envía como texto narrativo
    ''' (CodeableConcept.text), SIN inventar códigos SNOMED/CIE10/CUM que el sistema no conoce.
    ''' Si se requiere mayor precisión, la solución correcta a mediano plazo es capturar estos
    ''' datos en campos estructurados (ver recomendación entregada aparte).
    ''' </summary>
    Public Module RDATextParser

        Private ReadOnly PalabrasAlergia As String() = {
            "alerg", "hipersensib", "reaccion adversa", "intoleran"
        }

        Private ReadOnly PalabrasMedicamento As String() = {
            "toma ", "tomando", "medicamento", "formula", "farmac", "consume ",
            "tratamiento con", "mg", "tableta", "capsula", "jarabe", "inyect"
        }

        ''' <summary>
        ''' Divide un texto libre en fragmentos (oraciones/ítems) usando separadores comunes:
        ''' punto y coma, coma, salto de línea, o la conjunción "y".
        ''' </summary>
        Public Function DividirEnItems(texto As String) As List(Of String)
            Dim resultado As New List(Of String)
            If String.IsNullOrWhiteSpace(texto) Then Return resultado

            Dim separadores As Char() = {";"c, Chr(10), Chr(13)}
            Dim partes = texto.Split(separadores, StringSplitOptions.RemoveEmptyEntries)

            For Each parte In partes
                ' Si el fragmento resultante sigue siendo largo, intentamos afinar por comas,
                ' evitando partir números decimales o "CC 123,456" por accidente (heurística simple).
                Dim subPartes = parte.Split(","c)
                For Each sp In subPartes
                    Dim limpio = sp.Trim()
                    If limpio.Length > 0 Then
                        resultado.Add(limpio)
                    End If
                Next
            Next

            Return resultado
        End Function

        ''' <summary>
        ''' Clasifica cada ítem de antecedentes_personales en Alergias, Medicamentos o Condiciones
        ''' (lo que no matchee ninguna palabra clave de alergia/medicamento se asume Condición/problema).
        ''' </summary>
        Public Sub ClasificarAntecedentesPersonales(textoLibre As String,
                                                      ByRef alergias As List(Of String),
                                                      ByRef medicamentos As List(Of String),
                                                      ByRef condiciones As List(Of String))
            alergias = New List(Of String)
            medicamentos = New List(Of String)
            condiciones = New List(Of String)

            Dim negativos As String() = {
                "ninguno", "ninguna", "no refiere", "no manifiesta", "niega", "sin antecedentes",
                "n/a", "no aplica", "no presenta"
            }

            For Each item In DividirEnItems(textoLibre)
                Dim itemLower = item.ToLowerInvariant()

                If negativos.Any(Function(n) itemLower.Contains(n)) Then
                    Continue For ' No se reporta como antecedente si el texto lo niega explícitamente
                End If

                If PalabrasAlergia.Any(Function(p) itemLower.Contains(p)) Then
                    alergias.Add(item)
                ElseIf PalabrasMedicamento.Any(Function(p) itemLower.Contains(p)) Then
                    medicamentos.Add(item)
                Else
                    condiciones.Add(item)
                End If
            Next
        End Sub

        ''' <summary>
        ''' Devuelve los ítems de antecedentes_familiares como lista simple (no se clasifican,
        ''' van directo a FamilyMemberHistory con parentesco genérico "Otro" salvo que el texto
        ''' mencione explícitamente un parentesco conocido).
        ''' </summary>
        Public Function ExtraerAntecedentesFamiliares(textoLibre As String) As List(Of String)
            Return DividirEnItems(textoLibre)
        End Function

        ''' <summary>
        ''' Detecta un parentesco básico dentro del texto (Padres, Hermanos, Abuelos) según el
        ''' CodeSystem ParentescoAntecedente de MinSalud. Si no se reconoce ninguno, retorna
        ''' Nothing y el llamador debe usar el código genérico "99 - Otro / No especificado".
        ''' </summary>
        Public Function DetectarParentesco(texto As String) As (Codigo As String, Display As String)?
            Dim t = texto.ToLowerInvariant()
            If t.Contains("padre") OrElse t.Contains("madre") OrElse t.Contains("papa") OrElse t.Contains("mama") Then
                Return ("01", "Padres")
            ElseIf t.Contains("hermano") OrElse t.Contains("hermana") Then
                Return ("02", "Hermanos")
            ElseIf t.Contains("abuelo") OrElse t.Contains("abuela") Then
                Return ("03", "Abuelos")
            ElseIf t.Contains("tio") OrElse t.Contains("tía") OrElse t.Contains("tia") Then
                Return ("04", "Tíos")
            End If
            Return Nothing
        End Function

    End Module

End Namespace
