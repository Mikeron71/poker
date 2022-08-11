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
        Me.tb_nom = New System.Windows.Forms.TextBox()
        Me.nud_nbJoueurs = New System.Windows.Forms.NumericUpDown()
        Me.lb_nom = New System.Windows.Forms.Label()
        Me.lb_nbJoueurs = New System.Windows.Forms.Label()
        Me.btn_lancer = New System.Windows.Forms.Button()
        CType(Me.nud_nbJoueurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_titre
        '
        Me.lb_titre.AutoSize = True
        Me.lb_titre.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lb_titre.Location = New System.Drawing.Point(278, 109)
        Me.lb_titre.Name = "lb_titre"
        Me.lb_titre.Size = New System.Drawing.Size(621, 41)
        Me.lb_titre.TabIndex = 0
        Me.lb_titre.Text = "Super mega visual basic poker game"
        '
        'tb_nom
        '
        Me.tb_nom.Location = New System.Drawing.Point(278, 377)
        Me.tb_nom.Name = "tb_nom"
        Me.tb_nom.Size = New System.Drawing.Size(201, 23)
        Me.tb_nom.TabIndex = 1
        '
        'nud_nbJoueurs
        '
        Me.nud_nbJoueurs.Location = New System.Drawing.Point(779, 378)
        Me.nud_nbJoueurs.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nud_nbJoueurs.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_nbJoueurs.Name = "nud_nbJoueurs"
        Me.nud_nbJoueurs.Size = New System.Drawing.Size(120, 23)
        Me.nud_nbJoueurs.TabIndex = 2
        Me.nud_nbJoueurs.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lb_nom
        '
        Me.lb_nom.AutoSize = True
        Me.lb_nom.Location = New System.Drawing.Point(181, 380)
        Me.lb_nom.Name = "lb_nom"
        Me.lb_nom.Size = New System.Drawing.Size(68, 15)
        Me.lb_nom.TabIndex = 3
        Me.lb_nom.Text = "Votre nom :"
        '
        'lb_nbJoueurs
        '
        Me.lb_nbJoueurs.AutoSize = True
        Me.lb_nbJoueurs.Location = New System.Drawing.Point(542, 380)
        Me.lb_nbJoueurs.Name = "lb_nbJoueurs"
        Me.lb_nbJoueurs.Size = New System.Drawing.Size(189, 15)
        Me.lb_nbJoueurs.TabIndex = 4
        Me.lb_nbJoueurs.Text = "Choisissez le nombre d'adversaires"
        '
        'btn_lancer
        '
        Me.btn_lancer.Location = New System.Drawing.Point(868, 551)
        Me.btn_lancer.Name = "btn_lancer"
        Me.btn_lancer.Size = New System.Drawing.Size(117, 56)
        Me.btn_lancer.TabIndex = 5
        Me.btn_lancer.Text = "Lancer la partie"
        Me.btn_lancer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 850)
        Me.Controls.Add(Me.btn_lancer)
        Me.Controls.Add(Me.lb_nbJoueurs)
        Me.Controls.Add(Me.lb_nom)
        Me.Controls.Add(Me.nud_nbJoueurs)
        Me.Controls.Add(Me.tb_nom)
        Me.Controls.Add(Me.lb_titre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nud_nbJoueurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_titre As Label
    Friend WithEvents tb_nom As TextBox
    Friend WithEvents nud_nbJoueurs As NumericUpDown
    Friend WithEvents lb_nom As Label
    Friend WithEvents lb_nbJoueurs As Label
    Friend WithEvents btn_lancer As Button
End Class
