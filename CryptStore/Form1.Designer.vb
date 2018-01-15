<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Aggiungi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cerca = New System.Windows.Forms.ToolStripButton()
        Me.CercaTesto = New System.Windows.Forms.ToolStripTextBox()
        Me.Precedente = New System.Windows.Forms.ToolStripButton()
        Me.Successivo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BloccaProfilo = New System.Windows.Forms.ToolStripButton()
        Me.Feedback = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CercaNascosto = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 29)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(690, 325)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "Введите пароль и нажмите на кнопку ""Расшифровать"""
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(120, 381)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(451, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Inserisci password"
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Введите свой пароль"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.ImageKey = "(none)"
        Me.Button1.Location = New System.Drawing.Point(582, 378)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Расшифровывать"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Aggiungi, Me.ToolStripSeparator1, Me.Cerca, Me.CercaTesto, Me.Precedente, Me.Successivo, Me.ToolStripSeparator2, Me.BloccaProfilo, Me.Feedback, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(707, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Aggiungi
        '
        Me.Aggiungi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Aggiungi.Image = Global.PassCrypt.My.Resources.Resources._053
        Me.Aggiungi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Aggiungi.Name = "Aggiungi"
        Me.Aggiungi.Size = New System.Drawing.Size(23, 22)
        Me.Aggiungi.Text = "ToolStripButton1"
        Me.Aggiungi.ToolTipText = "Создание или изменение базы данных"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Cerca
        '
        Me.Cerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cerca.Enabled = False
        Me.Cerca.Image = Global.PassCrypt.My.Resources.Resources._011
        Me.Cerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cerca.Name = "Cerca"
        Me.Cerca.Size = New System.Drawing.Size(23, 22)
        Me.Cerca.Text = "ToolStripButton1"
        Me.Cerca.ToolTipText = "Поиск"
        '
        'CercaTesto
        '
        Me.CercaTesto.Name = "CercaTesto"
        Me.CercaTesto.ReadOnly = True
        Me.CercaTesto.Size = New System.Drawing.Size(200, 25)
        Me.CercaTesto.Text = "поиск..."
        '
        'Precedente
        '
        Me.Precedente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Precedente.Enabled = False
        Me.Precedente.Image = Global.PassCrypt.My.Resources.Resources._035
        Me.Precedente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Precedente.Name = "Precedente"
        Me.Precedente.Size = New System.Drawing.Size(23, 22)
        Me.Precedente.Text = "ToolStripButton2"
        Me.Precedente.ToolTipText = "Предыдущий поиск"
        '
        'Successivo
        '
        Me.Successivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Successivo.Enabled = False
        Me.Successivo.Image = Global.PassCrypt.My.Resources.Resources._036
        Me.Successivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Successivo.Name = "Successivo"
        Me.Successivo.Size = New System.Drawing.Size(23, 22)
        Me.Successivo.Text = "Cerca successivo"
        Me.Successivo.ToolTipText = "Следующий поиск"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BloccaProfilo
        '
        Me.BloccaProfilo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BloccaProfilo.Enabled = False
        Me.BloccaProfilo.Image = Global.PassCrypt.My.Resources.Resources._017
        Me.BloccaProfilo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BloccaProfilo.Name = "BloccaProfilo"
        Me.BloccaProfilo.Size = New System.Drawing.Size(23, 22)
        Me.BloccaProfilo.Text = "Blocca"
        Me.BloccaProfilo.ToolTipText = "Заблокировать"
        '
        'Feedback
        '
        Me.Feedback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Feedback.Image = Global.PassCrypt.My.Resources.Resources._020
        Me.Feedback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Feedback.Name = "Feedback"
        Me.Feedback.Size = New System.Drawing.Size(23, 22)
        Me.Feedback.Text = "ToolStripButton1"
        Me.Feedback.ToolTipText = "Обратная связь"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "About"
        Me.ToolStripButton1.ToolTipText = "О программе"
        '
        'CercaNascosto
        '
        Me.CercaNascosto.Location = New System.Drawing.Point(623, 24)
        Me.CercaNascosto.Name = "CercaNascosto"
        Me.CercaNascosto.Size = New System.Drawing.Size(0, 0)
        Me.CercaNascosto.TabIndex = 6
        Me.CercaNascosto.Text = "Button6"
        Me.CercaNascosto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(707, 412)
        Me.Controls.Add(Me.CercaNascosto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AES256 Password Manager"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Aggiungi As ToolStripButton
    Friend WithEvents Cerca As ToolStripButton
    Friend WithEvents CercaTesto As ToolStripTextBox
    Friend WithEvents Precedente As ToolStripButton
    Friend WithEvents Successivo As ToolStripButton
    Friend WithEvents CercaNascosto As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BloccaProfilo As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Feedback As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
