Public Class frmChuongTrinhQuanLy
    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        frmQuanLyNhanVien.ShowDialog()
    End Sub

    Private Sub QuảnLýToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem1.Click
        frmQuanLySanPham.ShowDialog()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ThôngTinSinhViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinSinhViênToolStripMenuItem.Click
        frmThongTin.ShowDialog()
    End Sub

    Private Sub frmChuongTrinhQuanLy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class