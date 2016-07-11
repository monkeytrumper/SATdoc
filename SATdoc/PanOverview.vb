Public Class PanOverview

    Public Shared NoOfCTs As Integer = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If fullPanType = "Mixed" Then
            cbPanType.Visible = True
            lblPanType.Visible = True
        Else
            cbPanType.Visible = False
            lblPanType.Visible = False
        End If
        Dim Pan1Name As String = "A01"
        Dim pan1Des As String = "Feeder"
        Dim BBE As Boolean = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GenAttr.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrontPage.Close()

    End Sub

    Private Sub tbPanName_TextChanged(sender As Object, e As EventArgs) Handles tbPanName.TextChanged
        lblPanName.Text = tbPanName.Text
    End Sub

    Private Sub tbPanDes_TextChanged(sender As Object, e As EventArgs) Handles tbPanDes.TextChanged
        lblDesig.Text = tbPanDes.Text
    End Sub

    Private Sub btnAddCT_Click(sender As Object, e As EventArgs) Handles btnAddCT.Click
        Dim ctTestProc As MsgBoxResult = MsgBox("Are you using the CT analyser?", MsgBoxStyle.YesNo)
        'index the number of CTs
        NoOfCTs = NoOfCTs + 1
        NewCT.Show()
        Me.Hide()

    End Sub


End Class
