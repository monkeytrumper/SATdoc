<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCT
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
        Me.cmbCTtype = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblL3 = New System.Windows.Forms.Label()
        Me.lblL2 = New System.Windows.Forms.Label()
        Me.lblL1 = New System.Windows.Forms.Label()
        Me.tbCTSn1 = New System.Windows.Forms.TextBox()
        Me.tbCTSn2 = New System.Windows.Forms.TextBox()
        Me.tbCTSn3 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbCT1NoOfCores = New System.Windows.Forms.TextBox()
        Me.tbCTManu = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSaveExit = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New CT"
        '
        'cmbCTtype
        '
        Me.cmbCTtype.FormattingEnabled = True
        Me.cmbCTtype.Items.AddRange(New Object() {"Core Balance", "TPU 3 ph", "Ring 3 ph"})
        Me.cmbCTtype.Location = New System.Drawing.Point(100, 47)
        Me.cmbCTtype.Name = "cmbCTtype"
        Me.cmbCTtype.Size = New System.Drawing.Size(121, 21)
        Me.cmbCTtype.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type of CT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Serial No"
        '
        'lblL3
        '
        Me.lblL3.AutoSize = True
        Me.lblL3.Location = New System.Drawing.Point(418, 76)
        Me.lblL3.Name = "lblL3"
        Me.lblL3.Size = New System.Drawing.Size(19, 13)
        Me.lblL3.TabIndex = 4
        Me.lblL3.Text = "L3"
        '
        'lblL2
        '
        Me.lblL2.AutoSize = True
        Me.lblL2.Location = New System.Drawing.Point(273, 76)
        Me.lblL2.Name = "lblL2"
        Me.lblL2.Size = New System.Drawing.Size(19, 13)
        Me.lblL2.TabIndex = 5
        Me.lblL2.Text = "L2"
        '
        'lblL1
        '
        Me.lblL1.AutoSize = True
        Me.lblL1.Location = New System.Drawing.Point(130, 76)
        Me.lblL1.Name = "lblL1"
        Me.lblL1.Size = New System.Drawing.Size(19, 13)
        Me.lblL1.TabIndex = 6
        Me.lblL1.Text = "L1"
        '
        'tbCTSn1
        '
        Me.tbCTSn1.Location = New System.Drawing.Point(98, 93)
        Me.tbCTSn1.Name = "tbCTSn1"
        Me.tbCTSn1.Size = New System.Drawing.Size(100, 20)
        Me.tbCTSn1.TabIndex = 7
        '
        'tbCTSn2
        '
        Me.tbCTSn2.Location = New System.Drawing.Point(236, 92)
        Me.tbCTSn2.Name = "tbCTSn2"
        Me.tbCTSn2.Size = New System.Drawing.Size(100, 20)
        Me.tbCTSn2.TabIndex = 8
        '
        'tbCTSn3
        '
        Me.tbCTSn3.Location = New System.Drawing.Point(382, 92)
        Me.tbCTSn3.Name = "tbCTSn3"
        Me.tbCTSn3.Size = New System.Drawing.Size(100, 20)
        Me.tbCTSn3.TabIndex = 9
        '
        'tbCT1NoOfCores
        '
        Me.tbCT1NoOfCores.Location = New System.Drawing.Point(98, 125)
        Me.tbCT1NoOfCores.Name = "tbCT1NoOfCores"
        Me.tbCT1NoOfCores.Size = New System.Drawing.Size(38, 20)
        Me.tbCT1NoOfCores.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.tbCT1NoOfCores, "Primary")
        '
        'tbCTManu
        '
        Me.tbCTManu.Location = New System.Drawing.Point(382, 47)
        Me.tbCTManu.Name = "tbCTManu"
        Me.tbCTManu.Size = New System.Drawing.Size(100, 20)
        Me.tbCTManu.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(294, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Manufacturer"
        '
        'btnSaveExit
        '
        Me.btnSaveExit.Location = New System.Drawing.Point(379, 183)
        Me.btnSaveExit.Name = "btnSaveExit"
        Me.btnSaveExit.Size = New System.Drawing.Size(105, 24)
        Me.btnSaveExit.TabIndex = 22
        Me.btnSaveExit.Text = "Save and exit"
        Me.btnSaveExit.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(71, 184)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(105, 23)
        Me.BtnCancel.TabIndex = 23
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "No Of Cores"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Configure CT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 244)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbCT1NoOfCores)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnSaveExit)
        Me.Controls.Add(Me.tbCTManu)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbCTSn3)
        Me.Controls.Add(Me.tbCTSn2)
        Me.Controls.Add(Me.tbCTSn1)
        Me.Controls.Add(Me.lblL1)
        Me.Controls.Add(Me.lblL2)
        Me.Controls.Add(Me.lblL3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCTtype)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "New CT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCTtype As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblL3 As Label
    Friend WithEvents lblL2 As Label
    Friend WithEvents lblL1 As Label
    Friend WithEvents tbCTSn1 As TextBox
    Friend WithEvents tbCTSn2 As TextBox
    Friend WithEvents tbCTSn3 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tbCTManu As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSaveExit As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents tbCT1NoOfCores As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
End Class
