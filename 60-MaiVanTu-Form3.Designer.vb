Imports System.Data
Imports System.Reflection.Emit
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MaSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaDMSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThuongHieuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SanPhamBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsdanhsachsanphamdetimkiem1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dsdanhsachsanphamdetimkiem1 = New cuoikyvbmaivantu2.dsdanhsachsanphamdetimkiem()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.SanPhamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SanPhamBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsdanhsachsanphamdetimkiem1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsdanhsachsanphamdetimkiem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SanPhamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSPDataGridViewTextBoxColumn, Me.TenSPDataGridViewTextBoxColumn, Me.MaDMSPDataGridViewTextBoxColumn, Me.ThuongHieuDataGridViewTextBoxColumn, Me.GiaDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.SanPhamBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(506, 66)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(642, 392)
        Me.DataGridView2.TabIndex = 69
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
        'SanPhamBindingSource1
        '
        Me.SanPhamBindingSource1.DataMember = "SanPham"
        Me.SanPhamBindingSource1.DataSource = Me.Dsdanhsachsanphamdetimkiem1BindingSource
        '
        'Dsdanhsachsanphamdetimkiem1BindingSource
        '
        Me.Dsdanhsachsanphamdetimkiem1BindingSource.DataSource = Me.Dsdanhsachsanphamdetimkiem1
        Me.Dsdanhsachsanphamdetimkiem1BindingSource.Position = 0
        '
        'Dsdanhsachsanphamdetimkiem1
        '
        Me.Dsdanhsachsanphamdetimkiem1.DataSetName = "dsdanhsachsanphamdetimkiem"
        Me.Dsdanhsachsanphamdetimkiem1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimKiem.Location = New System.Drawing.Point(324, 51)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(133, 35)
        Me.btnTimKiem.TabIndex = 70
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(501, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 25)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Kết quả tìm kiếm:"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-D617688\SQLEXPRESS;Persist Security Info=T" &
    "rue;Password=123;User ID=sa;Initial Catalog=QuanLyNhapXuatKhoHangVBDOTNET"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        SanPham.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            SanPham"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
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
        'SanPhamBindingSource
        '
        Me.SanPhamBindingSource.DataMember = "SanPham"
        Me.SanPhamBindingSource.DataSource = Me.Dsdanhsachsanphamdetimkiem1BindingSource
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnTimKiem)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 123)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm cách 1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Nhập tên sản phẩm:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(21, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 31)
        Me.TextBox1.TabIndex = 79
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(324, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 35)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Tìm kiếm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 123)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tìm kiếm cách 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Nhập tên thương hiệu:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(21, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(288, 31)
        Me.TextBox2.TabIndex = 80
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Apple", "SamSung", "Lenovo", "OPPO", "LG", "HTC", "Huawei"})
        Me.ComboBox1.Location = New System.Drawing.Point(21, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(436, 33)
        Me.ComboBox1.TabIndex = 78
        Me.ComboBox1.Text = "Chọn thương hiệu:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 335)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 123)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tìm kiếm cách 3:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(506, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(648, 62)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Report Sản phẩm "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 575)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "Form3"
        Me.Text = "60-MaiVanTu-Form3"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SanPhamBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsdanhsachsanphamdetimkiem1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsdanhsachsanphamdetimkiem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SanPhamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents Dsdanhsachsanphamdetimkiem1 As dsdanhsachsanphamdetimkiem
    Friend WithEvents Dsdanhsachsanphamdetimkiem1BindingSource As BindingSource
    Friend WithEvents MaSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaDMSPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThuongHieuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SanPhamBindingSource1 As BindingSource
    Friend WithEvents SanPhamBindingSource As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As Button
End Class
