Imports System
Imports System.Windows.Forms
Imports CrystalDecisions.Windows.Forms
Public Class _60_MaiVanTu_Form4

    Private Sub _60_MaiVanTu_Form4_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1End.SanPham' table. You can move, or remove it, as needed.
        Me.SanPhamTableAdapter.Fill(Me.DataSet1End.SanPham)






        Me.ReportViewer1.RefreshReport
    End Sub
End Class