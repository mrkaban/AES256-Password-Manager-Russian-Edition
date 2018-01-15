Public Class Licenza
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "http://www.gnu.org/licenses/gpl.html"
        Process.Start(url)
    End Sub
End Class