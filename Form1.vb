Public Class Form1



    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click

        Dim stCountry As String

        stCountry = txtCountry.Text

        If stCountry.ToUpper = "EGYPT" Then
            MsgBox("Hello to Egyptions")
            MsgBox("you are welcome")
        ElseIf stCountry.ToUpper = "Greek" Then
            MsgBox("u r from Greece")
            MsgBox("welcome bro")
        Else
            MsgBox("hello anonymouse")
            MsgBox("I hope u r well")
        End If

        MsgBox("You Entered " & stCountry)




    End Sub


End Class
