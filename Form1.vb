﻿Public Class Form1


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



End Class
