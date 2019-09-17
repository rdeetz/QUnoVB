Imports Mooville.QUno.Model

Public Class MainForm
    Dim WithEvents CurrentGame As Game

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim humanPlayerName As String
        humanPlayerName = My.Settings.DefaultHumanPlayerName
        Dim computerPlayerCount As Integer
        computerPlayerCount = My.Settings.DefaultComputerPlayers

        CurrentGame = New Game

        Dim humanPlayer As New Player
        humanPlayer.Name = humanPlayerName
        humanPlayer.IsHuman = True
        CurrentGame.Players.Add(humanPlayer)

        For i = 1 To computerPlayerCount
            Dim computerPlayer As New Player
            computerPlayer.Name = String.Format("Player {0}", i + 1) ' Since the human is Player 1.
            computerPlayer.IsHuman = False
            CurrentGame.Players.Add(computerPlayer)
        Next

        CurrentGame.Deal()

        RedrawGameState()
    End Sub

    Private Sub PlayerChanged(sender As Object, e As EventArgs) Handles CurrentGame.PlayerChanged
        If Not CurrentGame.IsGameOver Then
            Dim player As Player
            player = CurrentGame.CurrentPlayer

            If Not player.IsHuman Then
                ' Computer player chooses a card to play.
                Dim cardToPlay As Card
                cardToPlay = player.ChooseCardToPlay(CurrentGame)

                If cardToPlay IsNot Nothing Then
                    ' Play a card.
                    If cardToPlay.Color = Color.Wild Then
                        ' Choose a wild color and play the card.
                        Dim wildColor As Color
                        wildColor = player.ChooseWildColor()
                        CurrentGame.PlayCard(cardToPlay, wildColor)
                    Else
                        ' Play the card.
                        CurrentGame.PlayCard(cardToPlay)
                    End If
                Else
                    ' Draw a card.
                    Dim cardToDraw As Card
                    cardToDraw = CurrentGame.DrawCard()
                    player.Hand.Cards.Add(cardToDraw)
                End If
            End If
        Else
            ' Game over!
        End If

        RedrawGameState()
    End Sub

    Private Sub RedrawGameState()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim result As DialogResult
        result = OptionsForm.ShowDialog()
    End Sub

    Private Sub AboutQUnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub
End Class
