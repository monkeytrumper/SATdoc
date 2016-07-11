<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenAttr
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
        Me.lblPrjNm = New System.Windows.Forms.Label()
        Me.tbPrjNm = New System.Windows.Forms.TextBox()
        Me.tbRefNo = New System.Windows.Forms.TextBox()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.tbCust = New System.Windows.Forms.TextBox()
        Me.lblCust = New System.Windows.Forms.Label()
        Me.lblPanType = New System.Windows.Forms.Label()
        Me.cbPanType = New System.Windows.Forms.ComboBox()
        Me.btnConfigure = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmbVoltage = New System.Windows.Forms.ComboBox()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbsubName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrjNm
        '
        Me.lblPrjNm.AutoSize = True
        Me.lblPrjNm.Location = New System.Drawing.Point(56, 77)
        Me.lblPrjNm.Name = "lblPrjNm"
        Me.lblPrjNm.Size = New System.Drawing.Size(69, 13)
        Me.lblPrjNm.TabIndex = 0
        Me.lblPrjNm.Text = "Project name"
        '
        'tbPrjNm
        '
        Me.tbPrjNm.Location = New System.Drawing.Point(152, 74)
        Me.tbPrjNm.Name = "tbPrjNm"
        Me.tbPrjNm.Size = New System.Drawing.Size(179, 20)
        Me.tbPrjNm.TabIndex = 1
        '
        'tbRefNo
        '
        Me.tbRefNo.Location = New System.Drawing.Point(152, 100)
        Me.tbRefNo.Name = "tbRefNo"
        Me.tbRefNo.Size = New System.Drawing.Size(179, 20)
        Me.tbRefNo.TabIndex = 2
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Location = New System.Drawing.Point(56, 103)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(74, 13)
        Me.lblRefNo.TabIndex = 2
        Me.lblRefNo.Text = "Reference No"
        '
        'tbCust
        '
        Me.tbCust.Location = New System.Drawing.Point(152, 126)
        Me.tbCust.Name = "tbCust"
        Me.tbCust.Size = New System.Drawing.Size(179, 20)
        Me.tbCust.TabIndex = 3
        '
        'lblCust
        '
        Me.lblCust.AutoSize = True
        Me.lblCust.Location = New System.Drawing.Point(56, 129)
        Me.lblCust.Name = "lblCust"
        Me.lblCust.Size = New System.Drawing.Size(51, 13)
        Me.lblCust.TabIndex = 4
        Me.lblCust.Text = "Customer"
        '
        'lblPanType
        '
        Me.lblPanType.AutoSize = True
        Me.lblPanType.Location = New System.Drawing.Point(56, 155)
        Me.lblPanType.Name = "lblPanType"
        Me.lblPanType.Size = New System.Drawing.Size(72, 13)
        Me.lblPanType.TabIndex = 6
        Me.lblPanType.Text = "Type of panel"
        '
        'cbPanType
        '
        Me.cbPanType.FormattingEnabled = True
        Me.cbPanType.Items.AddRange(New Object() {"ZS1", "ZX1.2", "500R", "ZVC", "Mixed"})
        Me.cbPanType.Location = New System.Drawing.Point(152, 152)
        Me.cbPanType.Name = "cbPanType"
        Me.cbPanType.Size = New System.Drawing.Size(179, 21)
        Me.cbPanType.TabIndex = 4
        '
        'btnConfigure
        '
        Me.btnConfigure.Location = New System.Drawing.Point(482, 231)
        Me.btnConfigure.Name = "btnConfigure"
        Me.btnConfigure.Size = New System.Drawing.Size(133, 55)
        Me.btnConfigure.TabIndex = 7
        Me.btnConfigure.Text = "Configure first panel"
        Me.btnConfigure.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(201, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(275, 37)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "General Attributes"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 231)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(133, 55)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cmbVoltage
        '
        Me.cmbVoltage.FormattingEnabled = True
        Me.cmbVoltage.Items.AddRange(New Object() {"3.3KV", "11KV", "33KV"})
        Me.cmbVoltage.Location = New System.Drawing.Point(444, 74)
        Me.cmbVoltage.Name = "cmbVoltage"
        Me.cmbVoltage.Size = New System.Drawing.Size(121, 21)
        Me.cmbVoltage.TabIndex = 5
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Location = New System.Drawing.Point(395, 77)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(43, 13)
        Me.lblVoltage.TabIndex = 15
        Me.lblVoltage.Text = "Voltage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(395, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 17
        '
        'tbsubName
        '
        Me.tbsubName.Location = New System.Drawing.Point(444, 100)
        Me.tbsubName.Name = "tbsubName"
        Me.tbsubName.Size = New System.Drawing.Size(121, 20)
        Me.tbsubName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(352, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Substation name"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 298)
        Me.Controls.Add(Me.tbsubName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVoltage)
        Me.Controls.Add(Me.cmbVoltage)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnConfigure)
        Me.Controls.Add(Me.cbPanType)
        Me.Controls.Add(Me.lblPanType)
        Me.Controls.Add(Me.tbCust)
        Me.Controls.Add(Me.lblCust)
        Me.Controls.Add(Me.tbRefNo)
        Me.Controls.Add(Me.lblRefNo)
        Me.Controls.Add(Me.tbPrjNm)
        Me.Controls.Add(Me.lblPrjNm)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrjNm As Label
    Friend WithEvents tbPrjNm As TextBox
    Friend WithEvents tbRefNo As TextBox
    Friend WithEvents lblRefNo As Label
    Friend WithEvents tbCust As TextBox
    Friend WithEvents lblCust As Label
    Friend WithEvents lblPanType As Label
    Friend WithEvents cbPanType As ComboBox
    Friend WithEvents btnConfigure As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents cmbVoltage As ComboBox
    Friend WithEvents lblVoltage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbsubName As TextBox
    Friend WithEvents Label2 As Label
End Class
