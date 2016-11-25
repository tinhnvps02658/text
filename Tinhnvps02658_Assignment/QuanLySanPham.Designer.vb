<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySanPham
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lwDanhSach = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.ptbHinhAnh = New System.Windows.Forms.PictureBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtTheLoai = New System.Windows.Forms.TextBox()
        Me.txtGiaSanPham = New System.Windows.Forms.TextBox()
        Me.txtTenSanPham = New System.Windows.Forms.TextBox()
        Me.txtMaSanPham = New System.Windows.Forms.TextBox()
        Me.lblHinhAnh = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lwDanhSach)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(643, 221)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh Sách Sản Phẩm"
        '
        'lwDanhSach
        '
        Me.lwDanhSach.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lwDanhSach.Location = New System.Drawing.Point(6, 19)
        Me.lwDanhSach.Name = "lwDanhSach"
        Me.lwDanhSach.Size = New System.Drawing.Size(616, 195)
        Me.lwDanhSach.TabIndex = 0
        Me.lwDanhSach.UseCompatibleStateImageBehavior = False
        Me.lwDanhSach.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã Sản Phẩm"
        Me.ColumnHeader1.Width = 81
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên Sản Phẩm"
        Me.ColumnHeader2.Width = 153
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Giá Sản Phẩm"
        Me.ColumnHeader3.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Thể Loại"
        Me.ColumnHeader4.Width = 84
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hình ảnh"
        Me.ColumnHeader5.Width = 101
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
        Me.GroupBox1.Controls.Add(Me.txtTheLoai)
        Me.GroupBox1.Controls.Add(Me.txtGiaSanPham)
        Me.GroupBox1.Controls.Add(Me.txtTenSanPham)
        Me.GroupBox1.Controls.Add(Me.txtMaSanPham)
        Me.GroupBox1.Controls.Add(Me.lblHinhAnh)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 218)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Sản Phẩm"
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(434, 189)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 21
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(353, 189)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 23)
        Me.btnLuu.TabIndex = 21
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'ptbHinhAnh
        '
        Me.ptbHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhAnh.Location = New System.Drawing.Point(443, 17)
        Me.ptbHinhAnh.Name = "ptbHinhAnh"
        Me.ptbHinhAnh.Size = New System.Drawing.Size(179, 161)
        Me.ptbHinhAnh.TabIndex = 20
        Me.ptbHinhAnh.TabStop = False
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(272, 189)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 19
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(192, 189)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 18
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(111, 189)
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
        'txtTheLoai
        '
        Me.txtTheLoai.Location = New System.Drawing.Point(112, 125)
        Me.txtTheLoai.Name = "txtTheLoai"
        Me.txtTheLoai.Size = New System.Drawing.Size(100, 20)
        Me.txtTheLoai.TabIndex = 13
        '
        'txtGiaSanPham
        '
        Me.txtGiaSanPham.Location = New System.Drawing.Point(112, 95)
        Me.txtGiaSanPham.Name = "txtGiaSanPham"
        Me.txtGiaSanPham.Size = New System.Drawing.Size(100, 20)
        Me.txtGiaSanPham.TabIndex = 15
        '
        'txtTenSanPham
        '
        Me.txtTenSanPham.Location = New System.Drawing.Point(112, 65)
        Me.txtTenSanPham.Name = "txtTenSanPham"
        Me.txtTenSanPham.Size = New System.Drawing.Size(264, 20)
        Me.txtTenSanPham.TabIndex = 12
        '
        'txtMaSanPham
        '
        Me.txtMaSanPham.Location = New System.Drawing.Point(112, 34)
        Me.txtMaSanPham.Name = "txtMaSanPham"
        Me.txtMaSanPham.Size = New System.Drawing.Size(100, 20)
        Me.txtMaSanPham.TabIndex = 11
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
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Thể Loại:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Giá Sản Phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tên Sản Phẩm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã Sản Phẩm:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmQuanLySanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 471)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQuanLySanPham"
        Me.Text = "Quản Lý Sản Phẩm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ptbHinhAnh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lwDanhSach As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ptbHinhAnh As System.Windows.Forms.PictureBox
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtTheLoai As System.Windows.Forms.TextBox
    Friend WithEvents txtGiaSanPham As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSanPham As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSanPham As System.Windows.Forms.TextBox
    Friend WithEvents lblHinhAnh As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
