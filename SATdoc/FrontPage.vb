Imports System.Configuration

Public Class FrontPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GenAttr.Show()
        Me.Hide()

    End Sub

    Private Sub SetResourcesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetResourcesToolStripMenuItem.Click

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            templDirectory = FolderBrowserDialog1.SelectedPath
            My.Settings.TmplFold = templDirectory
            Label4.Text = My.Settings.TmplFold
            My.Settings.Save()

        End If
    End Sub

    Private Sub SetProjectFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetProjectFolderToolStripMenuItem.Click

        If (FolderBrowserDialog2.ShowDialog() = DialogResult.OK) Then
            projDirectory = FolderBrowserDialog2.SelectedPath
            My.Settings.projectFold = projDirectory
            My.Settings.Save()
            Label3.Text = My.Settings.projectFold
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        templDirectory = My.Settings.TmplFold
        Label4.Text = templDirectory
        projDirectory = My.Settings.projectFold
        Label3.Text = projDirectory
        blkShtDirectory = My.Settings.BlankSATfold
        lblBlkDoc.Text = blkShtDirectory


    End Sub

    Private Sub SetBlankTestDocumentFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetBlankTestDocumentFolderToolStripMenuItem.Click

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            blkShtDirectory = FolderBrowserDialog1.SelectedPath
            My.Settings.BlankSATfold = blkShtDirectory
            lblBlkDoc.Text = My.Settings.BlankSATfold
            My.Settings.Save()
        End If
    End Sub
End Class