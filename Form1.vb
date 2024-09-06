Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer
        iCount = 0


        Do While iCount <= 5
            MsgBox(iCount)
            iCount += 1
        Loop

        iCount = 1

        Do Until iCount > 5
            MsgBox("Hello" & iCount)
            iCount += 1
        Loop


        iCount = 1

        Do
            MsgBox("Hello Mr. Ammar" & iCount)
            iCount += 1
        Loop Until iCount = 5


    End Sub



End Class
