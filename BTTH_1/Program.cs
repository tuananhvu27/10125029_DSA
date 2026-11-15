using System;

class BT_Chuong3
{
    static long Bai1(long n)
    {
        return n == 1 ? 1 : n + Bai1(n-1);
    }

    static long Bai2(long n)
    {
        return n == 1 ? 1 : n*n + Bai2(n-1);
    }

    static double Bai3(double n)
    {
        return n == 1 ? 1 : (1/n) + Bai3(n-1);
    }

    static long Bai4(long m, int n)
    {
        return n == 0 ? 1 : m * Bai4( m, n - 1);
    }

    static int Bai5(int n)
    {
        return n % 2 == 1 ? n : Bai5(n/2);
    }

    static int Bai6(int a, int b)
    {
        return a % b == 0 ? b : Bai6(b, a%b);
    }

    static int Bai7(int n)
    {
        return n == 0 ? 0 : Bai7(n / 10) + 1;
    }

    static double Bai8(double n, double i = 1)
    {
        return n == i ? Math.Sqrt(n) : Math.Sqrt(i + Bai8(n,i+1));
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Bài 1: S(n) = 1 + 2 + 3 + ... + (n-1) + n");
        Console.WriteLine($"S(3) = {Bai1(3)}");
        Console.WriteLine($"S(6) = {Bai1(6)}");
        Console.WriteLine($"S(9) = {Bai1(9)}");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Bài 2: S(n) = 1 + 2^2 + 3^2 + ... + (n-1)^2 + n^2");
        Console.WriteLine($"S(3) = {Bai2(3)}");
        Console.WriteLine($"S(6) = {Bai2(6)}");
        Console.WriteLine($"S(9) = {Bai2(9)}");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Bài 3: S(n) = 1 + 1/2 + 1/3 + ... + 1/(n-1) + 1/n");
        Console.WriteLine($"S(3) = {Bai3(3)}");
        Console.WriteLine($"S(6) = {Bai3(6)}");
        Console.WriteLine($"S(9) = {Bai3(9)}");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Bài 4: Tính lũy thừa S(x,n) = x^n");
        Console.WriteLine($"S(1,3) = {Bai4(1,3)}");
        Console.WriteLine($"S(2,6) = {Bai4(2,6)}");
        Console.WriteLine($"S(3,9) = {Bai4(3,9)}");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Bài 5: Tìm ước lẻ lớn nhất");
        Console.WriteLine($"ULLN(100)  = {Bai5(100)}");
        Console.WriteLine($"ULLN(132) = {Bai5(132)}");
        Console.WriteLine($"ULLN(172) = {Bai5(172)}");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Bài 6: Tìm ước chung lớn nhất");
        Console.WriteLine($"UCLN(6,3) = {Bai6(6,3)}");
        Console.WriteLine($"UCLN(9,6) = {Bai6(9,6)}");
        Console.WriteLine($"UCLN(24,32) = {Bai6(24,32)}");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Bài 7: Tính số chữ số");
        Console.WriteLine($"Số 1234 có {Bai7(1234)} chữ số");
        Console.WriteLine($"Số 171 có {Bai7(172)} chữ số");
        Console.WriteLine($"Số 123456 có {Bai7(123456)} chữ số");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Bài 8: Tính S(n)");
        Console.WriteLine($"S(3) = {Bai8(3)}");
        Console.WriteLine($"S(6) = {Bai8(6)}");
        Console.WriteLine($"S(9) = {Bai8(9)}");
        Console.ReadKey();
        Console.Clear();
    }
}
