Public Class Form1


    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("Welcome to the VB.NET programming course")

        MessageBox.Show("Another way to display words")

    End Sub


    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String


        stFirstName = "Ammar"
        stLastName = "Hammad"

        MsgBox("hello and welcome Mr. " & stFirstName & " " & stLastName & " I hope u r well")

        stFirstName = "Kareem"
        stLastName = "Gamal"


        MsgBox("hello and welcome Mr. " & stFirstName & " " & stLastName & " I hope u r well")



    End Sub



End Class
