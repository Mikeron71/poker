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
        Me.lb_titre = New System.Windows.Forms.Label()
        Me.nud_nbJoueurs = New System.Windows.Forms.NumericUpDown()
        Me.lb_nbJoueurs = New System.Windows.Forms.Label()
        Me.btn_lancer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nud_nbJoueurs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_titre
        '
        Me.lb_titre.AutoSize = True
        Me.lb_titre.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lb_titre.ForeColor = System.Drawing.Color.Chocolate
        Me.lb_titre.Location = New System.Drawing.Point(347, 29)
        Me.lb_titre.Name = "lb_titre"
        Me.lb_titre.Size = New System.Drawing.Size(495, 41)
        Me.lb_titre.TabIndex = 0
        Me.lb_titre.Text = "SUPER MEGA VISUAL BASIC"
        '
        'nud_nbJoueurs
        '
        Me.nud_nbJoueurs.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nud_nbJoueurs.ForeColor = System.Drawing.Color.Chocolate
        Me.nud_nbJoueurs.Location = New System.Drawing.Point(874, 379)
        Me.nud_nbJoueurs.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nud_nbJoueurs.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_nbJoueurs.Name = "nud_nbJoueurs"
        Me.nud_nbJoueurs.Size = New System.Drawing.Size(46, 43)
        Me.nud_nbJoueurs.TabIndex = 2
        Me.nud_nbJoueurs.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lb_nbJoueurs
        '
        Me.lb_nbJoueurs.AutoSize = True
        Me.lb_nbJoueurs.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lb_nbJoueurs.ForeColor = System.Drawing.Color.Chocolate
        Me.lb_nbJoueurs.Location = New System.Drawing.Point(742, 291)
        Me.lb_nbJoueurs.Name = "lb_nbJoueurs"
        Me.lb_nbJoueurs.Size = New System.Drawing.Size(427, 37)
        Me.lb_nbJoueurs.TabIndex = 4
        Me.lb_nbJoueurs.Text = "Choisissez le nombre d'adversaires"
        '
        'btn_lancer
        '
        Me.btn_lancer.BackColor = System.Drawing.Color.FloralWhite
        Me.btn_lancer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lancer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_lancer.ForeColor = System.Drawing.Color.Chocolate
        Me.btn_lancer.Location = New System.Drawing.Point(966, 379)
        Me.btn_lancer.Name = "btn_lancer"
        Me.btn_lancer.Size = New System.Drawing.Size(117, 43)
        Me.btn_lancer.TabIndex = 5
        Me.btn_lancer.Text = "Lancer la partie"
        Me.btn_lancer.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Poker2._0.My.Resources.Resources.pngegg
        Me.PictureBox1.Location = New System.Drawing.Point(31, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(795, 574)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(484, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "POKER GAME"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1212, 850)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_lancer)
        Me.Controls.Add(Me.lb_nbJoueurs)
        Me.Controls.Add(Me.nud_nbJoueurs)
        Me.Controls.Add(Me.lb_titre)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.nud_nbJoueurs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_titre As Label
    Friend WithEvents nud_nbJoueurs As NumericUpDown
    Friend WithEvents lb_nbJoueurs As Label
    Friend WithEvents btn_lancer As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
