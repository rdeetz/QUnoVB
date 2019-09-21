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

    Private Sub RefreshGameState()
        Dim human As Player
        human = CurrentGame.Players.First(Function(p) p.IsHuman)

        listComputerPlayers.Items.Clear()

        For Each player In CurrentGame.Players.Where(Function(p) Not p.IsHuman)
            listComputerPlayers.Items.Add(
                String.Format("{0} {1}", player.Name, player.Hand.Cards.Count))
        Next

        labelCurrentCard.Text = CurrentGame.Deck.CurrentCard.ToString()
        labelCurrentWildColor.Text = CurrentGame.Deck.CurrentWildColor.ToString()
        labelCurrentDirection.Text = CurrentGame.CurrentDirection.ToString()

        labelHumanName.Text = human.Name
        listHumanHand.Items.Clear()

        For Each card In human.Hand.Cards
            listHumanHand.Items.Add(card)
        Next
    End Sub

    Private Sub ListHumanHand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listHumanHand.SelectedIndexChanged
        Dim selectedCard = listHumanHand.SelectedItem

        If CurrentGame.CanPlay(selectedCard) Then
            buttonPlay.Enabled = True
        Else
            buttonPlay.Enabled = False
        End If
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles buttonPlay.Click
        Dim human = CurrentGame.Players.First(Function(p) p.IsHuman)
        Dim selectedCard As Card = listHumanHand.SelectedItem

        human.Hand.Cards.Remove(selectedCard)

        If selectedCard.Color = Color.Wild Then
            Dim wildColor = WildColorForm.ShowDialog(Me)
            CurrentGame.PlayCard(selectedCard, wildColor)
        Else
            CurrentGame.PlayCard(selectedCard)
        End If

        RefreshGameState()
    End Sub

    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles buttonDraw.Click
        Dim drawnCard = CurrentGame.DrawCard()
        Dim human = CurrentGame.Players.First(Function(p) p.IsHuman)
        human.Hand.Cards.Add(drawnCard)

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
End Class
