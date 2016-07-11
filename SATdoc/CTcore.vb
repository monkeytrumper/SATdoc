Imports Microsoft.Office.Interop.Word
Imports System.IO
Imports System

Public Class CTcore
    Public Shared Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CTcore.tbCT1C1Rat1.Visible = True
        CTcore.tbCT1C1Rat2.Visible = False
        CTcore.tbCT1C1Rat3.Visible = False
        CTcore.tbCT1C1Rat4.Visible = False
        CTcore.Label10.Visible = False
        CTcore.Label2.Visible = False
        CTcore.Label3.Visible = False
        CTcore.lblFS.Visible = False
        'define vars for coreNo from form4 - - this doesnt really work yet
        Dim coreNo As Integer = NewCT.tbCT1NoOfCores.Text
        Dim coreCounter As Integer = coreNo

    End Sub

    Private Sub tbCT1C1NoOfTaps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbCT1C1NoOfTaps.SelectedIndexChanged
        If tbCT1C1NoOfTaps.Text = "0" Then
            tbCT1C1Rat1.Visible = True
            Label10.Visible = False
            tbCT1C1Rat2.Visible = False
            Label2.Visible = False
            tbCT1C1Rat3.Visible = False
            Label3.Visible = False
            tbCT1C1Rat4.Visible = False
        ElseIf tbCT1C1NoOfTaps.Text = "1" Then
            tbCT1C1Rat1.Visible = True
            Label10.Visible = True
            tbCT1C1Rat2.Visible = True
            Label2.Visible = False
            tbCT1C1Rat3.Visible = False
            Label3.Visible = False
            tbCT1C1Rat4.Visible = False
        ElseIf tbCT1C1NoOfTaps.Text = "2" Then
            tbCT1C1Rat1.Visible = True
            Label10.Visible = True
            tbCT1C1Rat2.Visible = True
            Label2.Visible = True
            tbCT1C1Rat3.Visible = True
            Label3.Visible = False
            tbCT1C1Rat4.Visible = False
        ElseIf tbCT1C1NoOfTaps.Text = "3" Then
            tbCT1C1Rat1.Visible = True
            Label10.Visible = True
            tbCT1C1Rat2.Visible = True
            Label2.Visible = True
            tbCT1C1Rat3.Visible = True
            Label3.Visible = True
            tbCT1C1Rat4.Visible = True
        End If
    End Sub

    Public Shared Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNextCore.Click


        Dim CtClass As String = CTcore.cmbCT1C1Class.Text
        Dim ctRatBurd As String = CTcore.tbCT1C1Burden.Text
        Dim ctC1PM As String = CTcore.cmbCT1C1PM.Text
        Dim ct1ALF As String = CTcore.tbCT1ALF.Text
        Dim CtS1Prim As String = CTcore.tbCT1C1Rat1.Text
        Dim CtS2Prim As String = CTcore.tbCT1C1Rat2.Text
        Dim CtS3Prim As String = CTcore.tbCT1C1Rat3.Text
        Dim CtS4Prim As String = CTcore.tbCT1C1Rat4.Text
        Dim ct1Sec As String = CTcore.tbCT1C1Rat5.Text




    End Sub

    Private Sub cmbCT1C1PM_SelectedvalueChanged(sender As Object, e As EventArgs) Handles cmbCT1C1PM.SelectedValueChanged
        cmbCT1C1Class.Items.Clear()
        For Each ctClass As String In classes(cmbCT1C1PM.Text)
            cmbCT1C1Class.Items.Add(ctClass)
        Next
        If cmbCT1C1PM.Text = "Protection" Then
            lblALF.Visible = True
            lblFS.Visible = False
            tbCT1ALF.Visible = True
            tbCT1FS.Visible = False
        ElseIf cmbCT1C1PM.Text = "Metering" Then
            lblALF.Visible = False
            lblFS.Visible = True
            tbCT1ALF.Visible = False
            tbCT1FS.Visible = True
        End If

    End Sub

    Private classes As New Dictionary(Of String, List(Of String))() From {
    {"Protection", New List(Of String)() From {"5P", "10P", "Px"}},
    {"Metering", New List(Of String)() From {"0.2", "0.2s", "0.5", "0.5s"}}
}

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        NewCT.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        NewCT.Show()
        Me.Hide()
    End Sub
End Class