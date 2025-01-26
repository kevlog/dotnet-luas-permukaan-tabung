// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenghitungLuasPermukaanTabung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pendeklarasian Variabel
            /*
             phi variabel dari 3.14 atau 22/7
             r variabel dari jari-jari
             t variabel dari tinggi tabung
             lp variabel dari luas permukaan
             */
            double phi, r, t, lp;
            phi = 3.14;
            char u;

            static void Header()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||              PROGRAM PENGHITUNG PERMUKAAN TABUNG              ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" =                                                                 =");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||                          Created By:                          ||");
                Console.WriteLine(" ||                 https://idekevin.blogspot.com                 ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" =                                                                 =");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine(" ||                       CARA MENGGUNAKAN :                      ||");
                Console.WriteLine(" ||             Tekan enter, setelah memasukkan input!            ||");
                Console.WriteLine(" ===================================================================");
                Console.WriteLine();
                Console.WriteLine(" ___________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine();
            }

            static void Footer()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" TIPS :");
                Console.WriteLine(" Berlatih soal-soal secara rutin, akan membantumu");
                Console.WriteLine(" mengusai Matematika.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" ------------------------- Selamat Belajar! ------------------------");
                Console.WriteLine(" -------------------- Matematika itu Menyenangkan ------------------");
                Console.WriteLine(" - Jangan mudah menyerah, karena usaha tidak akan menghianati hasil-");
                Console.WriteLine(" --------------------------------------------------------------------");
            }

            do
            {
                //Judul Program
                Header();

                //Program Penghitung Luas Permukaan Tabung
                Console.Write(" Silahkan masukkan jari-jari (r) alas (Lingkaran) (cm): ");
                var inputR = Console.ReadLine();
                r = string.IsNullOrEmpty(inputR) || !double.TryParse(inputR, out r) ? 0 : double.Parse(inputR);

                Console.Write("              Silahkan masukkan tinggi (t) tabung (cm): ");
                var inputT = Console.ReadLine();
                t = string.IsNullOrEmpty(inputT) || !double.TryParse(inputT, out t) ? 0 : double.Parse(inputT);
            
                lp = 2 * (3.14) * (t + r);
                
                Console.WriteLine("               Hasilnya, luas permukaan tabung adalah : {0} cm", lp);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Penjelasan :");
                Console.WriteLine();
                Console.WriteLine(" Rumus Luas Permukaan Tabung adalah Lp. Tabung = 2 . Phi (r + t)");
                Console.WriteLine(" Di mana r = jari-jari alas, dan t = tinggi tabung");
                Console.WriteLine();
                Console.WriteLine(" Kita ketahui bahwasannya jari-jari alasnya adalah {0} cm", r);
                Console.WriteLine(" dan tingginya tabung adalah {0} cm", t);
                Console.WriteLine(" Sehingga kita bisa mensubstitusikan ke dalam rumus sebagai berikut :");
                Console.WriteLine();
                Console.WriteLine(" Lp. Tabung = 2 . Phi (r + t)");
                Console.WriteLine("            = 2 . {0} . ({1} + {2})", phi, r, t);
                Console.WriteLine();
                Console.WriteLine(" Jadi, luas permukaan tabung adalah {0} cm", lp);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                keluar:
                Console.WriteLine(" Ingin Menghitung Lagi? (y/t)");
                Console.Write(" Jawab : ");
                var input = Console.ReadLine();
                // u = string.IsNullOrEmpty(input) ? 't' : char.Parse(input);
                u = string.IsNullOrEmpty(input) || !char.TryParse(input, out u) ? 't' : u;
                if (u != 'y' && u != 'Y' && u != 't' && u != 'T')
                {
                    Console.Clear();
                    Console.WriteLine(" Inputan Salah! \n");
                    goto keluar;
                }
            }
            while (u == 'y' | u == 'Y');

            do
            {
                Footer();
                System.Threading.Thread.Sleep(2500); //Delay 2.5 detik
                Console.Clear(); //Membersihkan Layar
                Environment.Exit(0); //Keluar dari Program
            }
            while (u == 't' | u == 'T');
        }
    }
}