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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.accNumber = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.amtWithdrawl = New System.Windows.Forms.TextBox()
        Me.amtDeposit = New System.Windows.Forms.TextBox()
        Me.district = New System.Windows.Forms.TextBox()
        Me.amtPending = New System.Windows.Forms.TextBox()
        Me.insertButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.dateofdeposit = New System.Windows.Forms.DateTimePicker()
        Me.dateofWithdrawal = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SearchInput = New System.Windows.Forms.TextBox()
        Me.RDatabaseDataSet = New Records.RDatabaseDataSet()
        Me.RDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SortByAccount = New System.Windows.Forms.Button()
        Me.SortByName = New System.Windows.Forms.Button()
        Me.SortByDate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Father's Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Amount Withdrawal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount Deposited"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date Of Deposit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "District"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Amount Pending"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Date of Amount Withdrawal"
        '
        'accNumber
        '
        Me.accNumber.Location = New System.Drawing.Point(235, 13)
        Me.accNumber.Name = "accNumber"
        Me.accNumber.Size = New System.Drawing.Size(113, 20)
        Me.accNumber.TabIndex = 10
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(235, 111)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(113, 39)
        Me.address.TabIndex = 11
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(235, 85)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(113, 20)
        Me.fname.TabIndex = 12
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(236, 48)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(112, 20)
        Me.uname.TabIndex = 13
        '
        'amtWithdrawl
        '
        Me.amtWithdrawl.Location = New System.Drawing.Point(236, 224)
        Me.amtWithdrawl.Name = "amtWithdrawl"
        Me.amtWithdrawl.Size = New System.Drawing.Size(112, 20)
        Me.amtWithdrawl.TabIndex = 15
        '
        'amtDeposit
        '
        Me.amtDeposit.Location = New System.Drawing.Point(235, 194)
        Me.amtDeposit.Name = "amtDeposit"
        Me.amtDeposit.Size = New System.Drawing.Size(113, 20)
        Me.amtDeposit.TabIndex = 16
        '
        'district
        '
        Me.district.Location = New System.Drawing.Point(235, 328)
        Me.district.Name = "district"
        Me.district.Size = New System.Drawing.Size(112, 20)
        Me.district.TabIndex = 18
        '
        'amtPending
        '
        Me.amtPending.Location = New System.Drawing.Point(236, 290)
        Me.amtPending.Name = "amtPending"
        Me.amtPending.Size = New System.Drawing.Size(112, 20)
        Me.amtPending.TabIndex = 19
        '
        'insertButton
        '
        Me.insertButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.insertButton.Location = New System.Drawing.Point(22, 378)
        Me.insertButton.Name = "insertButton"
        Me.insertButton.Size = New System.Drawing.Size(75, 23)
        Me.insertButton.TabIndex = 20
        Me.insertButton.Text = "Insert"
        Me.insertButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SearchButton.Location = New System.Drawing.Point(864, 378)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 21
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.UpdateButton.Location = New System.Drawing.Point(236, 378)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(111, 23)
        Me.UpdateButton.TabIndex = 22
        Me.UpdateButton.Text = "Address Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DeleteButton.Location = New System.Drawing.Point(129, 378)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 23
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'dateofdeposit
        '
        Me.dateofdeposit.Location = New System.Drawing.Point(235, 161)
        Me.dateofdeposit.Name = "dateofdeposit"
        Me.dateofdeposit.Size = New System.Drawing.Size(113, 20)
        Me.dateofdeposit.TabIndex = 24
        '
        'dateofWithdrawal
        '
        Me.dateofWithdrawal.Location = New System.Drawing.Point(236, 256)
        Me.dateofWithdrawal.Name = "dateofWithdrawal"
        Me.dateofWithdrawal.Size = New System.Drawing.Size(113, 20)
        Me.dateofWithdrawal.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(410, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(539, 335)
        Me.DataGridView1.TabIndex = 26
        '
        'SearchInput
        '
        Me.SearchInput.Location = New System.Drawing.Point(728, 380)
        Me.SearchInput.Name = "SearchInput"
        Me.SearchInput.Size = New System.Drawing.Size(130, 20)
        Me.SearchInput.TabIndex = 27
        '
        'RDatabaseDataSet
        '
        Me.RDatabaseDataSet.DataSetName = "RDatabaseDataSet"
        Me.RDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RDatabaseDataSetBindingSource
        '
        Me.RDatabaseDataSetBindingSource.DataSource = Me.RDatabaseDataSet
        Me.RDatabaseDataSetBindingSource.Position = 0
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClearButton.Location = New System.Drawing.Point(22, 408)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(325, 23)
        Me.ClearButton.TabIndex = 28
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SortByAccount
        '
        Me.SortByAccount.Location = New System.Drawing.Point(410, 408)
        Me.SortByAccount.Name = "SortByAccount"
        Me.SortByAccount.Size = New System.Drawing.Size(130, 23)
        Me.SortByAccount.TabIndex = 29
        Me.SortByAccount.Text = "Sort By Account No"
        Me.SortByAccount.UseVisualStyleBackColor = True
        '
        'SortByName
        '
        Me.SortByName.Location = New System.Drawing.Point(546, 408)
        Me.SortByName.Name = "SortByName"
        Me.SortByName.Size = New System.Drawing.Size(130, 23)
        Me.SortByName.TabIndex = 30
        Me.SortByName.Text = "Sort By Name"
        Me.SortByName.UseVisualStyleBackColor = True
        '
        'SortByDate
        '
        Me.SortByDate.Location = New System.Drawing.Point(682, 408)
        Me.SortByDate.Name = "SortByDate"
        Me.SortByDate.Size = New System.Drawing.Size(130, 23)
        Me.SortByDate.TabIndex = 31
        Me.SortByDate.Text = "Sort By Date"
        Me.SortByDate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 506)
        Me.Controls.Add(Me.SortByDate)
        Me.Controls.Add(Me.SortByName)
        Me.Controls.Add(Me.SortByAccount)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SearchInput)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dateofWithdrawal)
        Me.Controls.Add(Me.dateofdeposit)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.insertButton)
        Me.Controls.Add(Me.amtPending)
        Me.Controls.Add(Me.district)
        Me.Controls.Add(Me.amtDeposit)
        Me.Controls.Add(Me.amtWithdrawl)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.accNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "DataInput"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents accNumber As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents uname As TextBox
    Friend WithEvents amtWithdrawl As TextBox
    Friend WithEvents amtDeposit As TextBox
    Friend WithEvents district As TextBox
    Friend WithEvents amtPending As TextBox
    Friend WithEvents insertButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents dateofdeposit As DateTimePicker
    Friend WithEvents dateofWithdrawal As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RDatabaseDataSetBindingSource As BindingSource
    Friend WithEvents RDatabaseDataSet As RDatabaseDataSet
    Friend WithEvents SearchInput As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents SortByAccount As Button
    Friend WithEvents SortByName As Button
    Friend WithEvents SortByDate As Button
End Class
