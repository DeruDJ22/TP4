﻿using System;

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

            Console.WriteLine("\n================================");
            DoorMachine pintu = new DoorMachine();

            pintu.getStatusPintu();
            String input = "";
            while (input != "keluar")
            {
                Console.WriteLine("Perintah (bukaPintu/kunciPintu)");
                input = Console.ReadLine();
                if (Enum.TryParse(input, out kegiatan trigger))
                {
                    pintu.ubahStatePintu(trigger);
                }
                else
                {
                    Console.WriteLine("Perintah tidak valid coba lagi");
                }
            }
            Console.WriteLine("================================");
        }
    }
}