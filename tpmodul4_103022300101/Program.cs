using System;

namespace tpmodul4_103022300101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daftar Kelurahan");
            Console.WriteLine("=================================");
            Console.WriteLine("Kelurahan\t |     Kode Pos");
            Console.WriteLine("=================================");
            foreach (KodePos.kelurahan kel in Enum.GetValues(typeof(KodePos.kelurahan))) //Perulangan untuk menampilkan kelurahan dan kodepos
            {
                String namaKelurahan = kel.ToString();
                Console.WriteLine($"{kel,-16} |     {KodePos.getKodePos(kel)}");
            }
        }
    }
}