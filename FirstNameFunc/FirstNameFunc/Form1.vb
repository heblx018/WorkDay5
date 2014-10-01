Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text.Trim()
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        Dim idxSpace As Integer
        idxSpace = name.IndexOf(" ")
        Dim FstName As String
        FstName = name.Substring(0, idxSpace)
        Return FstName
    End Function

End Class
