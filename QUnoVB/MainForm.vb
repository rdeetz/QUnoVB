Imports Mooville.QUno.Model

Public Class MainForm
    Dim WithEvents CurrentGame As Game
    Dim HumanPlayer As Player

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim humanPlayerName As String
        humanPlayerName = My.Settings.DefaultHumanPlayerName
        Dim computerPlayerCount As Integer
        computerPlayerCount = My.Settings.DefaultComputerPlayers

        CurrentGame = New Game

        HumanPlayer = New Player
        HumanPlayer.Name = humanPlayerName
        HumanPlayer.IsHuman = True
        CurrentGame.Players.Add(HumanPlayer)

        For i = 1 To computerPlayerCount
            Dim computerPlayer As New Player
            computerPlayer.Name = String.Format("Player {0}", i + 1) ' Since the human is Player 1.
            computerPlayer.IsHuman = False
            CurrentGame.Players.Add(computerPlayer)
        Next

        CurrentGame.Deal()

        RefreshGameState()
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

        RefreshGameState()
    End Sub

    Private Sub ListHumanHand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listHumanHand.SelectedIndexChanged
        Dim selectedCard As Card = listHumanHand.SelectedItem
        buttonPlay.Enabled = CurrentGame.CanPlay(selectedCard)
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles buttonPlay.Click
        Dim selectedCard As Card = listHumanHand.SelectedItem

        If selectedCard.Color = Color.Wild Then
            Dim result As DialogResult
            result = WildColorForm.ShowDialog(Me)

            If result = DialogResult.OK Then
                Dim wildColor As Color
                wildColor = WildColorForm.WildColor
                HumanPlayer.Hand.Cards.Remove(selectedCard)
                CurrentGame.PlayCard(selectedCard, wildColor)
            End If
        Else
            HumanPlayer.Hand.Cards.Remove(selectedCard)
            CurrentGame.PlayCard(selectedCard)
        End If

        RefreshGameState()
    End Sub

    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles buttonDraw.Click
        Dim drawnCard = CurrentGame.DrawCard()
        HumanPlayer.Hand.Cards.Add(drawnCard)

        RefreshGameState()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim result As DialogResult
        result = OptionsForm.ShowDialog(Me)
    End Sub

    Private Sub AboutQUnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog(Me)
    End Sub

    Private Sub RefreshGameState()
        labelHumanName.Text = HumanPlayer.Name
        listHumanHand.Items.Clear()

        For Each card In HumanPlayer.Hand.Cards
            listHumanHand.Items.Add(card)
        Next

        textCurrentPlayer.Text = CurrentGame.CurrentPlayer.Name
        textCurrentCard.Text = CurrentGame.Deck.CurrentCard.ToString()
        textCurrentDirection.Text = CurrentGame.CurrentDirection.ToString()
        textCurrentWildColor.Text = CurrentGame.Deck.CurrentWildColor.ToString()

        listComputerPlayers.Items.Clear()

        For Each player In CurrentGame.Players.Where(Function(p) Not p.IsHuman)
            listComputerPlayers.Items.Add(String.Format("{0} has {1} cards left", player.Name, player.Hand.Cards.Count))
        Next
    End Sub
End Class
