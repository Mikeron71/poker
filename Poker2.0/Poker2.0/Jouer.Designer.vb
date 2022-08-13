<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jouer
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
        Me.pb_carte1 = New System.Windows.Forms.PictureBox()
        Me.pb_carte2 = New System.Windows.Forms.PictureBox()
        Me.pb_carte3 = New System.Windows.Forms.PictureBox()
        Me.pb_carte4 = New System.Windows.Forms.PictureBox()
        Me.pb_carte5 = New System.Windows.Forms.PictureBox()
        Me.lb_credits = New System.Windows.Forms.Label()
        Me.lb_creditData = New System.Windows.Forms.Label()
        Me.cb_carte1 = New System.Windows.Forms.CheckBox()
        Me.cb_carte2 = New System.Windows.Forms.CheckBox()
        Me.cb_carte3 = New System.Windows.Forms.CheckBox()
        Me.cb_carte4 = New System.Windows.Forms.CheckBox()
        Me.cb_carte5 = New System.Windows.Forms.CheckBox()
        Me.btn_jouer = New System.Windows.Forms.Button()
        Me.btn_remplacer = New System.Windows.Forms.Button()
        Me.btn_verifier = New System.Windows.Forms.Button()
        Me.tb_win = New System.Windows.Forms.TextBox()
        Me.tb_pc1 = New System.Windows.Forms.TextBox()
        Me.tb_pc2 = New System.Windows.Forms.TextBox()
        Me.tb_pc3 = New System.Windows.Forms.TextBox()
        Me.nud_mise = New System.Windows.Forms.NumericUpDown()
        Me.btn_miser = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.pan_remplacer = New System.Windows.Forms.Panel()
        Me.pan_mise = New System.Windows.Forms.Panel()
        Me.tb_votreMain = New System.Windows.Forms.TextBox()
        CType(Me.pb_carte1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_carte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_carte3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_carte4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_carte5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_mise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_remplacer.SuspendLayout()
        Me.pan_mise.SuspendLayout()
        Me.SuspendLayout()
        '
        'pb_carte1
        '
        Me.pb_carte1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_carte1.Image = Global.Poker2._0.My.Resources.Resources.CB
        Me.pb_carte1.Location = New System.Drawing.Point(149, 188)
        Me.pb_carte1.Name = "pb_carte1"
        Me.pb_carte1.Size = New System.Drawing.Size(180, 250)
        Me.pb_carte1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_carte1.TabIndex = 0
        Me.pb_carte1.TabStop = False
        '
        'pb_carte2
        '
        Me.pb_carte2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_carte2.Image = Global.Poker2._0.My.Resources.Resources.CB
        Me.pb_carte2.Location = New System.Drawing.Point(335, 188)
        Me.pb_carte2.Name = "pb_carte2"
        Me.pb_carte2.Size = New System.Drawing.Size(180, 250)
        Me.pb_carte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_carte2.TabIndex = 1
        Me.pb_carte2.TabStop = False
        '
        'pb_carte3
        '
        Me.pb_carte3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_carte3.Image = Global.Poker2._0.My.Resources.Resources.CB
        Me.pb_carte3.Location = New System.Drawing.Point(521, 188)
        Me.pb_carte3.Name = "pb_carte3"
        Me.pb_carte3.Size = New System.Drawing.Size(180, 250)
        Me.pb_carte3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_carte3.TabIndex = 2
        Me.pb_carte3.TabStop = False
        '
        'pb_carte4
        '
        Me.pb_carte4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_carte4.Image = Global.Poker2._0.My.Resources.Resources.CB
        Me.pb_carte4.Location = New System.Drawing.Point(707, 188)
        Me.pb_carte4.Name = "pb_carte4"
        Me.pb_carte4.Size = New System.Drawing.Size(180, 250)
        Me.pb_carte4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_carte4.TabIndex = 3
        Me.pb_carte4.TabStop = False
        '
        'pb_carte5
        '
        Me.pb_carte5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_carte5.Image = Global.Poker2._0.My.Resources.Resources.CB
        Me.pb_carte5.Location = New System.Drawing.Point(893, 188)
        Me.pb_carte5.Name = "pb_carte5"
        Me.pb_carte5.Size = New System.Drawing.Size(180, 250)
        Me.pb_carte5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_carte5.TabIndex = 4
        Me.pb_carte5.TabStop = False
        '
        'lb_credits
        '
        Me.lb_credits.AutoSize = True
        Me.lb_credits.ForeColor = System.Drawing.Color.Chocolate
        Me.lb_credits.Location = New System.Drawing.Point(31, 17)
        Me.lb_credits.Name = "lb_credits"
        Me.lb_credits.Size = New System.Drawing.Size(66, 15)
        Me.lb_credits.TabIndex = 5
        Me.lb_credits.Text = "Vos credits:"
        '
        'lb_creditData
        '
        Me.lb_creditData.AutoSize = True
        Me.lb_creditData.ForeColor = System.Drawing.Color.Chocolate
        Me.lb_creditData.Location = New System.Drawing.Point(118, 17)
        Me.lb_creditData.Name = "lb_creditData"
        Me.lb_creditData.Size = New System.Drawing.Size(35, 15)
        Me.lb_creditData.TabIndex = 6
        Me.lb_creditData.Text = "DATA"
        '
        'cb_carte1
        '
        Me.cb_carte1.AutoSize = True
        Me.cb_carte1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_carte1.ForeColor = System.Drawing.Color.Chocolate
        Me.cb_carte1.Location = New System.Drawing.Point(44, 7)
        Me.cb_carte1.Name = "cb_carte1"
        Me.cb_carte1.Size = New System.Drawing.Size(105, 24)
        Me.cb_carte1.TabIndex = 7
        Me.cb_carte1.Text = "Remplacer"
        Me.cb_carte1.UseVisualStyleBackColor = True
        '
        'cb_carte2
        '
        Me.cb_carte2.AutoSize = True
        Me.cb_carte2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_carte2.ForeColor = System.Drawing.Color.Chocolate
        Me.cb_carte2.Location = New System.Drawing.Point(225, 7)
        Me.cb_carte2.Name = "cb_carte2"
        Me.cb_carte2.Size = New System.Drawing.Size(105, 24)
        Me.cb_carte2.TabIndex = 8
        Me.cb_carte2.Text = "Remplacer"
        Me.cb_carte2.UseVisualStyleBackColor = True
        '
        'cb_carte3
        '
        Me.cb_carte3.AutoSize = True
        Me.cb_carte3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_carte3.ForeColor = System.Drawing.Color.Chocolate
        Me.cb_carte3.Location = New System.Drawing.Point(420, 7)
        Me.cb_carte3.Name = "cb_carte3"
        Me.cb_carte3.Size = New System.Drawing.Size(105, 24)
        Me.cb_carte3.TabIndex = 9
        Me.cb_carte3.Text = "Remplacer"
        Me.cb_carte3.UseVisualStyleBackColor = True
        '
        'cb_carte4
        '
        Me.cb_carte4.AutoSize = True
        Me.cb_carte4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_carte4.ForeColor = System.Drawing.Color.Chocolate
        Me.cb_carte4.Location = New System.Drawing.Point(609, 7)
        Me.cb_carte4.Name = "cb_carte4"
        Me.cb_carte4.Size = New System.Drawing.Size(105, 24)
        Me.cb_carte4.TabIndex = 10
        Me.cb_carte4.Text = "Remplacer"
        Me.cb_carte4.UseVisualStyleBackColor = True
        '
        'cb_carte5
        '
        Me.cb_carte5.AutoSize = True
        Me.cb_carte5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cb_carte5.ForeColor = System.Drawing.Color.Chocolate
        Me.cb_carte5.Location = New System.Drawing.Point(792, 7)
        Me.cb_carte5.Name = "cb_carte5"
        Me.cb_carte5.Size = New System.Drawing.Size(105, 24)
        Me.cb_carte5.TabIndex = 11
        Me.cb_carte5.Text = "Remplacer"
        Me.cb_carte5.UseVisualStyleBackColor = True
        '
        'btn_jouer
        '
        Me.btn_jouer.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_jouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jouer.Enabled = False
        Me.btn_jouer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_jouer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_jouer.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_jouer.Location = New System.Drawing.Point(682, 524)
        Me.btn_jouer.Name = "btn_jouer"
        Me.btn_jouer.Size = New System.Drawing.Size(158, 50)
        Me.btn_jouer.TabIndex = 12
        Me.btn_jouer.Text = "Distribuer les cartes"
        Me.btn_jouer.UseVisualStyleBackColor = False
        '
        'btn_remplacer
        '
        Me.btn_remplacer.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_remplacer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_remplacer.Enabled = False
        Me.btn_remplacer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_remplacer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_remplacer.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_remplacer.Location = New System.Drawing.Point(149, 507)
        Me.btn_remplacer.Name = "btn_remplacer"
        Me.btn_remplacer.Size = New System.Drawing.Size(158, 50)
        Me.btn_remplacer.TabIndex = 13
        Me.btn_remplacer.Text = "Remplacer cartes"
        Me.btn_remplacer.UseVisualStyleBackColor = False
        '
        'btn_verifier
        '
        Me.btn_verifier.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_verifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_verifier.Enabled = False
        Me.btn_verifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_verifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_verifier.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_verifier.Location = New System.Drawing.Point(682, 599)
        Me.btn_verifier.Name = "btn_verifier"
        Me.btn_verifier.Size = New System.Drawing.Size(158, 50)
        Me.btn_verifier.TabIndex = 14
        Me.btn_verifier.Text = "Vérifier"
        Me.btn_verifier.UseVisualStyleBackColor = False
        '
        'tb_win
        '
        Me.tb_win.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.tb_win.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tb_win.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_win.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_win.ForeColor = System.Drawing.Color.Chocolate
        Me.tb_win.Location = New System.Drawing.Point(224, 30)
        Me.tb_win.Name = "tb_win"
        Me.tb_win.ReadOnly = True
        Me.tb_win.Size = New System.Drawing.Size(752, 64)
        Me.tb_win.TabIndex = 15
        Me.tb_win.TabStop = False
        Me.tb_win.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_pc1
        '
        Me.tb_pc1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tb_pc1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_pc1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_pc1.ForeColor = System.Drawing.Color.Chocolate
        Me.tb_pc1.Location = New System.Drawing.Point(182, 160)
        Me.tb_pc1.Name = "tb_pc1"
        Me.tb_pc1.Size = New System.Drawing.Size(286, 22)
        Me.tb_pc1.TabIndex = 16
        Me.tb_pc1.TabStop = False
        Me.tb_pc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_pc1.Visible = False
        '
        'tb_pc2
        '
        Me.tb_pc2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tb_pc2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_pc2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_pc2.ForeColor = System.Drawing.Color.Chocolate
        Me.tb_pc2.Location = New System.Drawing.Point(469, 160)
        Me.tb_pc2.Name = "tb_pc2"
        Me.tb_pc2.Size = New System.Drawing.Size(298, 22)
        Me.tb_pc2.TabIndex = 17
        Me.tb_pc2.TabStop = False
        Me.tb_pc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_pc2.Visible = False
        '
        'tb_pc3
        '
        Me.tb_pc3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tb_pc3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_pc3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_pc3.ForeColor = System.Drawing.Color.Chocolate
        Me.tb_pc3.Location = New System.Drawing.Point(767, 160)
        Me.tb_pc3.Name = "tb_pc3"
        Me.tb_pc3.Size = New System.Drawing.Size(256, 22)
        Me.tb_pc3.TabIndex = 18
        Me.tb_pc3.TabStop = False
        Me.tb_pc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tb_pc3.Visible = False
        '
        'nud_mise
        '
        Me.nud_mise.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nud_mise.Location = New System.Drawing.Point(31, 45)
        Me.nud_mise.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_mise.Name = "nud_mise"
        Me.nud_mise.Size = New System.Drawing.Size(48, 33)
        Me.nud_mise.TabIndex = 20
        Me.nud_mise.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_miser
        '
        Me.btn_miser.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_miser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_miser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_miser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_miser.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_miser.Location = New System.Drawing.Point(100, 45)
        Me.btn_miser.Name = "btn_miser"
        Me.btn_miser.Size = New System.Drawing.Size(75, 23)
        Me.btn_miser.TabIndex = 21
        Me.btn_miser.Text = "Miser"
        Me.btn_miser.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_modifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modifier.Enabled = False
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_modifier.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_modifier.ForeColor = System.Drawing.Color.DarkOrange
        Me.btn_modifier.Location = New System.Drawing.Point(100, 74)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(75, 23)
        Me.btn_modifier.TabIndex = 22
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'pan_remplacer
        '
        Me.pan_remplacer.Controls.Add(Me.cb_carte1)
        Me.pan_remplacer.Controls.Add(Me.cb_carte2)
        Me.pan_remplacer.Controls.Add(Me.cb_carte3)
        Me.pan_remplacer.Controls.Add(Me.cb_carte4)
        Me.pan_remplacer.Controls.Add(Me.cb_carte5)
        Me.pan_remplacer.Location = New System.Drawing.Point(149, 444)
        Me.pan_remplacer.Name = "pan_remplacer"
        Me.pan_remplacer.Size = New System.Drawing.Size(935, 32)
        Me.pan_remplacer.TabIndex = 23
        Me.pan_remplacer.Visible = False
        '
        'pan_mise
        '
        Me.pan_mise.BackColor = System.Drawing.Color.PeachPuff
        Me.pan_mise.Controls.Add(Me.lb_credits)
        Me.pan_mise.Controls.Add(Me.lb_creditData)
        Me.pan_mise.Controls.Add(Me.btn_modifier)
        Me.pan_mise.Controls.Add(Me.nud_mise)
        Me.pan_mise.Controls.Add(Me.btn_miser)
        Me.pan_mise.Location = New System.Drawing.Point(877, 524)
        Me.pan_mise.Name = "pan_mise"
        Me.pan_mise.Size = New System.Drawing.Size(200, 114)
        Me.pan_mise.TabIndex = 24
        '
        'tb_votreMain
        '
        Me.tb_votreMain.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tb_votreMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_votreMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tb_votreMain.ForeColor = System.Drawing.Color.Chocolate
        Me.tb_votreMain.Location = New System.Drawing.Point(149, 591)
        Me.tb_votreMain.Name = "tb_votreMain"
        Me.tb_votreMain.Size = New System.Drawing.Size(366, 31)
        Me.tb_votreMain.TabIndex = 25
        Me.tb_votreMain.TabStop = False
        Me.tb_votreMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Jouer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1212, 850)
        Me.Controls.Add(Me.btn_verifier)
        Me.Controls.Add(Me.tb_votreMain)
        Me.Controls.Add(Me.btn_jouer)
        Me.Controls.Add(Me.pan_mise)
        Me.Controls.Add(Me.btn_remplacer)
        Me.Controls.Add(Me.pan_remplacer)
        Me.Controls.Add(Me.tb_pc3)
        Me.Controls.Add(Me.tb_pc2)
        Me.Controls.Add(Me.tb_pc1)
        Me.Controls.Add(Me.tb_win)
        Me.Controls.Add(Me.pb_carte5)
        Me.Controls.Add(Me.pb_carte4)
        Me.Controls.Add(Me.pb_carte3)
        Me.Controls.Add(Me.pb_carte2)
        Me.Controls.Add(Me.pb_carte1)
        Me.Name = "Jouer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jouer"
        CType(Me.pb_carte1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_carte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_carte3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_carte4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_carte5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_mise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_remplacer.ResumeLayout(False)
        Me.pan_remplacer.PerformLayout()
        Me.pan_mise.ResumeLayout(False)
        Me.pan_mise.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_carte1 As PictureBox
    Friend WithEvents pb_carte2 As PictureBox
    Friend WithEvents pb_carte3 As PictureBox
    Friend WithEvents pb_carte4 As PictureBox
    Friend WithEvents pb_carte5 As PictureBox
    Friend WithEvents lb_credits As Label
    Friend WithEvents lb_creditData As Label
    Friend WithEvents cb_carte1 As CheckBox
    Friend WithEvents cb_carte2 As CheckBox
    Friend WithEvents cb_carte3 As CheckBox
    Friend WithEvents cb_carte4 As CheckBox
    Friend WithEvents cb_carte5 As CheckBox
    Friend WithEvents btn_jouer As Button
    Friend WithEvents btn_remplacer As Button
    Friend WithEvents btn_verifier As Button
    Friend WithEvents tb_win As TextBox
    Friend WithEvents tb_pc1 As TextBox
    Friend WithEvents tb_pc2 As TextBox
    Friend WithEvents tb_pc3 As TextBox
    Friend WithEvents nud_mise As NumericUpDown
    Friend WithEvents btn_miser As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents pan_remplacer As Panel
    Friend WithEvents pan_mise As Panel
    Friend WithEvents tb_votreMain As TextBox
End Class
