Imports PassCrypt.Crypto
Imports System.IO

Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.TextLength < 10 Then
            MsgBox("Для безопасности ключ должен быть не менее 10 символов")
        Else
            If TextBox1.Text = TextBox2.Text Then
                If TextBox1.Text = "" And TextBox2.Text = "" Then
                    MsgBox("Введите ключ")
                Else

                    Dim nomeFile As String = "DB.crypt"
                    If IO.File.Exists(nomeFile) = True Then
                        Dim scelta
                        scelta = MsgBox("Существующий уже файл паролей будет перезаписан, содержание будет потеряно. Перезаписать?", vbYesNo, "Подтвердение перезаписи")
                        Select Case scelta
                            Case 6
                                Dim aes As AES256 = New AES256(TextBox1.Text)
                                Dim controllobug As String
                                controllobug = aes.Encrypt(RichTextBox1.Text)
                                If controllobug = "PassCrypt.Crypto+AES256" Then
                                    MsgBox("Использованный пароль не является совместимым, эта ошибка должна быть решена как можно скорее")
                                Else
                                    System.IO.File.WriteAllText("DB.crypt", aes.Encrypt(RichTextBox1.Text))
                                    TextBox1.Visible = False
                                    TextBox2.Visible = False
                                    Label1.Visible = False
                                    Label2.Visible = False
                                    Button2.Enabled = True
                                    Button1.Enabled = False
                                    Carica.Enabled = True
                                    Salva.Enabled = False
                                    RichTextBox1.Text = "Файл успешно создан!"
                                    TextBox1.Text = "Passwordblablabla"
                                    TextBox2.Text = "Passwordblablabla"

                                    Form1.RichTextBox1.Text = "Программа заблокирована, повторно введите пароль для расшифровки информации"
                                    Form1.Cerca.Enabled = False
                                    Form1.Precedente.Enabled = False
                                    Form1.Successivo.Enabled = False
                                    Form1.CercaTesto.ReadOnly = True
                                    Form1.BloccaProfilo.Enabled = False
                                    Form1.Button1.Enabled = True

                                    Form1.Label1.Visible = True
                                    Form1.TextBox1.Visible = True
                                    Form1.Button1.Visible = True
                                End If
                            Case 7
                                ' Non si sovrascrive
                        End Select

                    Else
                        Dim aes As AES256 = New AES256(TextBox1.Text)
                        Dim controllobug As String
                        controllobug = aes.Encrypt(RichTextBox1.Text)
                        If controllobug = "PassCrypt.Crypto+AES256" Then
                            MsgBox("Использованный пароль не является совместимым, эта ошибка должна быть решена как можно скорее")
                        Else

                            System.IO.File.WriteAllText("DB.crypt", aes.Encrypt(RichTextBox1.Text))
                            RichTextBox1.Text = "Файл успешно создан!"
                            TextBox1.Visible = False
                            TextBox2.Visible = False
                            Label1.Visible = False
                            Label2.Visible = False
                            Button2.Enabled = True
                            Button1.Enabled = False
                            Carica.Enabled = True
                            Salva.Enabled = False
                            TextBox1.Text = "Passwordblablabla"
                            TextBox2.Text = "Passwordblablabla"

                            Form1.RichTextBox1.Text = "Программа заблокирована, повторно введите пароль для расшифровки информации"
                            Form1.Cerca.Enabled = False
                            Form1.Precedente.Enabled = False
                            Form1.Successivo.Enabled = False
                            Form1.CercaTesto.ReadOnly = True
                            Form1.BloccaProfilo.Enabled = False
                            Form1.Button1.Enabled = True

                            Form1.Label1.Visible = True
                            Form1.TextBox1.Visible = True
                            Form1.Button1.Visible = True
                        End If
                    End If
                End If


            Else
                MsgBox("Пароли не совпадают!")
            End If
        End If




    End Sub

    Private Sub RichTextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.Click
        If RichTextBox1.Text = "Пожалуйста, введите свои учетные данные в этом поле и пароль, который вы выбрали в соответствующем месте здесь, вскоре после того, нажмите на Зашифровать, чтобы сохранить их в защищенном формате" Then
            RichTextBox1.Text = ""
        Else
        End If
    End Sub

    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
        TextBox2.PasswordChar = "•"
    End Sub




    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
        TextBox1.PasswordChar = "•"
    End Sub



    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Form1.RichTextBox1.Text = "Введите пароль и нажмите на кнопку ""Расшифровать""" Then
            MsgBox("Восстановить старую БД, прежде чем дешифровать")
        Else
            If Form1.RichTextBox1.Text = "" Then
                MsgBox("Старая база данных пуста или не зашифрована")
            Else
                If Form1.RichTextBox1.Text = "Chiave errata" Then
                    MsgBox("Старый DB не шифровано, ошибочный ключ")
                Else
                    TextBox1.Visible = True
                    TextBox2.Visible = True
                    Label1.Visible = True
                    Label2.Visible = True
                    Button2.Enabled = False
                    Button1.Enabled = True
                    Carica.Enabled = False
                    Salva.Enabled = True
                    RichTextBox1.Text = Form1.RichTextBox1.Text
                    'Me.AcceptButton = Button1
                End If
            End If
        End If
    End Sub

    Private Sub SalvaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If TextBox1.TextLength < 10 Then
            MsgBox("Для безопасности ключ должен быть не менее 10 символов")
        Else
            If TextBox1.Text = TextBox2.Text Then
                If TextBox1.Text = "" And TextBox2.Text = "" Then
                    MsgBox("Введите ключ")
                Else

                    Dim nomeFile As String = "DB.crypt"
                    If IO.File.Exists(nomeFile) = True Then
                        Dim scelta
                        scelta = MsgBox("Существующий уже файл паролей будет перезаписан, содержание будет потеряно. Перезаписать?", vbYesNo, "Подтверждение перезаписи")
                        Select Case scelta
                            Case 6
                                Dim aes As AES256 = New AES256(TextBox1.Text)
                                Dim controllobug As String
                                controllobug = aes.Encrypt(RichTextBox1.Text)
                                If controllobug = "PassCrypt.Crypto+AES256" Then
                                    MsgBox("Использованный пароль не является совместимым, эта ошибка должна быть решена как можно скорее")
                                Else
                                    System.IO.File.WriteAllText("DB.crypt", aes.Encrypt(RichTextBox1.Text))
                                    RichTextBox1.Text = "Файл успешно создан!"
                                    TextBox1.Text = ""
                                    TextBox2.Text = ""
                                End If
                            Case 7
                                ' Non si sovrascrive
                        End Select

                    Else
                        Dim aes As AES256 = New AES256(TextBox1.Text)
                        Dim controllobug As String
                        controllobug = aes.Encrypt(RichTextBox1.Text)
                        If controllobug = "PassCrypt.Crypto+AES256" Then
                            MsgBox("Использованный пароль не является совместимым, эта ошибка должна быть решена как можно скорее")
                        Else

                            System.IO.File.WriteAllText("DB.crypt", aes.Encrypt(RichTextBox1.Text))
                            RichTextBox1.Text = "Файл успешно создан!"
                            TextBox1.Text = ""
                            TextBox2.Text = ""
                        End If
                    End If
                End If


            Else
                MsgBox("Пароли не совпадают!")
            End If
        End If

    End Sub

    Private Sub CaricaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Form1.RichTextBox1.Text = "Введите пароль и нажмите на ""Расшифровать""" Then
            MsgBox("Восстановить старую БД, прежде чем дешифровать")
        Else
            If Form1.RichTextBox1.Text = "" Then
                MsgBox("Старая база данных пуста или не зашифрованное")
            Else
                If Form1.RichTextBox1.Text = "Неправильный ключ" Then
                    MsgBox("Старый DB не шифровано, неверный ключ")
                Else
                    RichTextBox1.Text = Form1.RichTextBox1.Text
                End If
            End If
        End If
    End Sub

    Private Sub CaricaDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub SalvaDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        About.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        About.Show()
    End Sub

    Private Sub Blocca_Click(sender As Object, e As EventArgs) Handles Blocca.Click
        Me.Close()
        Form1.RichTextBox1.Text = "Программа заблокирована, повторно введите пароль для расшифровки информации"
        Form1.Cerca.Enabled = False
        Form1.Precedente.Enabled = False
        Form1.Successivo.Enabled = False
        Form1.CercaTesto.ReadOnly = True
        Form1.BloccaProfilo.Enabled = False
        Form1.Button1.Enabled = True

        Form1.Label1.Visible = True
        Form1.TextBox1.Visible = True
        Form1.Button1.Visible = True
    End Sub

    Private Sub Carica_Click(sender As Object, e As EventArgs) Handles Carica.Click
        If Form1.RichTextBox1.Text = "Введите пароль и нажмите на ""Расшифровать""" Then
            MsgBox("Восстановить старую БД, прежде чем дешифровать")
        Else
            If Form1.RichTextBox1.Text = "" Then
                MsgBox("Старая база данных пуста или не зашифрована")
            Else
                If Form1.RichTextBox1.Text = "Chiave errata" Then
                    MsgBox("Старая DB не зашифрована, неверный ключ")
                Else
                    TextBox1.Visible = True
                    TextBox2.Visible = True
                    Label1.Visible = True
                    Label2.Visible = True
                    Button2.Enabled = False
                    Button1.Enabled = True
                    Carica.Enabled = False
                    Salva.Enabled = True
                    RichTextBox1.Text = Form1.RichTextBox1.Text
                    'Me.AcceptButton = Button1
                End If
            End If
        End If
    End Sub

    Private Sub Salva_Click(sender As Object, e As EventArgs) Handles Salva.Click
        If TextBox1.TextLength < 10 Then
            MsgBox("Для безопасности ключ должен быть не менее 10 символов")
        Else
            If TextBox1.Text = TextBox2.Text Then
                If TextBox1.Text = "" And TextBox2.Text = "" Then
                    MsgBox("Введите ключ")
                Else

                    Dim nomeFile As String = "DB.crypt"
                    If IO.File.Exists(nomeFile) = True Then
                        Dim scelta
                        scelta = MsgBox("Существующий уже файл паролей будет перезаписан, содержимое будет потеряно. Перезаписать?", vbYesNo, "Подтверждение перезаписи")
                        Select Case scelta
                            Case 6
                                Dim aes As AES256 = New AES256(TextBox1.Text)
                                Dim controllobug As String
                                controllobug = aes.Encrypt(RichTextBox1.Text)
                                If controllobug = "PassCrypt.Crypto+AES256" Then
                                    MsgBox("Пароль, используемый не совместим, эта ошибка должна быть решена как можно скорее")
                                Else
                                    System.IO.File.WriteAllText("DB.crypt", aes.Encrypt(RichTextBox1.Text))
                                    TextBox1.Visible = False
                                    TextBox2.Visible = False
                                    Label1.Visible = False
                                    Label2.Visible = False
                                    Button2.Enabled = True
                                    Button1.Enabled = False
                                    Carica.Enabled = True
                                    Salva.Enabled = False
                                    RichTextBox1.Text = "Файл успешно создан!"
                                    TextBox1.Text = "Passwordblablabla"
                                    TextBox2.Text = "Passwordblablabla"
                                    Me.AcceptButton = Button2

                                    Form1.RichTextBox1.Text = "Программа заблокирована, повторно введите пароль для расшифровки информации"
                                    Form1.Cerca.Enabled = False
                                    Form1.Precedente.Enabled = False
                                    Form1.Successivo.Enabled = False
                                    Form1.CercaTesto.ReadOnly = True
                                    Form1.BloccaProfilo.Enabled = False
                                    Form1.Button1.Enabled = True

                                    Form1.Label1.Visible = True
                                    Form1.TextBox1.Visible = True
                                    Form1.Button1.Visible = True
                                End If
                            Case 7
                                ' Non si sovrascrive
                        End Select

                    Else
                        Dim aes As AES256 = New AES256(TextBox1.Text)
                        Dim controllobug As String
                        controllobug = aes.Encrypt(RichTextBox1.Text)
                        If controllobug = "PassCrypt.Crypto+AES256" Then
                            MsgBox("Пароль, используемый не совместим, эта ошибка должна быть решена как можно скорее")
                        Else

                            System.IO.File.WriteAllText("DB.crypt", aes.Encrypt(RichTextBox1.Text))
                            RichTextBox1.Text = "Файл успешно создан!"
                            TextBox1.Visible = False
                            TextBox2.Visible = False
                            Label1.Visible = False
                            Label2.Visible = False
                            Button2.Enabled = True
                            Button1.Enabled = False
                            Carica.Enabled = True
                            Salva.Enabled = False
                            TextBox1.Text = "Passwordblablabla"
                            TextBox2.Text = "Passwordblablabla"
                            Me.AcceptButton = Button2

                            Form1.RichTextBox1.Text = "Программа заблокирована, повторно введите пароль для расшифровки информации"
                            Form1.Cerca.Enabled = False
                            Form1.Precedente.Enabled = False
                            Form1.Successivo.Enabled = False
                            Form1.CercaTesto.ReadOnly = True
                            Form1.BloccaProfilo.Enabled = False
                            Form1.Button1.Enabled = True

                            Form1.Label1.Visible = True
                            Form1.TextBox1.Visible = True
                            Form1.Button1.Visible = True
                        End If
                    End If
                End If


            Else
                MsgBox("Пароли не совпадают!")
            End If
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("DB.crypt") = False Then
            TextBox1.Visible = True
            TextBox2.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Button2.Enabled = False
            Button1.Enabled = True
            Carica.Enabled = False
            Salva.Enabled = True
            'Me.AcceptButton = Button1
            RichTextBox1.Text = "Ни одна база данных не найдена, изменить текстовую область с информацией, которую необходимо сохранить, ввести пароль, по крайней мере, десять символов, а затем нажмите на кнопку сохранить."
        End If
    End Sub
End Class