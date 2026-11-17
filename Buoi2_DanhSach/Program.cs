using System;

class NhanVien
{
    public string MaNV;
    public string HoTen;
    public int NamSinh;
    public string PhongBan;
    public int LuongCB;
    public int Thuong;
    public int ThucLinh { get { return LuongCB + Thuong; } private set; }

    public NhanVien(string manv, String hoten, int namsinh, string phongban, int luongcb, int thuong)
    {
        MaNV = manv;
        HoTen = hoten;
        NamSinh = namsinh;
        PhongBan = phongban;
        LuongCB = luongcb;
        Thuong = thuong;
    }

    public string ThongTin()
    {
        return $"Ma NV: {MaNV} " +
               $"Ho ten: {HoTen} " +
               $"Nam sinh: {NamSinh} " +
               $"Phong ban: {PhongBan} " +
               $"Luong co ban: {LuongCB} " +
               $"Thuong: {Thuong} " +
               $"Thuc linh: {ThucLinh}";
    }
}

class DSNhanVien
{
    public static NhanVien[] DS = new NhanVien[4];
    private static int ViTri = 0;

    public void ThemNV(NhanVien a)
    {
        if (ViTri == 4)
            return;
        DS[ViTri] = a;
        ViTri++;
    }

    public void HienThi()
    {
        foreach (NhanVien a in DS)
        {
            if (a != null)
                Console.WriteLine(a.ThongTin());
        }
    }

    public int TongTL()
    {
        int T = 0;
        foreach (NhanVien a in DS)
            T += a.ThucLinh; 
        return T;
    }

    public int LuongCBThap()
    {
        int min = DS[0].LuongCB;
        foreach (NhanVien a in DS)
            min = a.LuongCB < min ? a.LuongCB : min;
        return min;
    }

    public int SLTheoThuong(int t)
    {
        int SL = 0;
        foreach (NhanVien a in DS)
            SL += a.Thuong >= 1200000 ? 1 : 0;
        return SL;
    }

    public void CapNhatLuong(int t)
    {
        foreach (NhanVien a in DS)
            a.LuongCB = (a.LuongCB * 105) / 100;
    }
}

class BT_Chuong4
{
    static void Bai1()
    {
        Console.WriteLine("Bài 1:");
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập số thứ {i+1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Mảng đã nhập: ");
        foreach (int i in arr)
            Console.Write($"{i} ");
        Console.Write("\nNhập vị trí cần chèn: ");
        int a = int.Parse(Console.ReadLine());
        if (a < 0 || a > n)
        {
            Console.WriteLine("Sai vị trí");
            return;
        }
        else
        {
            Console.Write("Nhập số cần chèn: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = n-1;i >= a-1;i--)
                arr[i] = i != a-1 ? arr[i - 1] : b;
            Console.WriteLine("Mảng sau chèn: ");
            foreach (int i in arr)
                Console.Write($"{i} ");
        }
    }

    static void Bai2()
    {
        Console.WriteLine("Bài 2:");
        DSNhanVien a1 = new DSNhanVien();
        a1.ThemNV(new NhanVien("01", "A", 2001, "A1", 2000000, 1000000));
        a1.ThemNV(new NhanVien("02", "B", 2002, "B2", 1000000, 1200000));
        a1.ThemNV(new NhanVien("03", "C", 2003, "C3", 1200000, 1000000));
        a1.ThemNV(new NhanVien("04", "D", 2004, "D4", 1000000, 1200000));
        Console.WriteLine("Danh sách nhân viên: ");
        a1.HienThi();
        Console.WriteLine($"Tổng thực lĩnh của toàn bộ NV: {a1.TongTL()}");
        Console.WriteLine("Danh sách nhân viên có mức lương CB thấp nhất: ");
        int min = a1.LuongCBThap();
        foreach (NhanVien a in DSNhanVien.DS)
        {
            if (a != null && a.LuongCB == min)
                Console.WriteLine(a.ThongTin());
        }
        Console.WriteLine($"Số lượng NV có thưởng >= 1200000: {a1.SLTheoThuong(1200000)}");
        Console.WriteLine("Tăng lương cơ bản 5%: ");
        a1.CapNhatLuong(5);
        a1.HienThi();
    }



    static void Bai3()
    {
        Console.WriteLine("Bài 3:");
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] MaTran = new int[n,n];
        Random rd = new Random();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; MaTran[i, j++] = rd.Next(1, 101));
        int Tong = 0;
        int min = 101;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int a = MaTran[i, j];
                Console.Write(a + "\t");
                Tong += a;
                min = a<min ? a : min;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tổng các phần tử trong ma trận là: " + Tong);
        Console.WriteLine("Phần tử dương nhỏ nhất trong ma trận là: " + min);
        int TongPhu = 0;
        for (int i = 0; i < n; i++)
            TongPhu += MaTran[i, n - 1 - i];
        Console.WriteLine("Tổng đường chéo phụ là: " + TongPhu);
        int b = 0;
        bool c = true;
        for (int i = 0; i < n; i++)
        {
            if (MaTran[i,i] > b)
            {
                b = MaTran[i,i];
                c = true;
            }
            else
            {
                c = false;
                break;
            }
        }
        Console.WriteLine(c ? "Đường chéo chính tăng":"Đường chéo chính không tăng");
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Clear();
        Bai1();
        Console.ReadKey();

        Console.Clear();
        Bai2();
        Console.ReadKey();

        Console.Clear();
        Bai3();
        Console.ReadKey();
    }
}
