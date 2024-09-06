Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(0, 1) = "Obama"
        astPeople(1, 1) = "Male"
        astPeople(1, 2) = "American"
        astPeople(2, 2) = "President"

        Dim x, y As Integer

        ' Loop over the first dimension (rows) and second dimension (columns)
        For x = 0 To astPeople.GetLength(0) - 1 ' Loop over rows
            For y = 0 To astPeople.GetLength(1) - 1 ' Loop over columns
                If Not String.IsNullOrEmpty(astPeople(x, y)) Then
                    MsgBox("astPeople(" & x & ", " & y & ") = " & astPeople(x, y))
                End If
            Next y
        Next x

    End Sub



End Class
