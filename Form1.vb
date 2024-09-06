Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim astFruits(4) As String

        astFruits(0) = "Apple"
        astFruits(1) = "Banana"
        astFruits(2) = "Orange"
        astFruits(3) = "Pineapple"
        astFruits(4) = "Mango"

        Dim iCount As Integer
        For iCount = 0 To astFruits.Length - 1
            MsgBox(astFruits(iCount))
        Next

    End Sub



End Class
