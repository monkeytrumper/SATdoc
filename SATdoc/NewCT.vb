Public Class NewCT

    Public Shared Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveExit.Click
        Dim ctType As String = NewCT.cmbCTtype.Text
        Dim ctManu As String = NewCT.tbCTManu.Text
        Dim ctL1Sn As String = NewCT.tbCTSn1.Text
        Dim ctL2Sn As String = NewCT.tbCTSn2.Text
        Dim ctL3Sn As String = NewCT.tbCTSn3.Text
        Dim NoOfCores As Integer = 1
        NewCT.Close()
        PanOverview.Show()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        PanOverview.Show()
        'index the number of CTs 
        PanOverview.NoOfCTs = PanOverview.NoOfCTs - 1

        Me.Close()
    End Sub

    Public Shared Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CTcore.Show()
        Dim CT1Cores As Integer = NewCT.tbCT1NoOfCores.Text
        NewCT.Hide()
    End Sub

    Private Sub cmbCTtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCTtype.SelectedIndexChanged
        If cmbCTtype.Text = "Core Balance" Then
            lblL1.Visible = False
            lblL2.Visible = False
            lblL3.Visible = False
            tbCTSn2.Visible = False
            tbCTSn3.Visible = False
        Else
            lblL1.Visible = True
            lblL2.Visible = True
            lblL3.Visible = True
            tbCTSn2.Visible = True
            tbCTSn3.Visible = True
        End If
    End Sub

End Class