using System;

namespace kasir
{
    class Program
    {
        public void struknumber(int x, string y, int z, int a)
        {
            Console.WriteLine("{0,-8}" + "|" + "  " + "{1,-27}" + "|" + "  " + "{2,-2}"+ "|" + "{3,8}", x, y, z, a);
        }
        static void Main(string[] args)
        {
            string[] orderan = new string[10];
            int[] jumlah = new int[10];
            int[] harga = new int[10];
            int kali = 17;
            string simbol = new string ('=', kali);
            Console.Write(simbol, kali);
            Console.Write(" WELCOME TO RESTAURANT ");
            Console.WriteLine(simbol, kali);
            Console.Write("Pesanan atas nama siapa: ");
            string nama = Console.ReadLine();
            Console.Write("Ada berapa pesanan menu: ");
            int nomormenu = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= nomormenu; i++)
            {
                Console.Write("Menu ke - " + i + ":");
                orderan[i] = Console.ReadLine();
                Console.Write("Quantity: ");
                jumlah[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Price: ");
                harga[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program P = new Program();
            Console.Write("Ingin mencetak struk? (y/n)");
            string konfirmasi = Console.ReadLine();
            if (konfirmasi == "y")
            {
                string n = "NUMBER";
                string m = "MENU";
                string q = "QTY";
                string p = "PRICE";
                Console.WriteLine("ORDER #0001 FOR " + nama.ToUpper());
                Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
                string batas = new string('-', 55);
                Console.WriteLine(batas);
                Console.WriteLine("{0,-8}" + "|" + "  " + "{1,-27}" + "|" + "  " + "{2,-2}"+ "|" + "{3,8}", n, m, q, p);
                Console.WriteLine(batas);
                for (int l = 1; l <= nomormenu; l++)
                {
                    P.struknumber(l, orderan[l], jumlah[l], harga[l]);
                }
                Console.WriteLine(batas);
                string b = "ITEM COUNT : ";
                int c = nomormenu;
                string t = "TOTAL : ";
                int sum = 0;
                for (int r = 1; r <= nomormenu; r++)
                {
                    sum = sum + (harga[r] * jumlah[r]);
                }

                Console.WriteLine("{0,-55}{1,0}",b, c);
                Console.WriteLine("{0,-55}{1,0}",t, sum);
                Console.WriteLine(batas);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
