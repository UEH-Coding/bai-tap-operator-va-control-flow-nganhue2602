using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btcslt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== MAIN MENU =====");
                Console.WriteLine("1. Operators Exercises");
                Console.WriteLine("2. If-Else Exercises");
                Console.WriteLine("3. Control Flow Statements");
                Console.WriteLine("0. Exit");
                Console.Write("Chon muc: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: OperatorsMenu(); break;
                    case 2: IfElseMenu(); break;
                    case 3: ControlFlowMenu(); break;
                    case 0: return;
                    default: Console.WriteLine("Lua chon khong hop le!"); break;
                }
            }
        }

        // ---------------- Operators ----------------
        static void OperatorsMenu()
        {
            Console.WriteLine("\n--- Operators ---");
            Console.WriteLine("1. Thuc hine phep toan 2 so");
            Console.WriteLine("2. Tinh ham x = y^2 + 2y + 1 (-5..5)");
            Console.WriteLine("3. Tính vận tốc km/h & miles/h");
            Console.WriteLine("4. Dien tich và the tich hinh cau");
            Console.WriteLine("5. Kiem tra ky tu nhap vao");
            Console.Write("Chon bai: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Operators1(); break;
                case 2: Operators2(); break;
                case 3: Operators3(); break;
                case 4: Operators4(); break;
                case 5: Operators5(); break;
            }
        }

        static void Operators1()
        {
            Console.Write("Nhap so thu nhat: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan (+,-,*,/): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = 0;
            switch (op)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = (b != 0) ? a / b : double.NaN; break;
                default: Console.WriteLine("Phep toan khong hop le"); return;
            }
            Console.WriteLine($"Kết quả: {result}");
        }

        static void Operators2()
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }

        static void Operators3()
        {
            Console.Write("Nhap khoang cach (km): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Nhap gio: "); int h = int.Parse(Console.ReadLine());
            Console.Write("Nhap phut: "); int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap giay: "); int s = int.Parse(Console.ReadLine());

            double timeHours = h + m / 60.0 + s / 3600.0;
            double speedKm = distance / timeHours;
            double speedMiles = speedKm / 1.609;
            Console.WriteLine($"Toc do: {speedKm:F2} km/h | {speedMiles:F2} miles/h");
        }

        static void Operators4()
        {
            Console.Write("Nhập bán kính r: ");
            double r = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * r * r;
            double volume = (4.0 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Dien tich = {surface:F2}, The tich = {volume:F2}");
        }

        static void Operators5()
        {
            Console.Write("Nhap ky tu: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if ("aeiouAEIOU".Contains(ch))
                Console.WriteLine("Day la so nguyen am");
            else if (char.IsDigit(ch))
                Console.WriteLine("Day la chu so");
            else if (char.IsLetter(ch))
                Console.WriteLine("Day la phu am");
            else
                Console.WriteLine("Day la ky tu dac biet");
        }

        // ---------------- If-Else ----------------
        static void IfElseMenu()
        {
            Console.WriteLine("\n--- If-Else ---");
            Console.WriteLine("1. Kiem tra chan/le");
            Console.WriteLine("2. Tìm so lon nhat trong 3 so");
            Console.WriteLine("3. Xac dinh goc phan tu (x,y)");
            Console.Write("Chon bai: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: IfElse1(); break;
                case 2: IfElse2(); break;
                case 3: IfElse3(); break;
            }
        }

        static void IfElse1()
        {
            Console.Write("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "So chan" : "So le");
        }

        static void IfElse2()
        {
            Console.Write("Nhap so a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c: "); int c = int.Parse(Console.ReadLine());
            int max = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"So lon nhat: {max}");
        }

        static void IfElse3()
        {
            Console.Write("Nhap X: "); int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap Y: "); int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0) Console.WriteLine("Diem thuoc goc phan tu I");
            else if (x < 0 && y > 0) Console.WriteLine("Diem thuoc goc phan tu II");
            else if (x < 0 && y < 0) Console.WriteLine("Diem thuoc goc phan tu III");
            else if (x > 0 && y < 0) Console.WriteLine("Diem thuoc goc phan tu IV");
            else Console.WriteLine("Diem nam tren goc hoac truc toa do");
        }

        // ---------------- Control Flow ----------------
        static void ControlFlowMenu()
        {
            Console.WriteLine("\n--- Control Flow ---");
            Console.WriteLine("1. Kiem tra loai tam giac");
            Console.WriteLine("2. Nhap 10 so và tinh tong, trung binh");
            Console.WriteLine("3. Bang cuu chuong");
            Console.WriteLine("4. In tam giac so");
            Console.WriteLine("5. In pattern");
            Console.WriteLine("6. Day Harmonic");
            Console.WriteLine("7. Tim so hoan thien");
            Console.WriteLine("8. Kiem tra so nguyen to");
            Console.Write("Chon bai: ");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Control1(); break;
                case 2: Control2(); break;
                case 3: Control3(); break;
                case 4: Control4(); break;
                case 5: Control5(); break;
                case 6: Control6(); break;
                case 7: Control7(); break;
                case 8: Control8(); break;
            }
        }

        static void Control1()
        {
            Console.Write("Nhap canh a: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: "); int c = int.Parse(Console.ReadLine());

            if (a == b && b == c) Console.WriteLine("Tam giac đeu");
            else if (a == b || b == c || a == c) Console.WriteLine("Tam giac can");
            else Console.WriteLine("Tam giac thuong");
        }

        static void Control2()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhap so {i}: ");
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Tong = {sum}, Trung binh = {sum / 10.0}");
        }

        static void Control3()
        {
            Console.Write("Nhap số n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }

        static void Control4()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }

        static void Control5()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }

        static void Control6()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.Write($"1/{i} ");
            }
            Console.WriteLine($"\nTong = {sum:F2}");
        }

        static void Control7()
        {
            Console.Write("Nhap gioi han: ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac so hoan thien:");
            for (int num = 1; num <= limit; num++)
            {
                int sum = 0;
                for (int i = 1; i < num; i++)
                    if (num % i == 0) sum += i;
                if (sum == num)
                    Console.WriteLine(num);
            }
        }

        static void Control8()
        {
            Console.Write("Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = n > 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) isPrime = false;
            Console.WriteLine(isPrime ? "So nguyen to" : "Khong phai so nguyen to");
        }
    }
}
