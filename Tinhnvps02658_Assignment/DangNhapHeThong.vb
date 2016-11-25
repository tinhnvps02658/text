Public Class frmDangNhapHeThong


    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If txtTaiKhoan.Text = "taikhoan" And TxtMatKhau.Text = "matkhau" Then
            Me.Hide()
            MessageBox.Show("Chúc mừng bạn đã đăng nhâp thành công", "Tinhnvps02658", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmChuongTrinhQuanLy.Show()
        Else
            If txtTaiKhoan.Text = "" Then
                MessageBox.Show("Bạn quên nhập tài khoản rồi", "Có Lỗi Bạn ơi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTaiKhoan.Focus()
            Else
                If TxtMatKhau.Text = "" Then
                    MessageBox.Show("Nhập giúp mình mật khẩu đi bạn", "Có Lỗi Bạn ơi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtMatKhau.Focus()
                Else
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai rồi bạn", "Có Lỗi Bạn ơi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class
