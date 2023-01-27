Imports System.Diagnostics.Eventing.Reader

Public Class Selectie
    Dim nummer As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myForm As New Form1
        myForm.Show()
        Me.Close()
    End Sub

    Private Sub Selectie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nummer = InputBox("welke oefening testen wij?")
        selectOef(nummer)

    End Sub

    Private Sub selectOef(nummer)
        Select Case nummer
            Case 1
                oefening1()
            Case 2
                oefening2()
            Case 3
                oefening3()
            Case 4
                oefening4()
            Case 5
                oefening5()
            Case 6
                oefening6()
            Case 7
                oefening7()
            Case 8
                oefening8()
            Case 9
                oefening9()
            Case 10
                oefening10()
            Case 11
                oefening11()
            Case 12
                oefening12()
            Case 13
                oefening13()
            Case 14
                oefening14()
            Case 15
                oefening15()
        End Select
    End Sub


    Private Sub oefening1()

        Dim celcius As Double
        Dim kelvin As Double = InputBox("geef hier het aantal Kelvin in")

        celcius = (kelvin - 273.15)
        If (kelvin <= 0) Then
            MsgBox("error")

        Else

            MsgBox(celcius & " °C")

        End If




    End Sub

    Private Sub oefening2()
        Dim factuur As Double = InputBox("geef hier uw bedrag in")
        Dim prijs As Double


        If factuur > 5000 Then
            prijs = (factuur - 0.03 * factuur)
        Else
            prijs = factuur
        End If

        MsgBox("uw te betalen bedrag is " & prijs)
    End Sub

    Private Sub oefening3()
        Dim wiskunde As Integer = InputBox("geef hier uw score voor wiskunde op 10 in")
        Dim boekhouden As Integer = InputBox("geef hier uw score voor boekhouden op 10 in")
        Dim informatica As Integer = InputBox("geef hier uw score voor informatica op 10 in")


        Dim geslaagd As Boolean = False

        If (wiskunde > 5 And (boekhouden + informatica) > 12) Then
            geslaagd = True
        ElseIf (wiskunde <= 5 And (boekhouden + informatica) > 12) Then
            MsgBox("gebuisd op wiskunde")
        ElseIf ((boekhouden + informatica) < 12 And wiskunde > 5) Then
            MsgBox("op boekhouden + informatica gebuisd")
        Else
            MsgBox("op alle vakken gebuisd")
        End If


        If geslaagd Then
            MsgBox("is geslaagd")
        End If
    End Sub

    Private Sub oefening4()
        Dim getal_1 As Double = InputBox("geef hier het eerste getal in")
        Dim getal_2 As Double = InputBox("geef hier het tweede getal in")
        Dim uitkomst As Double

        If getal_1 > getal_2 Then
            uitkomst = getal_1 / getal_2
            MsgBox("de verhouding tussen het grootste getal en het kleinste getal is " & uitkomst)
        ElseIf getal_2 > getal_1 Then
            uitkomst = getal_2 / getal_1
            MsgBox("de verhouding tussen het grootste getal en het kleinste getal is " & uitkomst)
        End If

    End Sub

    Private Sub oefening5()

        Dim getal_1 As Double = InputBox("geef hier het eerste getal in")
        Dim getal_2 As Double = InputBox("geef hier het tweede getal in")
        Dim getal_3 As Double = InputBox("geef hier het derde getal in")

        Dim grootste As Double
        Dim kleinste As Double
        Dim middelste As Double



        If (getal_1 > getal_2 And getal_1 > getal_3) Then
            grootste = getal_1
        ElseIf (getal_1 < getal_2 And getal_1 > getal_3) Or (getal_1 > getal_2 And getal_1 < getal_3) Then
            middelste = getal_1
        ElseIf (getal_1 < getal_2 And getal_1 < getal_3) Then
            kleinste = getal_1
        End If

        If (getal_2 > getal_1 And getal_2 > getal_3) Then
            grootste = getal_2
        ElseIf (getal_2 < getal_1 And getal_2 > getal_3) Or (getal_2 > getal_1 And getal_2 < getal_3) Then
            middelste = getal_2
        ElseIf (getal_2 < getal_1 And getal_2 < getal_3) Then
            kleinste = getal_2
        End If

        If (getal_3 > getal_2 And getal_3 > getal_1) Then
            grootste = getal_3
        ElseIf (getal_3 < getal_2 And getal_3 > getal_1) Or (getal_3 > getal_2 And getal_3 < getal_1) Then
            middelste = getal_3
        ElseIf (getal_3 < getal_2 And getal_3 < getal_1) Then
            kleinste = getal_3
        End If

        MsgBox("het grootste getal is " & grootste & vbCrLf & "het middelste getal is " & middelste & vbCrLf & "het kleinste getal is " & kleinste)
    End Sub

    Private Sub oefening6()

        Dim kindergeld As Double
        Dim loon As Double = InputBox("geef hier hoeveel uw maandloon is")
        Dim kinderen As Integer = InputBox("geef hier het aantal kinderen")

        If kinderen < 3 Then
            kindergeld = kinderen * 25
        ElseIf kinderen >= 3 And kinderen < 5 Then
            kindergeld = (2 * 25 + (kinderen - 2) * (25 + 12.5))
        Else
            kindergeld = (2 * 25) + (2 * (25 + 12.5)) + ((kinderen - 4) * (25 + 12.5 + 7.5))
        End If

        MsgBox(kindergeld & " " & kinderen)

        If loon <= 500 Then
            kindergeld *= 1.25
        ElseIf loon > 2000 Then
            kindergeld *= 0.75
        Else
            kindergeld = kindergeld
        End If

        If (kindergeld < (kinderen * 25)) Then
            kindergeld = kinderen * 25
        End If

        MsgBox("uw kindergeld bedraagt " & kindergeld & " euro")
    End Sub

    Private Sub oefening7()

    End Sub

    Private Sub oefening8()

    End Sub

    Private Sub oefening9()

    End Sub

    Private Sub oefening10()

    End Sub

    Private Sub oefening11()

    End Sub

    Private Sub oefening12()

    End Sub

    Private Sub oefening13()

    End Sub

    Private Sub oefening14()

    End Sub

    Private Sub oefening15()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class