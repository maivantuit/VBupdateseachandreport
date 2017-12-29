<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _60_MaiVanTu_Form4
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SanPhamBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1EndBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1End = New cuoikyvbmaivantu2.DataSet1End()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SanPhamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsdanhsachsanphamdetimkiem = New cuoikyvbmaivantu2.dsdanhsachsanphamdetimkiem()
        Me.DsCapNhatSanPhamDienThoai1 = New cuoikyvbmaivantu2.DsCapNhatSanPhamDienThoai()
        Me.SanPhamTableAdapter = New cuoikyvbmaivantu2.DataSet1EndTableAdapters.SanPhamTableAdapter()
        Me.DataSet1EndBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SanPhamBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuanLyNhapXuatKhoHangVBDOTNETDataSet = New cuoikyvbmaivantu2.QuanLyNhapXuatKhoHangVBDOTNETDataSet()
        Me.QuanLyNhapXuatKhoHangVBDOTNETDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1EndBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SanPhamBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1EndBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1End, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SanPhamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsdanhsachsanphamdetimkiem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCapNhatSanPhamDienThoai1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1EndBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SanPhamBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyNhapXuatKhoHangVBDOTNETDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyNhapXuatKhoHangVBDOTNETDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1EndBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SanPhamBindingSource1
        '
        Me.SanPhamBindingSource1.DataMember = "SanPham"
        Me.SanPhamBindingSource1.DataSource = Me.DataSet1EndBindingSource1
        '
        'DataSet1EndBindingSource1
        '
        Me.DataSet1EndBindingSource1.DataSource = Me.DataSet1End
        Me.DataSet1EndBindingSource1.Position = 0
        '
        'DataSet1End
        '
        Me.DataSet1End.DataSetName = "DataSet1End"
        Me.DataSet1End.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataSet1EndBindingSource2
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "cuoikyvbmaivantu2.DanhSachSanPhamReport1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1116, 772)
        Me.ReportViewer1.TabIndex = 0
        '
        'SanPhamBindingSource
        '
        Me.SanPhamBindingSource.DataMember = "SanPham"
        Me.SanPhamBindingSource.DataSource = Me.dsdanhsachsanphamdetimkiem
        '
        'dsdanhsachsanphamdetimkiem
        '
        Me.dsdanhsachsanphamdetimkiem.DataSetName = "dsdanhsachsanphamdetimkiem"
        Me.dsdanhsachsanphamdetimkiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsCapNhatSanPhamDienThoai1
        '
        Me.DsCapNhatSanPhamDienThoai1.DataSetName = "DsCapNhatSanPhamDienThoai"
        Me.DsCapNhatSanPhamDienThoai1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SanPhamTableAdapter
        '
        Me.SanPhamTableAdapter.ClearBeforeFill = True
        '
        'DataSet1EndBindingSource
        '
        Me.DataSet1EndBindingSource.DataSource = Me.DataSet1End
        Me.DataSet1EndBindingSource.Position = 0
        '
        'SanPhamBindingSource2
        '
        Me.SanPhamBindingSource2.DataMember = "SanPham"
        Me.SanPhamBindingSource2.DataSource = Me.DataSet1EndBindingSource
        '
        'QuanLyNhapXuatKhoHangVBDOTNETDataSet
        '
        Me.QuanLyNhapXuatKhoHangVBDOTNETDataSet.DataSetName = "QuanLyNhapXuatKhoHangVBDOTNETDataSet"
        Me.QuanLyNhapXuatKhoHangVBDOTNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuanLyNhapXuatKhoHangVBDOTNETDataSetBindingSource
        '
        Me.QuanLyNhapXuatKhoHangVBDOTNETDataSetBindingSource.DataSource = Me.QuanLyNhapXuatKhoHangVBDOTNETDataSet
        Me.QuanLyNhapXuatKhoHangVBDOTNETDataSetBindingSource.Position = 0
        '
        'DataSet1EndBindingSource2
        '
        Me.DataSet1EndBindingSource2.DataSource = Me.DataSet1End
        Me.DataSet1EndBindingSource2.Position = 0
        '
        '_60_MaiVanTu_Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 619)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "_60_MaiVanTu_Form4"
        Me.Text = "_60_MaiVanTu_Form4"
        CType(Me.SanPhamBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1EndBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1End, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SanPhamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsdanhsachsanphamdetimkiem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCapNhatSanPhamDienThoai1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1EndBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SanPhamBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyNhapXuatKhoHangVBDOTNETDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyNhapXuatKhoHangVBDOTNETDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1EndBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsCapNhatSanPhamDienThoai1 As DsCapNhatSanPhamDienThoai
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SanPhamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsdanhsachsanphamdetimkiem As dsdanhsachsanphamdetimkiem
    Friend WithEvents DataSet1End As DataSet1End
    Friend WithEvents SanPhamTableAdapter As DataSet1EndTableAdapters.SanPhamTableAdapter
    Friend WithEvents DataSet1EndBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SanPhamBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1EndBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents QuanLyNhapXuatKhoHangVBDOTNETDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuanLyNhapXuatKhoHangVBDOTNETDataSet As QuanLyNhapXuatKhoHangVBDOTNETDataSet
    Friend WithEvents SanPhamBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1EndBindingSource2 As System.Windows.Forms.BindingSource
End Class
