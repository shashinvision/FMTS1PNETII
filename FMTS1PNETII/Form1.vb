Public Class Form1

    Dim chicagoTeam, newyorkTeam, partido1, partido2, partido3, partido4, partido5, partido6, partido7, triplesChicago, triplesNewYork As Integer

    Private Sub EquipoConMásTriplesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipoConMásTriplesToolStripMenuItem.Click
        triplesChicago = tiroTripleChicagoP1.Value + tiroTripleChicagoP2.Value + tiroTripleChicagoP3.Value + tiroTripleChicagoP4.Value + tiroTripleChicagoP5.Value + tiroTripleChicagoP6.Value + tiroTripleChicagoP7.Value
        triplesNewYork = tiroTripleNewYorkP1.Value + tiroTripleNewYorkP2.Value + tiroTripleNewYorkP3.Value + tiroTripleNewYorkP4.Value + tiroTripleNewYorkP5.Value + tiroTripleNewYorkP6.Value + tiroTripleNewYorkP7.Value

        If triplesChicago > triplesNewYork Then
            MessageBox.Show("El equipo con más triples es: Chicago !!")
        ElseIf triplesChicago < triplesNewYork Then
            MessageBox.Show("El equipo con más triples es: New York Knicks !!")
        End If
    End Sub

    Private Sub PartidoConMásPuntosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartidoConMásPuntosToolStripMenuItem.Click
        If partido1 > partido2 And partido1 > partido3 And partido1 > partido4 And partido1 > partido5 And partido1 > partido6 And partido1 > partido7 Then
            MessageBox.Show("El partido con más puntos es el: Partido 1 !!")
        ElseIf partido2 > partido1 And partido2 > partido3 And partido2 > partido4 And partido2 > partido5 And partido2 > partido6 And partido2 > partido7 Then
            MessageBox.Show("El partido con más puntos es el: Partido 2 !!")
        ElseIf partido3 > partido1 And partido3 > partido2 And partido3 > partido4 And partido3 > partido5 And partido3 > partido6 And partido3 > partido7 Then
            MessageBox.Show("El partido con más puntos es el: Partido 3 !!")
        ElseIf partido4 > partido1 And partido4 > partido2 And partido4 > partido3 And partido4 > partido5 And partido4 > partido6 And partido4 > partido7 Then
            MessageBox.Show("El partido con más puntos es el: Partido 4 !!")
        ElseIf partido5 > partido1 And partido5 > partido2 And partido5 > partido3 And partido5 > partido4 And partido5 > partido6 And partido5 > partido7 Then
            MessageBox.Show("El partido con más puntos es el: Partido 5 !!")
        ElseIf partido6 > partido1 And partido6 > partido2 And partido6 > partido3 And partido6 > partido4 And partido6 > partido5 And partido6 > partido7 Then
            MessageBox.Show("El partido con más puntos es el: Partido 6 !!")
        ElseIf partido7 > partido1 And partido7 > partido2 And partido7 > partido3 And partido7 > partido4 And partido7 > partido5 And partido7 > partido6 Then
            MessageBox.Show("El partido con más puntos es el: Partido 7 !!")
        End If
    End Sub

    Private Sub EquipoGanadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipoGanadorToolStripMenuItem.Click
        If chicagoTeam > newyorkTeam Then
            MessageBox.Show("El equipo ganador es Chicago !!")
        ElseIf chicagoTeam < newyorkTeam Then
            MessageBox.Show("El equipo ganador es New York Knicks !!")

        End If
    End Sub

    Private Sub btnFinalizarP1_Click(sender As Object, e As EventArgs) Handles btnFinalizarP1.Click
        totalChicagoP1.Value = ((tiroLibreChicagoP1.Value * 1) + (tiroDobleChicagoP1.Value * 2) + (tiroTripleChicagoP1.Value * 3))
        totalNewYorkP1.Value = ((tiroLibreNewYorkP1.Value * 1) + (tiroDobleNewYorkP1.Value * 2) + (tiroTripleNewYorkP1.Value * 3))

        If (totalChicagoP1.Value > totalNewYorkP1.Value) Then
            ganadorLabelP1.Text = "Ganador: Chicago Bull !!"
            chicagoTeam += 1
        ElseIf (totalChicagoP1.Value < totalNewYorkP1.Value) Then
            ganadorLabelP1.Text = "Ganador: New York Knicks !!"
            newyorkTeam += 1
        Else
            ganadorLabelP1.Text = "Ganador?"
        End If

        partido1 = totalChicagoP1.Value + totalNewYorkP1.Value

    End Sub

    Private Sub btnFinalizarP2_Click(sender As Object, e As EventArgs) Handles btnFinalizarP2.Click
        totalChicagoP2.Value = ((tiroLibreChicagoP2.Value * 1) + (tiroDobleChicagoP2.Value * 2) + (tiroTripleChicagoP2.Value * 3))
        totalNewYorkP2.Value = ((tiroLibreNewYorkP2.Value * 1) + (tiroDobleNewYorkP2.Value * 2) + (tiroTripleNewYorkP2.Value * 3))

        If (totalChicagoP2.Value > totalNewYorkP2.Value) Then
            ganadorLabelP2.Text = "Ganador: Chicago Bull !!"
            chicagoTeam += 1
        ElseIf (totalChicagoP2.Value < totalNewYorkP2.Value) Then
            ganadorLabelP2.Text = "Ganador: New York Knicks !!"
            newyorkTeam += 1
        Else
            ganadorLabelP2.Text = "Ganador?"
        End If

        partido2 = totalChicagoP2.Value + totalNewYorkP2.Value

    End Sub

    Private Sub btnFinalizarP3_Click(sender As Object, e As EventArgs) Handles btnFinalizarP3.Click
        totalChicagoP3.Value = ((tiroLibreChicagoP3.Value * 1) + (tiroDobleChicagoP3.Value * 2) + (tiroTripleChicagoP3.Value * 3))
        totalNewYorkP3.Value = ((tiroLibreNewYorkP3.Value * 1) + (tiroDobleNewYorkP3.Value * 2) + (tiroTripleNewYorkP3.Value * 3))

        If (totalChicagoP3.Value > totalNewYorkP3.Value) Then
            ganadorLabelP3.Text = "Ganador: Chicago Bull !!"
            chicagoTeam += 1
        ElseIf (totalChicagoP3.Value < totalNewYorkP3.Value) Then
            ganadorLabelP3.Text = "Ganador: New York Knicks !!"
            newyorkTeam += 1
        Else
            ganadorLabelP3.Text = "Ganador?"
        End If

        partido3 = totalChicagoP3.Value + totalNewYorkP3.Value

    End Sub

    Private Sub btnFinalizarP4_Click(sender As Object, e As EventArgs) Handles btnFinalizarP4.Click
        totalChicagoP4.Value = ((tiroLibreChicagoP4.Value * 1) + (tiroDobleChicagoP4.Value * 2) + (tiroTripleChicagoP4.Value * 3))
        totalNewYorkP4.Value = ((tiroLibreNewYorkP4.Value * 1) + (tiroDobleNewYorkP4.Value * 2) + (tiroTripleNewYorkP4.Value * 3))

        If (totalChicagoP4.Value > totalNewYorkP4.Value) Then
            ganadorLabelP4.Text = "Ganador: Chicago Bull !!"
            chicagoTeam += 1
        ElseIf (totalChicagoP4.Value < totalNewYorkP4.Value) Then
            ganadorLabelP4.Text = "Ganador: New York Knicks !!"
            newyorkTeam += 1
        Else
            ganadorLabelP4.Text = "Ganador?"
        End If

        partido4 = totalChicagoP4.Value + totalNewYorkP4.Value

    End Sub

    Private Sub btnFinalizarP5_Click(sender As Object, e As EventArgs) Handles btnFinalizarP5.Click
        totalChicagoP5.Value = ((tiroLibreChicagoP5.Value * 1) + (tiroDobleChicagoP5.Value * 2) + (tiroTripleChicagoP5.Value * 3))
        totalNewYorkP5.Value = ((tiroLibreNewYorkP5.Value * 1) + (tiroDobleNewYorkP5.Value * 2) + (tiroTripleNewYorkP5.Value * 3))

        If (totalChicagoP5.Value > totalNewYorkP5.Value) Then
            ganadorLabelP5.Text = "Ganador: Chicago Bull !!"
            chicagoTeam += 1
        ElseIf (totalChicagoP5.Value < totalNewYorkP5.Value) Then
            ganadorLabelP5.Text = "Ganador: New York Knicks !!"
            newyorkTeam += 1
        Else
            ganadorLabelP5.Text = "Ganador?"
        End If

        partido5 = totalChicagoP5.Value + totalNewYorkP5.Value

    End Sub

    Private Sub btnFinalizarP6_Click(sender As Object, e As EventArgs) Handles btnFinalizarP6.Click
        totalChicagoP6.Value = ((tiroLibreChicagoP6.Value * 1) + (tiroDobleChicagoP6.Value * 2) + (tiroTripleChicagoP6.Value * 3))
        totalNewYorkP6.Value = ((tiroLibreNewYorkP6.Value * 1) + (tiroDobleNewYorkP6.Value * 2) + (tiroTripleNewYorkP6.Value * 3))

        If (totalChicagoP6.Value > totalNewYorkP6.Value) Then
            ganadorLabelP6.Text = "Ganador: Chicago Bull !!"
            chicagoTeam += 1
        ElseIf (totalChicagoP6.Value < totalNewYorkP6.Value) Then
            ganadorLabelP6.Text = "Ganador: New York Knicks !!"
            newyorkTeam += 1
        Else
            ganadorLabelP6.Text = "Ganador?"
        End If

        partido6 = totalChicagoP6.Value + totalNewYorkP6.Value

    End Sub

    Private Sub btnFinalizarP7_Click(sender As Object, e As EventArgs) Handles btnFinalizarP7.Click
        totalChicagoP7.Value = ((tiroLibreChicagoP7.Value * 1) + (tiroDobleChicagoP7.Value * 2) + (tiroTripleChicagoP7.Value * 3))
        totalNewYorkP7.Value = ((tiroLibreNewYorkP7.Value * 1) + (tiroDobleNewYorkP7.Value * 2) + (tiroTripleNewYorkP7.Value * 3))

        If (totalChicagoP7.Value > totalNewYorkP7.Value) Then
            ganadorLabelP7.Text = "Ganador: Chicago Bull !!"
            chicagoTeam += 1
        ElseIf (totalChicagoP7.Value < totalNewYorkP7.Value) Then
            ganadorLabelP7.Text = "Ganador: New York Knicks !!"
            newyorkTeam += 1
        Else
            ganadorLabelP7.Text = "Ganador?"
        End If

        partido7 = totalChicagoP7.Value + totalNewYorkP7.Value

    End Sub

End Class
