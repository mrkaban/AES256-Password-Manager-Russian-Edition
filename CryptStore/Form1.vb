Imports PassCrypt.Crypto
Imports System.IO

Public Class Form1


    Dim istart As Integer
    Dim ilen As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            RichTextBox1.Text = ""
            Dim strFile As String = "DB.crypt"
            Dim sr As New IO.StreamReader(strFile)
            Dim testocriptato As String
            testocriptato = sr.ReadToEnd()
            sr.Close()
            Dim aes As AES256 = New AES256(TextBox1.Text)
            RichTextBox1.Text = aes.Decrypt(testocriptato)

            If RichTextBox1.Text <> "Неправильный ключ" Then
                Cerca.Enabled = True
                CercaTesto.ReadOnly = False
                Precedente.Enabled = True
                Successivo.Enabled = True
                BloccaProfilo.Enabled = True
                TextBox1.Text = "Введите пароль"

                Label1.Visible = False
                TextBox1.Visible = False
                Button1.Visible = False
            End If

        Catch
            RichTextBox1.Text = "База данных еще не создана. Нажмите на иконку в левом верхнем углу, чтобы открыть страницу управления базами данных и создать."
        End Try

    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Введите пароль" Then
            TextBox1.Text = ""
        Else
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub

    Private Sub CreaProfiloToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Form2.Show()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub


    Private Sub LicenzaToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Licenza.Show()
    End Sub

    Private Sub BloccaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RichTextBox1.Text = "Программа заблокирована, повторно введите пароль для расшифровки информации"
        Cerca.Enabled = False
        Precedente.Enabled = False
        Successivo.Enabled = False
        CercaTesto.ReadOnly = True
        BloccaProfilo.Enabled = False
        Button1.Enabled = True

        Label1.Visible = True
        TextBox1.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Cerca_Click(sender As Object, e As EventArgs) Handles Cerca.Click
        istart = InStr(RichTextBox1.Text, CercaTesto.Text, CompareMethod.Text)
        If istart = 0 Then
            MsgBox("Нет совпадения")
            Exit Sub
        End If
        ilen = CercaTesto.TextLength
        RichTextBox1.Focus()
        RichTextBox1.SelectionStart = istart - 1
        RichTextBox1.SelectionLength = ilen
    End Sub

    Private Sub CercaTesto_Click(sender As Object, e As EventArgs) Handles CercaTesto.Click
        CercaTesto.Text = ""
        Me.AcceptButton = CercaNascosto

    End Sub

    Private Sub CercaNascosto_Click(sender As Object, e As EventArgs) Handles CercaNascosto.Click
        istart = InStr(RichTextBox1.Text, CercaTesto.Text, CompareMethod.Text)
        If istart = 0 Then
            MsgBox("Нет совпадений")
            Exit Sub
        End If
        ilen = CercaTesto.TextLength
        RichTextBox1.Focus()
        RichTextBox1.SelectionStart = istart - 1
        RichTextBox1.SelectionLength = ilen
    End Sub

    Private Sub Precedente_Click(sender As Object, e As EventArgs) Handles Precedente.Click
        istart = InStrRev(RichTextBox1.Text, CercaTesto.Text, istart - 1, CompareMethod.Text)
        If istart = 0 Then
            MsgBox("Нет совпадений")
            Exit Sub
        End If
        ilen = CercaTesto.TextLength
        RichTextBox1.Focus()
        RichTextBox1.SelectionStart = istart - 1
        RichTextBox1.SelectionLength = ilen
    End Sub

    Private Sub Successivo_Click(sender As Object, e As EventArgs) Handles Successivo.Click
        istart = InStr(istart + ilen - 1, RichTextBox1.Text, CercaTesto.Text, CompareMethod.Text)
        If istart = 0 Then
            MsgBox("Нет совпадений")
            Exit Sub
        End If
        ilen = CercaTesto.TextLength
        RichTextBox1.Focus()
        RichTextBox1.SelectionStart = istart - 1
        RichTextBox1.SelectionLength = ilen
    End Sub

    Private Sub BloccaProfilo_Click(sender As Object, e As EventArgs) Handles BloccaProfilo.Click
        RichTextBox1.Text = "Программа заблокирована, повторно введите пароль для расшифровки информации"
        Cerca.Enabled = False
        Precedente.Enabled = False
        Successivo.Enabled = False
        CercaTesto.ReadOnly = True
        BloccaProfilo.Enabled = False
        Button1.Enabled = True

        Label1.Visible = True
        TextBox1.Visible = True
        Button1.Visible = True
    End Sub

    Private Sub Aggiungi_Click(sender As Object, e As EventArgs) Handles Aggiungi.Click
        Form2.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        About.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("DB.crypt") = False Then
            RichTextBox1.Text = "Кажется, это первый раз, когда вы запустили, в противном случае программа не смогла восстановить базу данных. Можно создать новую одним нажатием на иконку в верхнем левом углу, которая приведет вас на страницу управления и создаст базу данных."
        End If
    End Sub

    Private Sub Feedback_Click(sender As Object, e As EventArgs) Handles Feedback.Click
        Dim url As String = "mailto:info@mrkaban.ru"
        Process.Start(url)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        About.Show()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
