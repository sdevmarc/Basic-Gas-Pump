Imports System.Threading
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbType.Items.Add("Gasoline")
        cmbType.Items.Add("Gasoline Unleaded")
        cmbType.Items.Add("Gasoline Unleaded Plus")
        cmbType.Items.Add("Gasoline Super Unleaded")
        cmbType.Items.Add("Diesel")
        cmbType.Items.Add("BioDiesel")

        sbStat.Panels(0).Text = "SUAREZ, MARC EDISON D."
        sbStat.Panels(1).Text = Now

        vs1.Minimum = 0
        vs1.Maximum = 109
        txtLit.Text = (vs1.Value)

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged

        If (cmbType.SelectedItem = "Gasoline") Then
            txtRate.Text = 50.75
            pnlCal.Enabled = True
            btnFill.Enabled = True
            pnlAsd.Enabled = True
        ElseIf (cmbType.SelectedItem = "Gasoline Unleaded") Then
            txtRate.Text = 60.5
            pnlCal.Enabled = True
            pnlAsd.Enabled = True
            btnFill.Enabled = True
        ElseIf (cmbType.SelectedItem = "Gasoline Unleaded Plus") Then
            txtRate.Text = 70.25
            pnlCal.Enabled = True
            pnlAsd.Enabled = True
            btnFill.Enabled = True
        ElseIf (cmbType.SelectedItem = "Gasoline Super Unleaded") Then
            txtRate.Text = 80.75
            pnlCal.Enabled = True
            pnlAsd.Enabled = True
            btnFill.Enabled = True
        ElseIf (cmbType.SelectedItem = "Diesel") Then
            txtRate.Text = 40.25
            pnlCal.Enabled = True
            pnlAsd.Enabled = True
            btnFill.Enabled = True
        ElseIf (cmbType.SelectedItem = "BioDiesel") Then
            txtRate.Text = 30.75
            pnlCal.Enabled = True
            pnlAsd.Enabled = True
            btnFill.Enabled = True
        End If

    End Sub

    Private Sub vs1_Scroll(sender As Object, e As ScrollEventArgs) Handles vs1.Scroll
        txtLit.Text = (vs1.Value)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "1"
        Else
            txtLit.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "2"
        Else
            txtLit.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "3"
        Else
            txtLit.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "4"
        Else
            txtLit.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "5"
        Else
            txtLit.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "6"
        Else
            txtLit.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "7"
        Else
            txtLit.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "8"
            txtLit.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "9"
        Else
            txtLit.Text = "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtLit.Text <> "0" Then
            txtLit.Text += "0"
        Else
            txtLit.Text = "0"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLit.Text = "0"
        txtRate.Text = "0"
        txtSales.Text = "0"
        cmbType.Text = ""

        pnlAsd.Enabled = False
        pnlCal.Enabled = False
        btnFill.Enabled = False
        pnlChoo.Enabled = True
        cmbType.Focus()
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        tmr1.Enabled = True
        pnlChoo.Enabled = False

    End Sub

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        Dim Lit As Double = Double.Parse(txtLit.Text)
        Dim Rate As Double = Double.Parse(txtRate.Text)
        Dim Sale As Double
        Sale = Rate * Lit

        txtSales.Text += 1
        If (txtSales.Text >= Sale) Then
            tmr1.Stop()
        End If
    End Sub
End Class
