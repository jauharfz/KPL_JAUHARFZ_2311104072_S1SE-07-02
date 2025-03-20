using System.ComponentModel;

namespace tpmodul4_2311104072.DoorMachine
{
    public class DoorMachine
    {
        private DoorState current;

        public DoorMachine()
        {
            current = DoorState.TERKUNCI;
        }

        public void terbuka()
        {
            switch (current)
            {
                case DoorState.TERBUKA:
                    Console.WriteLine("PINTUNYA MEMANG SUDAH TERBUKA!");
                    break;
                case DoorState.TERKUNCI:
                    current = DoorState.TERBUKA;
                    Console.WriteLine("pintu terbuka :)");
                    break;
                default:
                    throw new InvalidEnumArgumentException("mff input tidak dikenali");
            }
        }

        public void terkunci()
        {
            switch (current)
            {
                case DoorState.TERBUKA:
                    Console.WriteLine("pintu terkunci :)");
                    current = DoorState.TERKUNCI;
                    break;
                case DoorState.TERKUNCI:
                    Console.WriteLine("PINTUNYA MEMANG SUDAH TERKUNCI!");
                    break;
                default:
                    throw new InvalidEnumArgumentException("mff input tidak dikenali");
            }
        }

        public void showState()
        {
            Console.WriteLine($"Kondisi pintunya sekarang itu {current}");
        }
    }
}