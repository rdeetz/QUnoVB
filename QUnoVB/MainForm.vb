﻿Imports Mooville.QUno.Model

Public Class MainForm
    Dim WithEvents CurrentGame As Game
    Dim HumanPlayer As Player
    Dim Log As List(Of String)

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim humanPlayerName As String
        humanPlayerName = My.Settings.DefaultHumanPlayerName
        Dim computerPlayerCount As Integer
        computerPlayerCount = My.Settings.DefaultComputerPlayers

        CurrentGame = New Game
        Log = New List(Of String)

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
        listGameLog.Items.Clear()
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
                        LogTurn(player, cardToPlay, wildColor, 1)
                        CurrentGame.PlayCard(cardToPlay, wildColor)
                    Else
                        ' Play the card.
                        LogTurn(player, cardToPlay, Nothing, 0)
                        CurrentGame.PlayCard(cardToPlay)
                    End If
                Else
                    ' Draw a card.
                    LogTurn(player, Nothing, Nothing, 2)
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
                LogTurn(HumanPlayer, selectedCard, wildColor, 1)
                HumanPlayer.Hand.Cards.Remove(selectedCard)
                CurrentGame.PlayCard(selectedCard, wildColor)
            End If
        Else
            LogTurn(HumanPlayer, selectedCard, Nothing, 0)
            HumanPlayer.Hand.Cards.Remove(selectedCard)
            CurrentGame.PlayCard(selectedCard)
        End If

        RefreshGameState()
    End Sub

    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles buttonDraw.Click
        LogTurn(HumanPlayer, Nothing, Nothing, 2)
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

    Private Sub LogTurn(player As Player, card As Card, wildColor As Color?, mode As Integer)
        Dim message As String = String.Empty

        Select Case mode
            Case 0
                message = player.Name + " played " + card.ToString()
            Case 1
                message = player.Name + " played " + card.Value.ToString() + " and chose " + wildColor.ToString()
            Case 2
                message = player.Name + " drew a card"
        End Select

        Log.Add(message)
        listGameLog.Items.Insert(0, message)
    End Sub
End Class
