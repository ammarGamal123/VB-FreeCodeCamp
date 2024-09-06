Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim stAge As String
        Dim iAge As Integer

        Do While Not (IsNumeric(stAge))
            stAge = InputBox("Please Enter Your Name")
        Loop

        'Explicit type conversion
        iAge = CInt(stAge)

        MsgBox("Your Age is = " & iAge)


    End Sub



End Class
