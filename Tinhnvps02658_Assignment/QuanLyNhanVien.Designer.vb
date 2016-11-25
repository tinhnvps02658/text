<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyNhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLyNhanVien))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.ptbHinhAnh = New System.Windows.Forms.PictureBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtNamSinh = New System.Windows.Forms.TextBox()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtTenNhanVien = New System.Windows.Forms.TextBox()
        Me.txtMaNhanVien = New System.Windows.Forms.TextBox()
        Me.lblHinhAnh = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lwDanhSach = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.btnLuu)
        Me.GroupBox1.Controls.Add(Me.ptbHinhAnh)
        Me.GroupBox1.Controls.Add(Me.btnXoa)
        Me.GroupBox1.Controls.Add(Me.btnSua)
        Me.GroupBox1.Controls.Add(Me.btnThem)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.txtNamSinh)
        Me.GroupBox1.Controls.Add(Me.txtDienThoai)
        Me.GroupBox1.Controls.Add(Me.txtGioiTinh)
        Me.GroupBox1.Controls.Add(Me.txtTenNhanVien)
        Me.GroupBox1.Controls.Add(Me.txtMaNhanVien)
        Me.GroupBox1.Controls.Add(Me.lblHinhAnh)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 218)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Nhân Viên"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(436, 189)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 22
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(193, 189)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 23)
        Me.btnLuu.TabIndex = 21
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'ptbHinhAnh
        '
        Me.ptbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhAnh.Location = New System.Drawing.Point(436, 17)
        Me.ptbHinhAnh.Name = "ptbHinhAnh"
        Me.ptbHinhAnh.Size = New System.Drawing.Size(199, 166)
        Me.ptbHinhAnh.TabIndex = 20
        Me.ptbHinhAnh.TabStop = False
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(355, 189)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 19
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(274, 189)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 18
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(112, 189)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(301, 158)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 20)
        Me.btnBrowse.TabIndex = 16
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtNamSinh
        '
        Me.txtNamSinh.Location = New System.Drawing.Point(276, 95)
        Me.txtNamSinh.Name = "txtNamSinh"
        Me.txtNamSinh.Size = New System.Drawing.Size(100, 20)
        Me.txtNamSinh.TabIndex = 14
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(112, 125)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(100, 20)
        Me.txtDienThoai.TabIndex = 13
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(112, 95)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(100, 20)
        Me.txtGioiTinh.TabIndex = 15
        '
        'txtTenNhanVien
        '
        Me.txtTenNhanVien.Location = New System.Drawing.Point(112, 65)
        Me.txtTenNhanVien.Name = "txtTenNhanVien"
        Me.txtTenNhanVien.Size = New System.Drawing.Size(264, 20)
        Me.txtTenNhanVien.TabIndex = 12
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.Location = New System.Drawing.Point(112, 34)
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.Size = New System.Drawing.Size(100, 20)
        Me.txtMaNhanVien.TabIndex = 11
        '
        'lblHinhAnh
        '
        Me.lblHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHinhAnh.Location = New System.Drawing.Point(112, 158)
        Me.lblHinhAnh.Name = "lblHinhAnh"
        Me.lblHinhAnh.Size = New System.Drawing.Size(183, 20)
        Me.lblHinhAnh.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Hình ảnh (nếu có):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Điện Thoại:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(218, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Năm Sinh:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Giới Tính:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tên Nhân Viên:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã Nhân Viên:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lwDanhSach)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 221)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh Sách Nhân Viên"
        '
        'lwDanhSach
        '
        Me.lwDanhSach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lwDanhSach.Location = New System.Drawing.Point(6, 19)
        Me.lwDanhSach.Name = "lwDanhSach"
        Me.lwDanhSach.Size = New System.Drawing.Size(629, 195)
        Me.lwDanhSach.TabIndex = 0
        Me.lwDanhSach.UseCompatibleStateImageBehavior = False
        Me.lwDanhSach.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã Nhân Viên"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên Nhân Viên"
        Me.ColumnHeader2.Width = 113
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Giới Tính"
        Me.ColumnHeader3.Width = 57
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Năm Sinh"
        Me.ColumnHeader4.Width = 74
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Số Điện Thoại"
        Me.ColumnHeader5.Width = 102
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Hình Ảnh"
        Me.ColumnHeader6.Width = 206
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmQuanLyNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 471)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQuanLyNhanVien"
        Me.Text = "Quản Lý Nhân Viên"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ptbHinhAnh As System.Windows.Forms.PictureBox
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtNamSinh As System.Windows.Forms.TextBox
    Friend WithEvents txtDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents txtGioiTinh As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNhanVien As System.Windows.Forms.TextBox
    Friend WithEvents lblHinhAnh As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lwDanhSach As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
