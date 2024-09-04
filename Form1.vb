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



    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDataRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColor = "Blue"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 9999.99
        dtDataRegistered = #11/20/2024#

        MsgBox("the car is " & stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & stColor & vbNewLine & iEngineSize &
               vbNewLine & decPrice & vbNewLine & dtDataRegistered)





    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        Dim stFirstName, stLastName, stGender, stOccupation As String


        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        stOccupation = lstOccupation.SelectedItem

        MsgBox("Hello Mr. " & stFirstName & " " & stLastName &
               " you are a " & stGender & " " & stOccupation)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstOccupation.Items.Add("Writer")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Painter")
        lstOccupation.Items.Add("Artist")


    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click

        Dim dblNumber1, dblNumber2, dblResult As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text


        dblResult = dblNumber1 + dblNumber2
        MsgBox("Sum = " & dblResult)

        dblResult = dblNumber1 - dblNumber2
        MsgBox("Subtraction = " & dblResult)

        dblResult = dblNumber1 * dblNumber2
        MsgBox("Multiplication = " & dblResult)

        dblResult = dblNumber1 / dblNumber2
        MsgBox("Division = " & dblResult)

        dblResult = dblNumber1 ^ dblNumber2
        MsgBox("Number 1 Power of Number 2 = " & dblResult)




        ' '\' this to divide and ignore the reminder
        dblResult = dblNumber1 \ dblNumber2
        MsgBox("division ignore reminder = " & dblResult)

        dblResult = dblNumber1 Mod dblNumber2
        MsgBox("Num1 Mod Num2 = " & dblResult)


    End Sub
End Class
