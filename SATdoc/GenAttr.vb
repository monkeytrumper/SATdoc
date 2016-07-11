Imports System
Imports System.IO
Imports Word = Microsoft.Office.Interop.Word

Public Class GenAttr
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrontPage.Show()
        Me.Hide()
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConfigure.Click
        Dim PrjName As String = tbPrjNm.Text

        Dim RefNo As String = tbRefNo.Text
        Dim Customer As String = tbCust.Text
        fullPanType = cbPanType.Text
        Dim projFolder As String = projDirectory & "\" & PrjName & "\"
        Dim panVoltage As String = cmbVoltage.Text
        Dim subName As String = tbsubName.Text
        Dim objDoc As Word.Document
        Dim objWordApp As New Word.Application

        If Not Directory.Exists(projFolder) Then
            CopyDirectory(templDirectory, projFolder)
            If Directory.Exists(projFolder) Then
                PanOverview.Show()
                Me.Hide()
            End If

            If cmbVoltage.Text IsNot Nothing Then

                If panVoltage = "3.3KV" Then
                    File.Copy(blkShtDirectory & "\" & "Flash 10kV 1.0.doc", projFolder & "SAT\2 HV Tests\Flash.doc")
                ElseIf panVoltage = "11KV" Then
                    File.Copy(blkShtDirectory & "\" & "Flash 25kV 1.0.doc", projFolder & "SAT\2 HV Tests\Flash.doc")
                ElseIf panVoltage = "33KV" Then
                    File.Copy(blkShtDirectory & "\" & "Flash 55kV 1.0.doc", projFolder & "SAT\2 HV Tests\Flash.doc")
                End If

                'Open flash document.  

                objDoc = objWordApp.Documents.Open(projFolder & "SAT\2 HV Tests\Flash.doc")
                'update flash document header perameters
                objDoc.Variables("replPrjNo").Value = RefNo
                objDoc.Variables("replCust").Value = Customer
                objDoc.Variables("replStat").Value = subName
                objDoc.Variables("replPan").Value = "All Panels"
                objDoc.Variables("replCustRef").Value = "All Panels"
                'update fields
                objDoc.Fields.Update()
                objDoc.StoryRanges(Word.WdStoryType.wdPrimaryHeaderStory).Fields.Update()
                'save and exit
                objDoc.Save()
                objDoc.Close()
                'clear objects
                objDoc = Nothing

            End If
            'copy ductor sheet to HV test dorectory
            File.Copy(blkShtDirectory & "\" & "Ductor 1.0.doc", projFolder & "SAT\2 HV Tests\Ductor.doc")
            'populate header fields

            objDoc = objWordApp.Documents.Open(projFolder & "SAT\2 HV Tests\Ductor.doc")
            objDoc.Variables("replPrjNo").Value = RefNo
            objDoc.Variables("replCust").Value = Customer
            objDoc.Variables("replStat").Value = subName
            objDoc.Variables("replPan").Value = "All Panels"
            objDoc.Variables("replCustRef").Value = "All Panels"
            'update all the fields in the document
            objDoc.Fields.Update()
            objDoc.StoryRanges(Word.WdStoryType.wdPrimaryHeaderStory).Fields.Update()
            'save and quit
            objDoc.Save()
            objDoc.Close()
            'clear objects
            objDoc = Nothing
            objWordApp.Quit()
            objWordApp = Nothing


        Else
                Dim result As Integer = MsgBox("Project Directory already exists, open it for editing?",
                                                       MessageBoxButtons.YesNo, "Directory Exists")
                If result = MsgBoxResult.Yes Then
                    Process.Start("explorer.exe", projFolder)
                End If
            End If



    End Sub

    Public Sub CopyDirectory(ByVal sourcePath As String, ByVal destinationPath As String)
        Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(sourcePath)

        ' If the destination folder don't exist then create it
        If Not System.IO.Directory.Exists(destinationPath) Then
            System.IO.Directory.CreateDirectory(destinationPath)


            Dim fileSystemInfo As System.IO.FileSystemInfo
            For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
                Dim destinationFileName As String =
                    System.IO.Path.Combine(destinationPath, fileSystemInfo.Name)

                ' check whether its a file or a folder and take action accordingly
                If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                    System.IO.File.Copy(fileSystemInfo.FullName, destinationFileName, True)
                Else
                    ' Recursively call the method to copy all the nested folders
                    CopyDirectory(fileSystemInfo.FullName, destinationFileName)

                End If
            Next
        Else
            MsgBox("Folder already exists")
        End If
    End Sub

End Class