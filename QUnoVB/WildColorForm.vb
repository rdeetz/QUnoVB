Imports Mooville.QUno.Model

Public Class WildColorForm
    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles buttonOk.Click
        Dim wildColor As Color
        Dim color = listColors.SelectedItem

        Select Case color
            Case "Red"
                wildColor = Model.Color.Red
            Case "Blue"
                wildColor = Model.Color.Blue
            Case "Yellow"
                wildColor = Model.Color.Yellow
            Case "Green"
                wildColor = Model.Color.Green
        End Select

        DialogResult = wildColor

        Close()
    End Sub

    Private Sub ListColors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listColors.SelectedIndexChanged
        If listColors.SelectedIndex >= 0 Then
            buttonOk.Enabled = True
        Else
            buttonOk.Enabled = False
        End If
    End Sub
End Class