Public Class Array
    Dim nummer As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myForm As New Form1
        myForm.Show()
        Me.Close()
    End Sub

    Private Sub Array_load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim v As Integer
        Dim declaredArray(9) As Integer

        Dim text As String = " "

        For v = 0 To 9
            declaredArray(v) = InputBox("geef een nummer")
            text += (" " & declaredArray(v))
        Next

        MsgBox(text)


        Dim kleuren() As String = {"blauw", "groen", "geel", "bruin", "oranje"}
        For v = 0 To 4
            MsgBox(kleuren(v) & " ")
        Next


    End Sub

    Private Sub oefening2()
        Dim Array() As Integer = {15, 19, 23, 27, 31, 35, 39}
        Dim v As Integer
        Dim text As String = " "

        For v = 0 To 6
            text += (" " & Array(v))
        Next



    End Sub

    Private Sub oefening3()


    End Sub

    Private Sub oefening4()

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