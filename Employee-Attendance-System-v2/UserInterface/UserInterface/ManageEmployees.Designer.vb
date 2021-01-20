<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEmployees
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
        Me.DGVEmployees = New System.Windows.Forms.DataGridView()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.tb_age = New System.Windows.Forms.TextBox()
        Me.tb_phone_no = New System.Windows.Forms.TextBox()
        Me.tb_employee_no = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.DGVEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVEmployees
        '
        Me.DGVEmployees.AllowUserToAddRows = False
        Me.DGVEmployees.AllowUserToDeleteRows = False
        Me.DGVEmployees.AllowUserToOrderColumns = True
        Me.DGVEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEmployees.Location = New System.Drawing.Point(276, 30)
        Me.DGVEmployees.Name = "DGVEmployees"
        Me.DGVEmployees.ReadOnly = True
        Me.DGVEmployees.Size = New System.Drawing.Size(488, 271)
        Me.DGVEmployees.TabIndex = 0
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(94, 66)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.ReadOnly = True
        Me.tb_name.Size = New System.Drawing.Size(165, 20)
        Me.tb_name.TabIndex = 1
        '
        'tb_age
        '
        Me.tb_age.Location = New System.Drawing.Point(94, 104)
        Me.tb_age.Name = "tb_age"
        Me.tb_age.Size = New System.Drawing.Size(165, 20)
        Me.tb_age.TabIndex = 2
        '
        'tb_phone_no
        '
        Me.tb_phone_no.Location = New System.Drawing.Point(94, 144)
        Me.tb_phone_no.Name = "tb_phone_no"
        Me.tb_phone_no.Size = New System.Drawing.Size(165, 20)
        Me.tb_phone_no.TabIndex = 3
        '
        'tb_employee_no
        '
        Me.tb_employee_no.Location = New System.Drawing.Point(94, 182)
        Me.tb_employee_no.Name = "tb_employee_no"
        Me.tb_employee_no.Size = New System.Drawing.Size(165, 20)
        Me.tb_employee_no.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Employee No.:"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(184, 231)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(80, 231)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 10
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'ManageEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 320)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_employee_no)
        Me.Controls.Add(Me.tb_phone_no)
        Me.Controls.Add(Me.tb_age)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.DGVEmployees)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ManageEmployees"
        Me.Text = "Manage Employees"
        CType(Me.DGVEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVEmployees As DataGridView
    Friend WithEvents tb_name As TextBox
    Friend WithEvents tb_age As TextBox
    Friend WithEvents tb_phone_no As TextBox
    Friend WithEvents tb_employee_no As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
End Class
