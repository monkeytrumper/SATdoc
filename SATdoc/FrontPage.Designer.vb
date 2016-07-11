<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetProjectFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblPrjFolder = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SetBlankTestDocumentFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBlkDoc = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the Awesome SAT manager!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "What would you like to do?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 59)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "New Project"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(737, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetResourcesToolStripMenuItem, Me.SetProjectFolderToolStripMenuItem, Me.SetBlankTestDocumentFolderToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripMenuItem1.Text = "Setup"
        '
        'SetResourcesToolStripMenuItem
        '
        Me.SetResourcesToolStripMenuItem.Name = "SetResourcesToolStripMenuItem"
        Me.SetResourcesToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.SetResourcesToolStripMenuItem.Text = "Set directory structure template folder"
        '
        'SetProjectFolderToolStripMenuItem
        '
        Me.SetProjectFolderToolStripMenuItem.Name = "SetProjectFolderToolStripMenuItem"
        Me.SetProjectFolderToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.SetProjectFolderToolStripMenuItem.Text = "Set project folder"
        '
        'lblPrjFolder
        '
        Me.lblPrjFolder.AutoSize = True
        Me.lblPrjFolder.Location = New System.Drawing.Point(42, 315)
        Me.lblPrjFolder.Name = "lblPrjFolder"
        Me.lblPrjFolder.Size = New System.Drawing.Size(120, 13)
        Me.lblPrjFolder.TabIndex = 6
        Me.lblPrjFolder.Text = "Projects will be saved in"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Not yet configured"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Not yet configured"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Blank test documents taken from"
        '
        'SetBlankTestDocumentFolderToolStripMenuItem
        '
        Me.SetBlankTestDocumentFolderToolStripMenuItem.Name = "SetBlankTestDocumentFolderToolStripMenuItem"
        Me.SetBlankTestDocumentFolderToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.SetBlankTestDocumentFolderToolStripMenuItem.Text = "Set Blank test document folder"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Directory structure template"
        '
        'lblBlkDoc
        '
        Me.lblBlkDoc.AutoSize = True
        Me.lblBlkDoc.Location = New System.Drawing.Point(398, 284)
        Me.lblBlkDoc.Name = "lblBlkDoc"
        Me.lblBlkDoc.Size = New System.Drawing.Size(94, 13)
        Me.lblBlkDoc.TabIndex = 11
        Me.lblBlkDoc.Text = "Not yet configured"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 376)
        Me.Controls.Add(Me.lblBlkDoc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPrjFolder)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SetResourcesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents SetProjectFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPrjFolder As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SetBlankTestDocumentFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBlkDoc As Label
End Class
