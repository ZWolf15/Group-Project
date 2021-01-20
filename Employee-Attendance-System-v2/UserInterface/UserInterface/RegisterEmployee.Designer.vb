<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterEmployee))
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.tb_age = New System.Windows.Forms.TextBox()
        Me.tb_employee_number = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_phone_number = New System.Windows.Forms.TextBox()
        Me.btn_register_face = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(189, 64)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(178, 20)
        Me.tb_name.TabIndex = 0
        '
        'tb_age
        '
        Me.tb_age.Location = New System.Drawing.Point(189, 105)
        Me.tb_age.Name = "tb_age"
        Me.tb_age.Size = New System.Drawing.Size(178, 20)
        Me.tb_age.TabIndex = 1
        '
        'tb_employee_number
        '
        Me.tb_employee_number.Location = New System.Drawing.Point(189, 143)
        Me.tb_employee_number.Name = "tb_employee_number"
        Me.tb_employee_number.Size = New System.Drawing.Size(178, 20)
        Me.tb_employee_number.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(53, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(53, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(53, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Employee Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(53, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email:"
        '
        'tb_phone_number
        '
        Me.tb_phone_number.Location = New System.Drawing.Point(189, 184)
        Me.tb_phone_number.Name = "tb_phone_number"
        Me.tb_phone_number.Size = New System.Drawing.Size(178, 20)
        Me.tb_phone_number.TabIndex = 6
        '
        'btn_register_face
        '
        Me.btn_register_face.BackgroundImage = CType(resources.GetObject("btn_register_face.BackgroundImage"), System.Drawing.Image)
        Me.btn_register_face.Image = CType(resources.GetObject("btn_register_face.Image"), System.Drawing.Image)
        Me.btn_register_face.Location = New System.Drawing.Point(269, 223)
        Me.btn_register_face.Name = "btn_register_face"
        Me.btn_register_face.Size = New System.Drawing.Size(98, 24)
        Me.btn_register_face.TabIndex = 8
        Me.btn_register_face.Text = "Register Face"
        Me.btn_register_face.UseVisualStyleBackColor = True
        '
        'btn_register
        '
        Me.btn_register.BackgroundImage = CType(resources.GetObject("btn_register.BackgroundImage"), System.Drawing.Image)
        Me.btn_register.Image = CType(resources.GetObject("btn_register.Image"), System.Drawing.Image)
        Me.btn_register.Location = New System.Drawing.Point(131, 278)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(75, 23)
        Me.btn_register.TabIndex = 9
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.BackgroundImage = CType(resources.GetObject("btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(248, 278)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'RegisterEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UserInterface.My.Resources.Resources.gridimage1
        Me.ClientSize = New System.Drawing.Size(467, 343)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.btn_register_face)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_phone_number)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_employee_number)
        Me.Controls.Add(Me.tb_age)
        Me.Controls.Add(Me.tb_name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.name = "RegisterEmployee"
        Me.Text = "Register New Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_name As TextBox
    Friend WithEvents tb_age As TextBox
    Friend WithEvents tb_employee_number As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_phone_number As TextBox
    Friend WithEvents btn_register_face As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents btn_cancel As Button
End Class
