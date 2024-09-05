Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCounter As Integer
        Dim stOut As String




        For iCounter = 1 To 50 Step 5
            MsgBox(iCounter)
        Next


        For iCounter = 50 To 0 Step -10
            MsgBox(iCounter)
        Next

        For iCounter = 0 To 10 Step 2
            stOut = stOut & iCounter & vbNewLine
        Next

        MsgBox(stOut)

    End Sub



End Class
