Imports System.IO
Public Class frmQuanLySanPham
    Dim Output As StreamWriter
    Dim Input As StreamReader
    Dim Line As String
    Dim result As String()
    Dim i As Integer
    Dim item As ListViewItem
  
    Private Sub frmQuanLySanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("sanpham.txt") Then
            Input = New StreamReader("sanpham.txt")
            Do Until Input.ReadLine()
                result = Line.Split(ControlChars.Tab)
                item = New ListViewItem(result)
                lwDanhSach.Items.Add(item)
            Loop
        End If
        Input.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        item = New ListViewItem(txtMaSanPham.Text)
        item.SubItems.Add(txtTenSanPham.Text)
        item.SubItems.Add(txtGiaSanPham.Text)
        item.SubItems.Add(txtTheLoai.Text)
        item.SubItems.Add(lblHinhAnh.Text)
        lwDanhSach.Items.Add(item)
    End Sub

    Private Sub lwDanhSach_Click(sender As Object, e As EventArgs) Handles lwDanhSach.Click
        i = lwDanhSach.FocusedItem.Index
        txtMaSanPham.Text = lwDanhSach.Items(i).SubItems(0).Text
        txtTenSanPham.Text = lwDanhSach.Items(i).SubItems(1).Text
        txtGiaSanPham.Text = lwDanhSach.Items(i).SubItems(2).Text
        txtTheLoai.Text = lwDanhSach.Items(i).SubItems(3).Text
        lblHinhAnh.Text = lwDanhSach.Items(i).SubItems(4).Text
        ptbHinhAnh.Image = Image.FromFile(lblHinhAnh.Text)
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        i = lwDanhSach.FocusedItem.Index
        lwDanhSach.Items(i).SubItems(0).Text = txtMaSanPham.Text
        lwDanhSach.Items(i).SubItems(1).Text = txtTenSanPham.Text
        lwDanhSach.Items(i).SubItems(2).Text = txtGiaSanPham.Text
        lwDanhSach.Items(i).SubItems(3).Text = txtTheLoai.Text
        lwDanhSach.Items(i).SubItems(4).Text = lblHinhAnh.Text
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        i = lwDanhSach.FocusedItem.Index
        lwDanhSach.Items(i).Remove()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Output = New StreamWriter("c:/sanpham.txt")
        For i As Integer = 0 To lwDanhSach.Items.Count - 1
            Line = lwDanhSach.Items(i).SubItems(0).Text & ControlChars.Tab & _
                   lwDanhSach.Items(i).SubItems(1).Text & ControlChars.Tab & _
                   lwDanhSach.Items(i).SubItems(2).Text & ControlChars.Tab & _
                   lwDanhSach.Items(i).SubItems(3).Text & ControlChars.Tab & _
                   lwDanhSach.Items(i).SubItems(4).Text 
            Output.WriteLine(Line)
        Next
        Output.Close()
        btnThoat.Enabled = True
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Title = "Vui Lòng Chọn Hình"
        OpenFileDialog1.ShowDialog()
        lblHinhAnh.Text = OpenFileDialog1.FileName.ToString()
        ptbHinhAnh.Image = Image.FromFile(lblHinhAnh.Text)
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class