Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'đưa sản phẩm vào datagrid: 
        DsCapNhatSanPhamDienThoai1.Clear()
        OleDbDataAdapter1.Fill(DsCapNhatSanPhamDienThoai1)
        ' đưa vào combobox madmsp:



    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        lbMaSanPham.Text = "Mã sản phẩm tự động tăng"
        If MsgBox("Bạn có muốn thêm sản phẩm này không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lưu") = MsgBoxResult.Yes Then
            'kiểm tra text file rỗng.
            If txtTenSanPham.Text = "" Or txtThuongHieu.Text = "" Or txtDonGia.Text = "" Or txtSoLuong.Text = "" Or cboMaDMSP.Text = "" Then
                MsgBox("Vui lòng nhập đầy đủ dữ liệu!")
            Else
                Try
                    OleDbConnection1.Open()
                    Dim sql As String = "INSERT INTO [SanPham] ([TenSP], [MaDMSP], [ThuongHieu], [Gia], [SoLuong]) VALUES ('" & txtTenSanPham.Text & "', '" & cboMaDMSP.Text & "', '" & txtThuongHieu.Text & "', '" & txtDonGia.Text & "', '" & txtSoLuong.Text & "')"
                    OleDbInsertCommand1.CommandText = sql
                    OleDbInsertCommand1.ExecuteNonQuery()
                    OleDbConnection1.Close()
                    '' load data()
                    'đưa sản phẩm vào datagrid: 
                    DsCapNhatSanPhamDienThoai1.Clear()
                    OleDbDataAdapter1.Fill(DsCapNhatSanPhamDienThoai1)
                    ' đưa vào combobox madmsp:
                    MsgBox("Thêm dữ liệu thành công!", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly, "Thông báo")
                Catch ex As Exception
                    MsgBox("Lỗi thêm dữ liệu!, Vui lòng kiểm tra lại!")
                End Try
            End If
        End If
    End Sub

    Private Sub OleDbDataAdapter1_RowUpdated(sender As Object, e As OleDb.OleDbRowUpdatedEventArgs) Handles OleDbDataAdapter1.RowUpdated

    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        If MsgBox("Bạn có muốn sửa sản phẩm này không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sửa") = MsgBoxResult.Yes Then
            'kiểm tra text file rỗng.
            If txtTenSanPham.Text = "" Or txtThuongHieu.Text = "" Or txtDonGia.Text = "" Or txtSoLuong.Text = "" Or cboMaDMSP.Text = "" Then
                MsgBox("Vui lòng nhập đầy đủ dữ liệu!")
            Else
                Try
                    OleDbConnection1.Open()
                    Dim sql As String = "UPDATE [SanPham] SET [TenSP] = '" + txtTenSanPham.Text + "', [MaDMSP] = '" + cboMaDMSP.Text + "', [ThuongHieu] = '" + txtThuongHieu.Text + "', [Gia] = '" + txtDonGia.Text + "', [SoLuong] = '" + txtSoLuong.Text + "' WHERE [MaSP] = '" + Trim(lbMaSanPham.Text) + "'"
                    OleDbInsertCommand1.CommandText = sql
                    OleDbInsertCommand1.ExecuteNonQuery()
                    OleDbConnection1.Close()
                    '' load data()
                    'đưa sản phẩm vào datagrid: 
                    DsCapNhatSanPhamDienThoai1.Clear()
                    OleDbDataAdapter1.Fill(DsCapNhatSanPhamDienThoai1)
                    ' đưa vào combobox madmsp:
                    MsgBox("Sửa dữ liệu thành công!", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly, "Thông báo")
                Catch ex As Exception
                    MsgBox("Lỗi sửa dữ liệu!, Vui lòng kiểm tra lại!")
                End Try
            End If
        End If

    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        If MsgBox("Bạn có muốn xóa sản phẩm này không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Xóa") = MsgBoxResult.Yes Then
            Try
                OleDbConnection1.Open()
                Dim sql As String = "DELETE  from [SanPham] Where [MaSP] ='" & lbMaSanPham.Text & "'"
                OleDbInsertCommand1.CommandText = sql
                OleDbInsertCommand1.ExecuteNonQuery()
                '' load data()
                'đưa sản phẩm vào datagrid: 
                DsCapNhatSanPhamDienThoai1.Clear()
                OleDbDataAdapter1.Fill(DsCapNhatSanPhamDienThoai1)
                OleDbConnection1.Close()
                ' đưa vào combobox madmsp:
                MsgBox("Xóa dữ liệu thành công!", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly, "Thông báo")
            Catch ex As Exception
                MsgBox("Xóa dữ liệu không thành công!", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly, "Thông báo")
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'khi chọn vào hàng của bảng, sẽ hiển thị dữ liệu hàng đó lên trên các textbox. 
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        lbMaSanPham.Text = DataGridView1.Item(0, i).Value
        txtTenSanPham.Text = DataGridView1.Item(1, i).Value
        cboMaDMSP.Text = DataGridView1.Item(2, i).Value
        txtThuongHieu.Text = DataGridView1.Item(3, i).Value
        txtDonGia.Text = DataGridView1.Item(4, i).Value
        txtSoLuong.Text = DataGridView1.Item(5, i).Value
    End Sub
End Class