<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbc = New System.Windows.Forms.TabControl()
        Me.tab_interest = New System.Windows.Forms.TabPage()
        Me.tb_int_rate = New System.Windows.Forms.TextBox()
        Me.tb_int_date = New System.Windows.Forms.TextBox()
        Me.tb_account_to_credit = New System.Windows.Forms.TextBox()
        Me.tb_period = New System.Windows.Forms.TextBox()
        Me.tb_start_date = New System.Windows.Forms.TextBox()
        Me.tb_end_acc = New System.Windows.Forms.TextBox()
        Me.tb_start_acc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_process_int = New System.Windows.Forms.Button()
        Me.btn_calculate_int = New System.Windows.Forms.Button()
        Me.dgv_interest = New System.Windows.Forms.DataGridView()
        Me.tab_penalt = New System.Windows.Forms.TabPage()
        Me.tb_pen_thresh = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tb_pen_rate = New System.Windows.Forms.TextBox()
        Me.tb_end_date_pen = New System.Windows.Forms.TextBox()
        Me.tb_acc_to_credit_pen = New System.Windows.Forms.TextBox()
        Me.tb_period_pen = New System.Windows.Forms.TextBox()
        Me.tb_start_date_pen = New System.Windows.Forms.TextBox()
        Me.tb_end_acc_pen = New System.Windows.Forms.TextBox()
        Me.tb_start_acc_pen = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_process_pen = New System.Windows.Forms.Button()
        Me.btn_calc_pen = New System.Windows.Forms.Button()
        Me.dgv_pen = New System.Windows.Forms.DataGridView()
        Me.tab_payment = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbc.SuspendLayout()
        Me.tab_interest.SuspendLayout()
        CType(Me.dgv_interest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_penalt.SuspendLayout()
        CType(Me.dgv_pen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbc
        '
        Me.tbc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbc.Controls.Add(Me.tab_interest)
        Me.tbc.Controls.Add(Me.tab_penalt)
        Me.tbc.Controls.Add(Me.tab_payment)
        Me.tbc.Location = New System.Drawing.Point(12, 75)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(1430, 608)
        Me.tbc.TabIndex = 0
        '
        'tab_interest
        '
        Me.tab_interest.Controls.Add(Me.tb_int_rate)
        Me.tab_interest.Controls.Add(Me.tb_int_date)
        Me.tab_interest.Controls.Add(Me.tb_account_to_credit)
        Me.tab_interest.Controls.Add(Me.tb_period)
        Me.tab_interest.Controls.Add(Me.tb_start_date)
        Me.tab_interest.Controls.Add(Me.tb_end_acc)
        Me.tab_interest.Controls.Add(Me.tb_start_acc)
        Me.tab_interest.Controls.Add(Me.Label7)
        Me.tab_interest.Controls.Add(Me.Label2)
        Me.tab_interest.Controls.Add(Me.Label6)
        Me.tab_interest.Controls.Add(Me.Label5)
        Me.tab_interest.Controls.Add(Me.Label4)
        Me.tab_interest.Controls.Add(Me.Label3)
        Me.tab_interest.Controls.Add(Me.Label1)
        Me.tab_interest.Controls.Add(Me.btn_process_int)
        Me.tab_interest.Controls.Add(Me.btn_calculate_int)
        Me.tab_interest.Controls.Add(Me.dgv_interest)
        Me.tab_interest.Location = New System.Drawing.Point(4, 29)
        Me.tab_interest.Name = "tab_interest"
        Me.tab_interest.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_interest.Size = New System.Drawing.Size(1422, 575)
        Me.tab_interest.TabIndex = 0
        Me.tab_interest.Text = "Interest"
        Me.tab_interest.UseVisualStyleBackColor = True
        '
        'tb_int_rate
        '
        Me.tb_int_rate.Location = New System.Drawing.Point(967, 61)
        Me.tb_int_rate.Name = "tb_int_rate"
        Me.tb_int_rate.Size = New System.Drawing.Size(95, 26)
        Me.tb_int_rate.TabIndex = 16
        '
        'tb_int_date
        '
        Me.tb_int_date.Location = New System.Drawing.Point(710, 61)
        Me.tb_int_date.Name = "tb_int_date"
        Me.tb_int_date.Size = New System.Drawing.Size(150, 26)
        Me.tb_int_date.TabIndex = 15
        '
        'tb_account_to_credit
        '
        Me.tb_account_to_credit.Location = New System.Drawing.Point(1229, 21)
        Me.tb_account_to_credit.Name = "tb_account_to_credit"
        Me.tb_account_to_credit.Size = New System.Drawing.Size(150, 26)
        Me.tb_account_to_credit.TabIndex = 14
        '
        'tb_period
        '
        Me.tb_period.Location = New System.Drawing.Point(929, 21)
        Me.tb_period.Name = "tb_period"
        Me.tb_period.Size = New System.Drawing.Size(81, 26)
        Me.tb_period.TabIndex = 13
        '
        'tb_start_date
        '
        Me.tb_start_date.Location = New System.Drawing.Point(710, 21)
        Me.tb_start_date.Name = "tb_start_date"
        Me.tb_start_date.Size = New System.Drawing.Size(150, 26)
        Me.tb_start_date.TabIndex = 12
        '
        'tb_end_acc
        '
        Me.tb_end_acc.Location = New System.Drawing.Point(456, 21)
        Me.tb_end_acc.Name = "tb_end_acc"
        Me.tb_end_acc.Size = New System.Drawing.Size(150, 26)
        Me.tb_end_acc.TabIndex = 11
        '
        'tb_start_acc
        '
        Me.tb_start_acc.Location = New System.Drawing.Point(158, 21)
        Me.tb_start_acc.Name = "tb_start_acc"
        Me.tb_start_acc.Size = New System.Drawing.Size(150, 26)
        Me.tb_start_acc.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(608, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Interest Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ending Account"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(869, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Interest Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1090, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Account To Credit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(874, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Period"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(631, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Start Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Starting Account"
        '
        'btn_process_int
        '
        Me.btn_process_int.Location = New System.Drawing.Point(285, 58)
        Me.btn_process_int.Name = "btn_process_int"
        Me.btn_process_int.Size = New System.Drawing.Size(220, 32)
        Me.btn_process_int.TabIndex = 2
        Me.btn_process_int.Text = "Process Interest"
        Me.btn_process_int.UseVisualStyleBackColor = True
        '
        'btn_calculate_int
        '
        Me.btn_calculate_int.Location = New System.Drawing.Point(55, 58)
        Me.btn_calculate_int.Name = "btn_calculate_int"
        Me.btn_calculate_int.Size = New System.Drawing.Size(179, 32)
        Me.btn_calculate_int.TabIndex = 1
        Me.btn_calculate_int.Text = "Calculate Interest"
        Me.btn_calculate_int.UseVisualStyleBackColor = True
        '
        'dgv_interest
        '
        Me.dgv_interest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_interest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_interest.Location = New System.Drawing.Point(6, 101)
        Me.dgv_interest.Name = "dgv_interest"
        Me.dgv_interest.RowTemplate.Height = 28
        Me.dgv_interest.Size = New System.Drawing.Size(1400, 468)
        Me.dgv_interest.TabIndex = 0
        '
        'tab_penalt
        '
        Me.tab_penalt.Controls.Add(Me.tb_pen_thresh)
        Me.tab_penalt.Controls.Add(Me.Label15)
        Me.tab_penalt.Controls.Add(Me.tb_pen_rate)
        Me.tab_penalt.Controls.Add(Me.tb_end_date_pen)
        Me.tab_penalt.Controls.Add(Me.tb_acc_to_credit_pen)
        Me.tab_penalt.Controls.Add(Me.tb_period_pen)
        Me.tab_penalt.Controls.Add(Me.tb_start_date_pen)
        Me.tab_penalt.Controls.Add(Me.tb_end_acc_pen)
        Me.tab_penalt.Controls.Add(Me.tb_start_acc_pen)
        Me.tab_penalt.Controls.Add(Me.Label8)
        Me.tab_penalt.Controls.Add(Me.Label9)
        Me.tab_penalt.Controls.Add(Me.Label10)
        Me.tab_penalt.Controls.Add(Me.Label11)
        Me.tab_penalt.Controls.Add(Me.Label12)
        Me.tab_penalt.Controls.Add(Me.Label13)
        Me.tab_penalt.Controls.Add(Me.Label14)
        Me.tab_penalt.Controls.Add(Me.btn_process_pen)
        Me.tab_penalt.Controls.Add(Me.btn_calc_pen)
        Me.tab_penalt.Controls.Add(Me.dgv_pen)
        Me.tab_penalt.Location = New System.Drawing.Point(4, 29)
        Me.tab_penalt.Name = "tab_penalt"
        Me.tab_penalt.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_penalt.Size = New System.Drawing.Size(1422, 575)
        Me.tab_penalt.TabIndex = 1
        Me.tab_penalt.Text = "Penalt"
        Me.tab_penalt.UseVisualStyleBackColor = True
        '
        'tb_pen_thresh
        '
        Me.tb_pen_thresh.Location = New System.Drawing.Point(1230, 58)
        Me.tb_pen_thresh.Name = "tb_pen_thresh"
        Me.tb_pen_thresh.Size = New System.Drawing.Size(150, 26)
        Me.tb_pen_thresh.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1100, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 20)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Penalt Threshold"
        '
        'tb_pen_rate
        '
        Me.tb_pen_rate.Location = New System.Drawing.Point(968, 58)
        Me.tb_pen_rate.Name = "tb_pen_rate"
        Me.tb_pen_rate.Size = New System.Drawing.Size(95, 26)
        Me.tb_pen_rate.TabIndex = 33
        '
        'tb_end_date_pen
        '
        Me.tb_end_date_pen.Location = New System.Drawing.Point(711, 58)
        Me.tb_end_date_pen.Name = "tb_end_date_pen"
        Me.tb_end_date_pen.Size = New System.Drawing.Size(150, 26)
        Me.tb_end_date_pen.TabIndex = 32
        '
        'tb_acc_to_credit_pen
        '
        Me.tb_acc_to_credit_pen.Location = New System.Drawing.Point(1230, 18)
        Me.tb_acc_to_credit_pen.Name = "tb_acc_to_credit_pen"
        Me.tb_acc_to_credit_pen.Size = New System.Drawing.Size(150, 26)
        Me.tb_acc_to_credit_pen.TabIndex = 31
        '
        'tb_period_pen
        '
        Me.tb_period_pen.Location = New System.Drawing.Point(930, 18)
        Me.tb_period_pen.Name = "tb_period_pen"
        Me.tb_period_pen.Size = New System.Drawing.Size(81, 26)
        Me.tb_period_pen.TabIndex = 30
        '
        'tb_start_date_pen
        '
        Me.tb_start_date_pen.Location = New System.Drawing.Point(711, 18)
        Me.tb_start_date_pen.Name = "tb_start_date_pen"
        Me.tb_start_date_pen.Size = New System.Drawing.Size(150, 26)
        Me.tb_start_date_pen.TabIndex = 29
        '
        'tb_end_acc_pen
        '
        Me.tb_end_acc_pen.Location = New System.Drawing.Point(457, 18)
        Me.tb_end_acc_pen.Name = "tb_end_acc_pen"
        Me.tb_end_acc_pen.Size = New System.Drawing.Size(150, 26)
        Me.tb_end_acc_pen.TabIndex = 28
        '
        'tb_start_acc_pen
        '
        Me.tb_start_acc_pen.Location = New System.Drawing.Point(159, 18)
        Me.tb_start_acc_pen.Name = "tb_start_acc_pen"
        Me.tb_start_acc_pen.Size = New System.Drawing.Size(150, 26)
        Me.tb_start_acc_pen.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(609, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Penalt Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(339, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Ending Account"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(870, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Penalt Rate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1091, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Account To Credit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(875, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Period"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(632, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Start Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Starting Account"
        '
        'btn_process_pen
        '
        Me.btn_process_pen.Location = New System.Drawing.Point(297, 55)
        Me.btn_process_pen.Name = "btn_process_pen"
        Me.btn_process_pen.Size = New System.Drawing.Size(200, 32)
        Me.btn_process_pen.TabIndex = 19
        Me.btn_process_pen.Text = "Process Penalty"
        Me.btn_process_pen.UseVisualStyleBackColor = True
        '
        'btn_calc_pen
        '
        Me.btn_calc_pen.Location = New System.Drawing.Point(56, 55)
        Me.btn_calc_pen.Name = "btn_calc_pen"
        Me.btn_calc_pen.Size = New System.Drawing.Size(205, 32)
        Me.btn_calc_pen.TabIndex = 18
        Me.btn_calc_pen.Text = "Calculate Penalty"
        Me.btn_calc_pen.UseVisualStyleBackColor = True
        '
        'dgv_pen
        '
        Me.dgv_pen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_pen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pen.Location = New System.Drawing.Point(7, 98)
        Me.dgv_pen.Name = "dgv_pen"
        Me.dgv_pen.RowTemplate.Height = 28
        Me.dgv_pen.Size = New System.Drawing.Size(1400, 468)
        Me.dgv_pen.TabIndex = 17
        '
        'tab_payment
        '
        Me.tab_payment.Location = New System.Drawing.Point(4, 29)
        Me.tab_payment.Name = "tab_payment"
        Me.tab_payment.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_payment.Size = New System.Drawing.Size(1422, 575)
        Me.tab_payment.TabIndex = 2
        Me.tab_payment.Text = "Payment"
        Me.tab_payment.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1444, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetConnectionToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SetConnectionToolStripMenuItem
        '
        Me.SetConnectionToolStripMenuItem.Name = "SetConnectionToolStripMenuItem"
        Me.SetConnectionToolStripMenuItem.Size = New System.Drawing.Size(204, 30)
        Me.SetConnectionToolStripMenuItem.Text = "Set Connection"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 695)
        Me.Controls.Add(Me.tbc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Interrest Calculator"
        Me.tbc.ResumeLayout(False)
        Me.tab_interest.ResumeLayout(False)
        Me.tab_interest.PerformLayout()
        CType(Me.dgv_interest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_penalt.ResumeLayout(False)
        Me.tab_penalt.PerformLayout()
        CType(Me.dgv_pen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbc As System.Windows.Forms.TabControl
    Friend WithEvents tab_interest As System.Windows.Forms.TabPage
    Friend WithEvents tab_penalt As System.Windows.Forms.TabPage
    Friend WithEvents tab_payment As System.Windows.Forms.TabPage
    Friend WithEvents dgv_interest As System.Windows.Forms.DataGridView
    Friend WithEvents btn_process_int As System.Windows.Forms.Button
    Friend WithEvents btn_calculate_int As System.Windows.Forms.Button
    Friend WithEvents tb_int_rate As System.Windows.Forms.TextBox
    Friend WithEvents tb_int_date As System.Windows.Forms.TextBox
    Friend WithEvents tb_account_to_credit As System.Windows.Forms.TextBox
    Friend WithEvents tb_period As System.Windows.Forms.TextBox
    Friend WithEvents tb_start_date As System.Windows.Forms.TextBox
    Friend WithEvents tb_end_acc As System.Windows.Forms.TextBox
    Friend WithEvents tb_start_acc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tb_pen_rate As System.Windows.Forms.TextBox
    Friend WithEvents tb_end_date_pen As System.Windows.Forms.TextBox
    Friend WithEvents tb_acc_to_credit_pen As System.Windows.Forms.TextBox
    Friend WithEvents tb_period_pen As System.Windows.Forms.TextBox
    Friend WithEvents tb_start_date_pen As System.Windows.Forms.TextBox
    Friend WithEvents tb_end_acc_pen As System.Windows.Forms.TextBox
    Friend WithEvents tb_start_acc_pen As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_process_pen As System.Windows.Forms.Button
    Friend WithEvents btn_calc_pen As System.Windows.Forms.Button
    Friend WithEvents dgv_pen As System.Windows.Forms.DataGridView
    Friend WithEvents tb_pen_thresh As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
