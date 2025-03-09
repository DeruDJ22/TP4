using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300101
{
    class KodePos
    {
        //enum untuk daftar kelurahan
        public enum kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, MargaSari, Sekejati, Kebonwaru, Maleer, Samoja };

        //Metode untuk mendapatkan kode pos kelurahan
        public static int getKodePos(kelurahan Kelurahan)
        {
            int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 48286, 48286, 40286, 48272, 40274, 40273 }; //Array berisi data kode pos kelurahan
            return kodePos[(int)Kelurahan]; //mengembalikan nilai indeks sesuai enum yang ada di parameter kelurahan
        }
    }
}
