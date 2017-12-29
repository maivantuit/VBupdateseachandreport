Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form3
    Dim connection As New SqlConnection("Server=DESKTOP-D617688\SQLEXPRESS;Database=QuanLyNhapXuatKhoHangVBDOTNET; Integrated Security = true")
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'đưa sản phẩm vào datagrid: 
        Dsdanhsachsanphamdetimkiem1.Clear()
        OleDbDataAdapter1.Fill(Dsdanhsachsanphamdetimkiem1)

        'đưa vào combobox madmsp:
        'LocDuLieu("")        
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim tensanpham As String = TextBox1.Text
        SanPhamBindingSource1.Filter = "TenSP='" & tensanpham & "' "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'đưa sản phẩm vào datagrid: 
        Dsdanhsachsanphamdetimkiem1.Clear()
        OleDbDataAdapter1.Fill(Dsdanhsachsanphamdetimkiem1)
        ' đưa vào combobox madmsp:
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub LocDuLieu(giatritimkiem As String)

        Dim timkiemsql As String = "select * from SanPham where CONCAT (MaSP,TenSP,MaDMSP,ThuongHieu,Gia,SoLuong) like '% " & giatritimkiem & " %'"

        Dim cm As New SqlCommand(timkiemsql, connection)
        Dim ad As New SqlDataAdapter(cm)
        Dim bang As New DataTable()
        ad.Fill(bang)
        DataGridView2.DataSource = bang
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub btnTimKiem2_Click(sender As Object, e As EventArgs)
        'LocDuLieu(txtNhapTenSanPham.Text)
    End Sub

    Private Sub txtNhapTenSanPham_TextChanged(sender As Object, e As EventArgs)
        'LocDuLieu(txtNhapTenSanPham.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tenthuonghieu As String = TextBox2.Text
        SanPhamBindingSource1.Filter = "ThuongHieu='" & tenthuonghieu & "' "
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim thuonghieucbo As String = ComboBox1.GetItemText(ComboBox1.Text)
        SanPhamBindingSource1.Filter = "ThuongHieu='" & thuonghieucbo & "' "
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New _60_MaiVanTu_Form4()
        f.TopMost = True
        f.Show()
    End Sub
End Class