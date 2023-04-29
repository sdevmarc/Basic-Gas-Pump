<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlChoo = New System.Windows.Forms.Panel()
        Me.pnlCal = New System.Windows.Forms.Panel()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.vs1 = New System.Windows.Forms.VScrollBar()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.pnlAsd = New System.Windows.Forms.Panel()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFill = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.sbStat = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.pnlChoo.SuspendLayout()
        Me.pnlCal.SuspendLayout()
        Me.pnlAsd.SuspendLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlChoo
        '
        Me.pnlChoo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnlChoo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlChoo.Controls.Add(Me.pnlCal)
        Me.pnlChoo.Controls.Add(Me.Label1)
        Me.pnlChoo.Controls.Add(Me.cmbType)
        Me.pnlChoo.Location = New System.Drawing.Point(13, 13)
        Me.pnlChoo.Name = "pnlChoo"
        Me.pnlChoo.Size = New System.Drawing.Size(240, 220)
        Me.pnlChoo.TabIndex = 0
        '
        'pnlCal
        '
        Me.pnlCal.Controls.Add(Me.btn0)
        Me.pnlCal.Controls.Add(Me.btn7)
        Me.pnlCal.Controls.Add(Me.vs1)
        Me.pnlCal.Controls.Add(Me.btn8)
        Me.pnlCal.Controls.Add(Me.btn3)
        Me.pnlCal.Controls.Add(Me.btn9)
        Me.pnlCal.Controls.Add(Me.btn2)
        Me.pnlCal.Controls.Add(Me.btn4)
        Me.pnlCal.Controls.Add(Me.btn1)
        Me.pnlCal.Controls.Add(Me.btn5)
        Me.pnlCal.Controls.Add(Me.btn6)
        Me.pnlCal.Enabled = False
        Me.pnlCal.Location = New System.Drawing.Point(18, 71)
        Me.pnlCal.Name = "pnlCal"
        Me.pnlCal.Size = New System.Drawing.Size(200, 132)
        Me.pnlCal.TabIndex = 15
        '
        'btn0
        '
        Me.btn0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn0.Location = New System.Drawing.Point(12, 94)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(120, 23)
        Me.btn0.TabIndex = 14
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn7.Location = New System.Drawing.Point(12, 12)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(36, 23)
        Me.btn7.TabIndex = 2
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'vs1
        '
        Me.vs1.Location = New System.Drawing.Point(168, 12)
        Me.vs1.Name = "vs1"
        Me.vs1.Size = New System.Drawing.Size(17, 80)
        Me.vs1.TabIndex = 11
        '
        'btn8
        '
        Me.btn8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn8.Location = New System.Drawing.Point(54, 12)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(36, 23)
        Me.btn8.TabIndex = 3
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Location = New System.Drawing.Point(96, 70)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(36, 23)
        Me.btn3.TabIndex = 10
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn9.Location = New System.Drawing.Point(96, 12)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(36, 23)
        Me.btn9.TabIndex = 4
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Location = New System.Drawing.Point(54, 70)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(36, 23)
        Me.btn2.TabIndex = 9
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn4.Location = New System.Drawing.Point(12, 41)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(36, 23)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Location = New System.Drawing.Point(12, 70)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(36, 23)
        Me.btn1.TabIndex = 8
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn5.Location = New System.Drawing.Point(54, 41)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(36, 23)
        Me.btn5.TabIndex = 6
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn6.Location = New System.Drawing.Point(96, 41)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(36, 23)
        Me.btn6.TabIndex = 7
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type of Fuel"
        '
        'cmbType
        '
        Me.cmbType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(18, 31)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(201, 21)
        Me.cmbType.TabIndex = 0
        '
        'pnlAsd
        '
        Me.pnlAsd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pnlAsd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlAsd.Controls.Add(Me.txtSales)
        Me.pnlAsd.Controls.Add(Me.Label4)
        Me.pnlAsd.Controls.Add(Me.txtRate)
        Me.pnlAsd.Controls.Add(Me.Label3)
        Me.pnlAsd.Controls.Add(Me.txtLit)
        Me.pnlAsd.Controls.Add(Me.Label2)
        Me.pnlAsd.Enabled = False
        Me.pnlAsd.Location = New System.Drawing.Point(260, 13)
        Me.pnlAsd.Name = "pnlAsd"
        Me.pnlAsd.Size = New System.Drawing.Size(209, 220)
        Me.pnlAsd.TabIndex = 1
        '
        'txtSales
        '
        Me.txtSales.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSales.Location = New System.Drawing.Point(6, 154)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.ReadOnly = True
        Me.txtSales.Size = New System.Drawing.Size(191, 20)
        Me.txtSales.TabIndex = 17
        Me.txtSales.Text = "0"
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Sales"
        '
        'txtRate
        '
        Me.txtRate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtRate.Location = New System.Drawing.Point(6, 95)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(191, 20)
        Me.txtRate.TabIndex = 15
        Me.txtRate.Text = "0"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Rate per hour"
        '
        'txtLit
        '
        Me.txtLit.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtLit.Location = New System.Drawing.Point(6, 31)
        Me.txtLit.Name = "txtLit"
        Me.txtLit.ReadOnly = True
        Me.txtLit.Size = New System.Drawing.Size(191, 20)
        Me.txtLit.TabIndex = 13
        Me.txtLit.Text = "0"
        Me.txtLit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Liters"
        '
        'btnFill
        '
        Me.btnFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFill.Enabled = False
        Me.btnFill.Location = New System.Drawing.Point(324, 239)
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(54, 23)
        Me.btnFill.TabIndex = 12
        Me.btnFill.Text = "Fill"
        Me.btnFill.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Location = New System.Drawing.Point(401, 239)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(56, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tmr1
        '
        Me.tmr1.Interval = 20
        '
        'sbStat
        '
        Me.sbStat.Location = New System.Drawing.Point(0, 266)
        Me.sbStat.Name = "sbStat"
        Me.sbStat.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.sbStat.ShowPanels = True
        Me.sbStat.Size = New System.Drawing.Size(481, 22)
        Me.sbStat.SizingGrip = False
        Me.sbStat.TabIndex = 16
        Me.sbStat.Text = "StatusBar1"
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "Ready"
        Me.StatusBarPanel1.Width = 240
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 240
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(481, 288)
        Me.Controls.Add(Me.sbStat)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFill)
        Me.Controls.Add(Me.pnlAsd)
        Me.Controls.Add(Me.pnlChoo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GASOLINE STATION"
        Me.pnlChoo.ResumeLayout(False)
        Me.pnlChoo.PerformLayout()
        Me.pnlCal.ResumeLayout(False)
        Me.pnlAsd.ResumeLayout(False)
        Me.pnlAsd.PerformLayout()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlChoo As System.Windows.Forms.Panel
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents vs1 As System.Windows.Forms.VScrollBar
    Friend WithEvents pnlAsd As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLit As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSales As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFill As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents pnlCal As System.Windows.Forms.Panel
    Friend WithEvents tmr1 As Timer
    Friend WithEvents sbStat As StatusBar
    Friend WithEvents StatusBarPanel1 As StatusBarPanel
    Friend WithEvents StatusBarPanel2 As StatusBarPanel
End Class
