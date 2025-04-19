namespace ThiKetThucMon_LTWindows_2421160014_DangNguyenDuyKhanh
{
    public partial class Form1 : Form
    {
        List<SanPham> sanphams = new List<SanPham>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DocSP();
            KhoiTaoListBox();
        }

        private void KhoiTaoListBox()
        {
            lstSP.DataSource = null;
            lstSP.DisplayMember = "TenSP";
            lstSP.ValueMember = "MaSP";
            lstSP.DataSource = sanphams;
        }

        private void DocSP()
        {
            string chuoi = @"D:\LTWinForm\ThiKetThucMon_LTWindows_2421160014_DangNguyenDuyKhanh\ThiKetThucMon_LTWindows_2421160014_DangNguyenDuyKhanh\DuLieu\sampham.txt";
            string[] mangdong = File.ReadAllLines(chuoi);
            foreach (string dong in mangdong)
            {
                string[] mangthanhphan = dong.Split(':', StringSplitOptions.RemoveEmptyEntries);
                SanPham sp = new SanPham();
                sp.MaSP = mangthanhphan[0];
                sp.TenSP = mangthanhphan[1];
                sp.DonGia = int.Parse(mangthanhphan[2]);
                sp.SoLuong = int.Parse(mangthanhphan[3]);
                sanphams.Add(sp);
            }
        }

        private void lstSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSP.SelectedIndex == -1)
                return;
            SanPham sp = lstSP.SelectedItem as SanPham;
            GanHocVien(sp);
        }

        private void GanHocVien(SanPham? sp)
        {
            if (sp == null) return;
            txtMaSP.Text = sp.MaSP;
            txtTenSP.Text = sp.TenSP;
            txtDonGia.Text = sp.DonGia.ToString("#,00 VNĐ");
            txtSoluong.Text = sp.SoLuong.ToString();

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)

                    (c as TextBox).Clear();

            }
            txtMaSP.ReadOnly = false;
            lstSP.SelectedIndex = -1;
            txtMaSP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            if (!txtMaSP.ReadOnly)
            {
                if (!CheckDataTypeForProduct(true)) return;
                sp = new SanPham();
                sp.MaSP = txtMaSP.Text;
                sp.TenSP = txtTenSP.Text;
                sp.DonGia = double.Parse(txtDonGia.Text);
                sp.SoLuong = int.Parse(txtSoluong.Text);
                sanphams.Add(sp);
                txtMaSP.ReadOnly = true;
            }
            else
            {
                if (!CheckDataTypeForProduct(false)) return;
                sp = TimSP(txtMaSP.Text);
                sp.TenSP = txtTenSP.Text;
                sp.DonGia = double.Parse(txtDonGia.Text.Replace(",", "").Replace("VND", ""));
                sp.SoLuong = int.Parse(txtSoluong.Text);
            }
            KhoiTaoListBox();
            lstSP.SelectedIndex = lstSP.Items.IndexOf(sp);
        }
        private SanPham TimSP(string masp)
        {
            SanPham kq = null;
            foreach (SanPham sp in sanphams)
            {
                if (sp.MaSP == masp)
                {
                    kq = sp;
                    break;
                }
            }
            return kq;
        }
        private bool CheckDataTypeForProduct(bool isThem)
        {
            if (isThem && !txtMaSP.ReadOnly)
            {
                foreach (SanPham a in sanphams)
                {
                    if (a.MaSP == txtMaSP.Text)
                    {
                        MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMaSP.Focus();
                        return false;
                    }
                }
            }
            if (!int.TryParse(txtDonGia.Text.Replace(",", "").Replace("VND", "").Trim(), out int dongia) || dongia == 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
                return false;
            }
            if (!int.TryParse(txtSoluong.Text, out int soluong) || soluong == 0)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoluong.Focus();
                return false;
            }
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSP.Focus();
                return false;
            }
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Mã sản phẩm không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSP.Focus();
                return false;
            }
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSP.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                SanPham sp = TimSP(txtMaSP.Text);
                sanphams.Remove(sp);
                lstSP.SelectedIndex = 0;
                KhoiTaoListBox();

            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            GhiSP();
        }

        private void GhiSP()
        {
            string chuoiSP = @"D:\LTWinForm\ThiKetThucMon_LTWindows_2421160014_DangNguyenDuyKhanh\ThiKetThucMon_LTWindows_2421160014_DangNguyenDuyKhanh\DuLieu\sampham.txt";
            List<string> list = new List<string>();
            foreach (SanPham sp in sanphams)
            {
                string dong = sp.MaSP + ":" + sp.TenSP + ":" + sp.DonGia.ToString() + ":" + sp.SoLuong.ToString();
                list.Add(dong);
            }
            File.WriteAllLines(chuoiSP, list);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult kq = MessageBox.Show("Bạn có muốn Thoát hay không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}
