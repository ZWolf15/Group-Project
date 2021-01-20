<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attendance
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
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageEmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageAdminsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaceRecognitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartFaceRecognitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainFaceRecognitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Location = New System.Drawing.Point(52, 46)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.Size = New System.Drawing.Size(767, 302)
        Me.DGV2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEmployeeToolStripMenuItem, Me.AdminToolStripMenuItem, Me.FaceRecognitionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewEmployeeToolStripMenuItem
        '
        Me.NewEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewEmployeeToolStripMenuItem, Me.ManageEmployeesToolStripMenuItem, Me.PrintToPDFToolStripMenuItem})
        Me.NewEmployeeToolStripMenuItem.Name = "NewEmployeeToolStripMenuItem"
        Me.NewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.NewEmployeeToolStripMenuItem.Text = "Employee"
        '
        'AddNewEmployeeToolStripMenuItem
        '
        Me.AddNewEmployeeToolStripMenuItem.Name = "AddNewEmployeeToolStripMenuItem"
        Me.AddNewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewEmployeeToolStripMenuItem.Text = "Add New Employee"
        '
        'ManageEmployeesToolStripMenuItem
        '
        Me.ManageEmployeesToolStripMenuItem.Name = "ManageEmployeesToolStripMenuItem"
        Me.ManageEmployeesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ManageEmployeesToolStripMenuItem.Text = "Manage Employees"
        '
        'PrintToPDFToolStripMenuItem
        '
        Me.PrintToPDFToolStripMenuItem.Name = "PrintToPDFToolStripMenuItem"
        Me.PrintToPDFToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintToPDFToolStripMenuItem.Text = "Print To PDF"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewAdminToolStripMenuItem, Me.ManageAdminsToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'AddNewAdminToolStripMenuItem
        '
        Me.AddNewAdminToolStripMenuItem.Name = "AddNewAdminToolStripMenuItem"
        Me.AddNewAdminToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AddNewAdminToolStripMenuItem.Text = "Add New Admin"
        '
        'ManageAdminsToolStripMenuItem
        '
        Me.ManageAdminsToolStripMenuItem.Name = "ManageAdminsToolStripMenuItem"
        Me.ManageAdminsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ManageAdminsToolStripMenuItem.Text = "Manage Admins"
        '
        'FaceRecognitionToolStripMenuItem
        '
        Me.FaceRecognitionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartFaceRecognitionToolStripMenuItem, Me.TrainFaceRecognitionToolStripMenuItem})
        Me.FaceRecognitionToolStripMenuItem.Name = "FaceRecognitionToolStripMenuItem"
        Me.FaceRecognitionToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.FaceRecognitionToolStripMenuItem.Text = "Face Recognition"
        '
        'StartFaceRecognitionToolStripMenuItem
        '
        Me.StartFaceRecognitionToolStripMenuItem.Name = "StartFaceRecognitionToolStripMenuItem"
        Me.StartFaceRecognitionToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.StartFaceRecognitionToolStripMenuItem.Text = "Start Face Recognition"
        '
        'TrainFaceRecognitionToolStripMenuItem
        '
        Me.TrainFaceRecognitionToolStripMenuItem.Name = "TrainFaceRecognitionToolStripMenuItem"
        Me.TrainFaceRecognitionToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.TrainFaceRecognitionToolStripMenuItem.Text = "Train Face Recognition"
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UserInterface.My.Resources.Resources.D
        Me.ClientSize = New System.Drawing.Size(864, 389)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageEmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageAdminsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaceRecognitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartFaceRecognitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrainFaceRecognitionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToPDFToolStripMenuItem As ToolStripMenuItem
End Class
