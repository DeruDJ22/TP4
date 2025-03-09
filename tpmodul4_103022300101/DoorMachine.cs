using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300101
{
    public enum pintu { terkunci, terbuka }; //Enum untuk kondisi pintu
    public enum kegiatan { bukaPintu, kunciPintu }; //Enum untuk kegiatannya
    class DoorMachine
    {
        private pintu state; //Variabel buat status
        public DoorMachine() //Konstruktor buat ngatur state menjadi terkunci secara default
        {
            state = pintu.terkunci;
        }

        public void ubahStatePintu(kegiatan option)
        {
            switch (state) //Switch case untuk kondisi kegiatan usernya
            {
                case pintu.terkunci: //Kasus saat kondisi pintu terkunci
                    if (option == kegiatan.bukaPintu) //Kondisi apabila user melakukan kegiatan buka pintu
                    {
                        Console.WriteLine("Pintu tidak terkunci");
                        state = pintu.terbuka;
                    }
                    else //Kondisi apabila user melakukan kegiatan kunci pintu
                    {
                        Console.WriteLine("Pintu sudah terkunci");
                    }
                    break;
                case pintu.terbuka: //Kasus saat kondisi pintu terbuka
                    if (option == kegiatan.kunciPintu) //Kondisi apabila user melakukan kegiatan kunci pintu
                    {
                        Console.WriteLine("Pintu Terkunci");
                        state = pintu.terkunci;
                    }
                    else //Kondisi apabila user melakukan kegiatan buka pintu
                    {
                        Console.WriteLine("Pintu sudah terpuka");
                    }
                    break;
            }
        }
        public void getStatusPintu() //Prosedur untuk melihat status dari pintu
        {
            Console.WriteLine("Pintu: " + state);
        }
    }
}
