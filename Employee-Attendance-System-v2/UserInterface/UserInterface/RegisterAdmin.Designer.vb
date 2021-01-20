<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterAdmin
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
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_register_admin = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.tb_password2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tb_username
        '
        Me.tb_username.BackColor = System.Drawing.Color.MintCream
        Me.tb_username.Location = New System.Drawing.Point(243, 90)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(181, 20)
        Me.tb_username.TabIndex = 0
        '
        'tb_password
        '
        Me.tb_password.BackColor = System.Drawing.Color.MintCream
        Me.tb_password.Location = New System.Drawing.Point(243, 126)
        Me.tb_password.MaxLength = 20
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(181, 20)
        Me.tb_password.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MintCream
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Image = Global.UserInterface.My.Resources.Resources.B
        Me.Label1.Location = New System.Drawing.Point(131, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MintCream
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Image = Global.UserInterface.My.Resources.Resources.B
        Me.Label2.Location = New System.Drawing.Point(131, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MintCream
        Me.Label3.Image = Global.UserInterface.My.Resources.Resources.B
        Me.Label3.Location = New System.Drawing.Point(131, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Repeat Password: "
        '
        'btn_register_admin
        '
        Me.btn_register_admin.BackColor = System.Drawing.Color.Aqua
        Me.btn_register_admin.Location = New System.Drawing.Point(180, 223)
        Me.btn_register_admin.Name = "btn_register_admin"
        Me.btn_register_admin.Size = New System.Drawing.Size(61, 27)
        Me.btn_register_admin.TabIndex = 6
        Me.btn_register_admin.Text = "Register"
        Me.btn_register_admin.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Aqua
        Me.btn_clear.Location = New System.Drawing.Point(291, 223)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(61, 27)
        Me.btn_clear.TabIndex = 7
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'tb_password2
        '
        Me.tb_password2.BackColor = System.Drawing.Color.MintCream
        Me.tb_password2.Location = New System.Drawing.Point(243, 167)
        Me.tb_password2.MaxLength = 20
        Me.tb_password2.Name = "tb_password2"
        Me.tb_password2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password2.Size = New System.Drawing.Size(181, 20)
        Me.tb_password2.TabIndex = 2
        '
        'RegisterAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UserInterface.My.Resources.Resources.B5
        Me.ClientSize = New System.Drawing.Size(575, 323)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_register_admin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_password2)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "RegisterAdmin"
        Me.Text = "Register New Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_username As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_register_admin As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents tb_password2 As TextBox
End Class
