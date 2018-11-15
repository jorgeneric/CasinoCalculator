Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim Slots As Integer
        Dim BlackJack As Integer
        Dim Poker As Integer
        Dim Roulette As Integer
        Dim Total As Integer
        Dim BlackJackPct As Double
        Dim SlotsPct As Double
        Dim PokerPct As Double
        Dim RoulettePct As Double
        Dim TotalPct As Double

        Integer.TryParse(txtSlots.Text, Slots)
        Integer.TryParse(txtBlackJack.Text, BlackJack)
        Integer.TryParse(txtPoker.Text, Poker)
        Integer.TryParse(txtRoulette.Text, Roulette)


        txtSlots.Text = Slots.ToString("c0")
        txtBlackJack.Text = BlackJack.ToString("c0")
        txtPoker.Text = Poker.ToString("c0")
        txtRoulette.Text = Roulette.ToString("c0")



        Total = BlackJack + Poker + Roulette + Slots

        SlotsPct = Slots / Total
        BlackJackPct = BlackJack / Total
        PokerPct = Poker / Total
        RoulettePct = Roulette / Total
        TotalPct = SlotsPct + BlackJackPct + PokerPct + RoulettePct



        ' Output
        txtTotal.Text = Total.ToString("c0")
        txtBlackJackPct.Text = BlackJackPct.ToString("p1")
        txtSlotsPct.Text = SlotsPct.ToString("p1")
        txtPokerPct.Text = PokerPct.ToString("p1")
        txtRoulettePct.Text = RoulettePct.ToString("p1")
        txtTotalPct.Text = TotalPct.ToString("p1")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTotal.Text = String.Empty
        txtSlots.Text = String.Empty
        txtBlackJack.Text = String.Empty
        txtPoker.Text = String.Empty
        txtRoulette.Text = String.Empty
        txtTotalPct.Text = String.Empty
        txtSlotsPct.Text = String.Empty
        txtBlackJackPct.Text = String.Empty
        txtPokerPct.Text = String.Empty
        txtRoulettePct.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
