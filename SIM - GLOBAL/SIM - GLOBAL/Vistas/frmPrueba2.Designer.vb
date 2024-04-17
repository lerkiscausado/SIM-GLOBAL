<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrueba2
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim OptionsSpelling2 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Dim SpellCheckerOpenOfficeDictionary1 As DevExpress.XtraSpellChecker.SpellCheckerOpenOfficeDictionary = New DevExpress.XtraSpellChecker.SpellCheckerOpenOfficeDictionary()
        Dim OptionsSpelling1 As DevExpress.XtraSpellChecker.OptionsSpelling = New DevExpress.XtraSpellChecker.OptionsSpelling()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.CachedEjemplo1 = New SIM___GLOBAL.CachedEjemplo()
        Me.wbChat = New System.Windows.Forms.WebBrowser()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SpellChecker1 = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
        Me.TextEdit1 = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(59, 490)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(117, 36)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'wbChat
        '
        Me.wbChat.Location = New System.Drawing.Point(59, 114)
        Me.wbChat.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbChat.Name = "wbChat"
        Me.wbChat.Size = New System.Drawing.Size(458, 197)
        Me.wbChat.TabIndex = 1
        Me.wbChat.Url = New System.Uri("http://www.ados-software.com/index.html", System.UriKind.Absolute)
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(273, 490)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(117, 36)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imrpimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(420, 343)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(562, 300)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(346, 226)
        Me.SpellChecker1.SetSpellCheckerOptions(Me.RichTextBox1, OptionsSpelling2)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = "TIPO DE MUESTRA: CERVIX"
        '
        'SpellChecker1
        '
        Me.SpellChecker1.CheckAsYouTypeOptions.CheckControlsInParentContainer = True
        Me.SpellChecker1.Culture = New System.Globalization.CultureInfo("es-CO")
        SpellCheckerOpenOfficeDictionary1.AlphabetPath = "C:\Users\camer\source\repos\SIM - GLOBAL\SIM - GLOBAL\SIM - GLOBAL\Utilidades\Dic" &
    "cionarios\EnglishAlphabet.txt"
        SpellCheckerOpenOfficeDictionary1.CacheKey = Nothing
        SpellCheckerOpenOfficeDictionary1.Culture = New System.Globalization.CultureInfo("es-CO")
        SpellCheckerOpenOfficeDictionary1.DictionaryPath = "C:\Users\camer\source\repos\SIM - GLOBAL\SIM - GLOBAL\SIM - GLOBAL\Utilidades\Dic" &
    "cionarios\es_ES.dic"
        SpellCheckerOpenOfficeDictionary1.Encoding = System.Text.Encoding.GetEncoding(1252)
        SpellCheckerOpenOfficeDictionary1.GrammarPath = "C:\Users\camer\source\repos\SIM - GLOBAL\SIM - GLOBAL\SIM - GLOBAL\Utilidades\Dic" &
    "cionarios\es_ES.aff"
        Me.SpellChecker1.Dictionaries.Add(SpellCheckerOpenOfficeDictionary1)
        Me.SpellChecker1.ParentContainer = Me
        Me.SpellChecker1.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType
        Me.SpellChecker1.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(562, 51)
        Me.TextEdit1.Name = "TextEdit1"
        Me.SpellChecker1.SetShowSpellCheckMenu(Me.TextEdit1, True)
        Me.TextEdit1.Size = New System.Drawing.Size(346, 224)
        Me.SpellChecker1.SetSpellCheckerOptions(Me.TextEdit1, OptionsSpelling1)
        Me.TextEdit1.TabIndex = 6
        '
        'frmPrueba2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 562)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.wbChat)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.TextEdit1)
        Me.Name = "frmPrueba2"
        Me.Text = "frmPrueba2"
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIniciar As Button
    Friend WithEvents CachedEjemplo1 As CachedEjemplo
    Friend WithEvents wbChat As WebBrowser
    Friend WithEvents btnImprimir As Button
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SpellChecker1 As DevExpress.XtraSpellChecker.SpellChecker
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.MemoEdit
End Class
