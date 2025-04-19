public class SanPham
{
    private string masp;
    private string tensp;
    private double gia;
    private int soluong;
    public SanPham(string masp, string tensp, double gia, int soluong)
    {
        this.masp = masp;
        this.tensp = tensp;
        this.gia = gia;
        this.soluong = soluong;
    }
    public SanPham()
    {
        this.masp = "";
        this.tensp = "";
        this.gia = 0;
        this.soluong = 0;
    }
    public string MaSP
    {
        get { return masp; }
        set { masp = value; }
    }
    public string TenSP
    {
        get { return tensp; }
        set { tensp = value; }
    }
    public double DonGia
    {
        get { return gia; }
        set { gia = value; }
    }
    public int SoLuong
    {
        get { return soluong; }
        set { soluong = value; }
    }
}

