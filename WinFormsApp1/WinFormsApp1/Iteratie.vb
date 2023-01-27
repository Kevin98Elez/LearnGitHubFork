Public Class Iteratie
    Dim nummer As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myForm As New Form1
        myForm.Show()
        Me.Close()
    End Sub

    Private Sub Iteratie_load(sender As Object, e As EventArgs) Handles MyBase.Load
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



        Dim vollegorde As Integer = 0
        Dim som As Integer = 0

        Do While vollegorde < 10
            som += vollegorde
            vollegorde += 1
            MsgBox(vollegorde.ToString & " ")
        Loop

        MsgBox("de som van alle getallen is " & som)


    End Sub

    Private Sub oefening2()

        Dim temp As Integer

        Dim negatief As Integer = 0
        Dim positief As Integer = 0
        Dim aantal_p As Integer = 0
        Dim aantal_n As Integer = 0
        Dim aantal_nul As Integer = 0
        Dim gem_p As Double
        Dim gem_n As Double


        Do Until temp = 99
            temp = InputBox("geef een temperatuur in")

            If temp < 0 Then
                negatief += temp
                MsgBox("totale som van negatieve temp " & negatief)
                aantal_n += 1
            ElseIf temp = 0 Then
                aantal_nul += 1
            Else positief += temp
                MsgBox("totale som van positieve temp " & positief)
                aantal_p += 1
            End If

        Loop

        gem_p = positief / aantal_p
        gem_n = negatief / aantal_n



        MsgBox("het aantal positieve temperaturen is " & aantal_p)
        MsgBox("het aantal negatieve temperaturen is " & aantal_n)

        MsgBox("het gemiddelde van de positieve temperaturen is " & gem_p)
        MsgBox("het gemiddelde van de negatieve temperaturen is " & gem_n)

        MsgBox("het aantal nul temperaturen is " & aantal_nul)


    End Sub

    Private Sub oefening3()

        Dim wiskunde As Integer = 0
        Dim boekhouding As Integer = 0
        Dim informatica As Integer = 0

        Do Until wiskunde >= 6 And wiskunde <= 10
            wiskunde = InputBox("geef hier uw put op wiskunde in (op 10)")
        Loop

        Do While (((boekhouding + informatica) < 12) Or ((boekhouding + informatica) > 20))
            boekhouding = InputBox("geef hier de punten van boekhouding  in (op 10)")
            informatica = InputBox("geef hier de punten van  infomatica in (op 10)")
        Loop

        MsgBox("geslaagd")

    End Sub

    Private Sub oefening4()

        Dim random As Integer = 50
        Dim guess As Integer



        'random = Math.Floor(Math.random() * 100) + 1
        Do Until guess = random
            guess = InputBox("raad het nummer")
            If guess < random Then
                MsgBox("te laag)")
            Else
                MsgBox("te hoog")
            End If
        Loop

        MsgBox("correct")


    End Sub

    Private Sub oefening5()

    End Sub

    Private Sub oefening6()

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
End Class