Imports System.Data
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.cboMaDMSP = New System.Windows.Forms.ComboBox()
        Me.SanPhamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCapNhatSanPhamDienThoai1 = New cuoikyvbmaivantu2.DsCapNhatSanPhamDienThoai()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaDMSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThuongHieuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsCapNhatSanPhamDienThoai1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtThuongHieu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbMaSanPham = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.txtTenSanPham = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        CType(Me.SanPhamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCapNhatSanPhamDienThoai1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCapNhatSanPhamDienThoai1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMaDMSP
        '
        Me.cboMaDMSP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SanPhamBindingSource, "MaDMSP", True))
        Me.cboMaDMSP.FormattingEnabled = True
        Me.cboMaDMSP.Location = New System.Drawing.Point(479, 54)
        Me.cboMaDMSP.Name = "cboMaDMSP"
        Me.cboMaDMSP.Size = New System.Drawing.Size(179, 21)
        Me.cboMaDMSP.TabIndex = 69
        '
        'SanPhamBindingSource
        '
        Me.SanPhamBindingSource.DataMember = "SanPham"
        Me.SanPhamBindingSource.DataSource = Me.DsCapNhatSanPhamDienThoai1
        '
        'DsCapNhatSanPhamDienThoai1
        '
        Me.DsCapNhatSanPhamDienThoai1.DataSetName = "DsCapNhatSanPhamDienThoai"
        Me.DsCapNhatSanPhamDienThoai1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSPDataGridViewTextBoxColumn, Me.TenSPDataGridViewTextBoxColumn, Me.MaDMSPDataGridViewTextBoxColumn, Me.ThuongHieuDataGridViewTextBoxColumn, Me.GiaDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "SanPham"
        Me.DataGridView1.DataSource = Me.DsCapNhatSanPhamDienThoai1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(28, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(641, 199)
        Me.DataGridView1.TabIndex = 68
        '
        'MaSPDataGridViewTextBoxColumn
        '
        Me.MaSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP"
        Me.MaSPDataGridViewTextBoxColumn.HeaderText = "MaSP"
        Me.MaSPDataGridViewTextBoxColumn.Name = "MaSPDataGridViewTextBoxColumn"
        Me.MaSPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TenSPDataGridViewTextBoxColumn
        '
        Me.TenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP"
        Me.TenSPDataGridViewTextBoxColumn.HeaderText = "TenSP"
        Me.TenSPDataGridViewTextBoxColumn.Name = "TenSPDataGridViewTextBoxColumn"
        '
        'MaDMSPDataGridViewTextBoxColumn
        '
        Me.MaDMSPDataGridViewTextBoxColumn.DataPropertyName = "MaDMSP"
        Me.MaDMSPDataGridViewTextBoxColumn.HeaderText = "MaDMSP"
        Me.MaDMSPDataGridViewTextBoxColumn.Name = "MaDMSPDataGridViewTextBoxColumn"
        '
        'ThuongHieuDataGridViewTextBoxColumn
        '
        Me.ThuongHieuDataGridViewTextBoxColumn.DataPropertyName = "ThuongHieu"
        Me.ThuongHieuDataGridViewTextBoxColumn.HeaderText = "ThuongHieu"
        Me.ThuongHieuDataGridViewTextBoxColumn.Name = "ThuongHieuDataGridViewTextBoxColumn"
        '
        'GiaDataGridViewTextBoxColumn
        '
        Me.GiaDataGridViewTextBoxColumn.DataPropertyName = "Gia"
        Me.GiaDataGridViewTextBoxColumn.HeaderText = "Gia"
        Me.GiaDataGridViewTextBoxColumn.Name = "GiaDataGridViewTextBoxColumn"
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        '
        'DsCapNhatSanPhamDienThoai1BindingSource
        '
        Me.DsCapNhatSanPhamDienThoai1BindingSource.DataSource = Me.DsCapNhatSanPhamDienThoai1
        Me.DsCapNhatSanPhamDienThoai1BindingSource.Position = 0
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(519, 145)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 59
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(116, 145)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 55
        Me.btnThem.Text = "Thêm "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(382, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Số Lượng"
        '
        'txtDonGia
        '
        Me.txtDonGia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SanPhamBindingSource, "Gia", True))
        Me.txtDonGia.Location = New System.Drawing.Point(479, 94)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(179, 20)
        Me.txtDonGia.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(382, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Mã Danh Mục"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Đơn Giá"
        '
        'txtThuongHieu
        '
        Me.txtThuongHieu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SanPhamBindingSource, "ThuongHieu", True))
        Me.txtThuongHieu.Location = New System.Drawing.Point(162, 94)
        Me.txtThuongHieu.Name = "txtThuongHieu"
        Me.txtThuongHieu.Size = New System.Drawing.Size(179, 20)
        Me.txtThuongHieu.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Thương hiệu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(658, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CẬP NHẬT SẢN PHẨM ĐIỆN THOẠI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbMaSanPham)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btXoa)
        Me.GroupBox1.Controls.Add(Me.btSua)
        Me.GroupBox1.Controls.Add(Me.txtTenSanPham)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSoLuong)
        Me.GroupBox1.Controls.Add(Me.cboMaDMSP)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.btnThem)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDonGia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtThuongHieu)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(195, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 414)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sản Phẩm"
        '
        'lbMaSanPham
        '
        Me.lbMaSanPham.AutoSize = True
        Me.lbMaSanPham.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SanPhamBindingSource, "MaSP", True))
        Me.lbMaSanPham.Location = New System.Drawing.Point(209, 25)
        Me.lbMaSanPham.Name = "lbMaSanPham"
        Me.lbMaSanPham.Size = New System.Drawing.Size(74, 13)
        Me.lbMaSanPham.TabIndex = 77
        Me.lbMaSanPham.Text = "Mã Sản Phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Mã Sản Phẩm"
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(377, 145)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 74
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Location = New System.Drawing.Point(251, 145)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(75, 23)
        Me.btSua.TabIndex = 73
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'txtTenSanPham
        '
        Me.txtTenSanPham.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SanPhamBindingSource, "TenSP", True))
        Me.txtTenSanPham.Location = New System.Drawing.Point(162, 61)
        Me.txtTenSanPham.Name = "txtTenSanPham"
        Me.txtTenSanPham.Size = New System.Drawing.Size(179, 20)
        Me.txtTenSanPham.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Tên Sản Phẩm"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SanPhamBindingSource, "SoLuong", True))
        Me.txtSoLuong.Location = New System.Drawing.Point(479, 19)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(179, 20)
        Me.txtSoLuong.TabIndex = 70
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        SanPham.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            SanPham"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-D617688\SQLEXPRESS;Persist Security Info=T" &
    "rue;Password=123;User ID=sa;Initial Catalog=QuanLyNhapXuatKhoHangVBDOTNET"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [SanPham] ([TenSP], [MaDMSP], [ThuongHieu], [Gia], [SoLuong]) VALUES " &
    "(?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("TenSP", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSP"), New System.Data.OleDb.OleDbParameter("MaDMSP", System.Data.OleDb.OleDbType.[Integer], 0, "MaDMSP"), New System.Data.OleDb.OleDbParameter("ThuongHieu", System.Data.OleDb.OleDbType.VarChar, 0, "ThuongHieu"), New System.Data.OleDb.OleDbParameter("Gia", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "Gia", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, "SoLuong")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("TenSP", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSP"), New System.Data.OleDb.OleDbParameter("MaDMSP", System.Data.OleDb.OleDbType.[Integer], 0, "MaDMSP"), New System.Data.OleDb.OleDbParameter("ThuongHieu", System.Data.OleDb.OleDbType.VarChar, 0, "ThuongHieu"), New System.Data.OleDb.OleDbParameter("Gia", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "Gia", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, "SoLuong"), New System.Data.OleDb.OleDbParameter("Original_MaSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TenSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TenSP", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSP", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaDMSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaDMSP", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaDMSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaDMSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ThuongHieu", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ThuongHieu", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ThuongHieu", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ThuongHieu", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Gia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gia", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Gia", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "Gia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SoLuong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoLuong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TenSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TenSP", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSP", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaDMSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaDMSP", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaDMSP", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaDMSP", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ThuongHieu", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ThuongHieu", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ThuongHieu", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ThuongHieu", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Gia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gia", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Gia", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(1, Byte), "Gia", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SoLuong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SoLuong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SoLuong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SanPham", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaSP", "MaSP"), New System.Data.Common.DataColumnMapping("TenSP", "TenSP"), New System.Data.Common.DataColumnMapping("MaDMSP", "MaDMSP"), New System.Data.Common.DataColumnMapping("ThuongHieu", "ThuongHieu"), New System.Data.Common.DataColumnMapping("Gia", "Gia"), New System.Data.Common.DataColumnMapping("SoLuong", "SoLuong")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 594)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "60-MaiVanTu-Form2"
        CType(Me.SanPhamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCapNhatSanPhamDienThoai1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCapNhatSanPhamDienThoai1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboMaDMSP As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtThuongHieu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DsCapNhatSanPhamDienThoai1BindingSource As BindingSource
    Friend WithEvents DsCapNhatSanPhamDienThoai1 As DsCapNhatSanPhamDienThoai
    Friend WithEvents MaSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaDMSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThuongHieuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtTenSanPham As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents SanPhamBindingSource As BindingSource
    Friend WithEvents btXoa As Button
    Friend WithEvents btSua As Button
    Friend WithEvents lbMaSanPham As Label
    Friend WithEvents Label3 As Label
End Class
