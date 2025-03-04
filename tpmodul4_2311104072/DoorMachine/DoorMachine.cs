namespace tpmodul4_2311104072.DoorMachine
{
    /// <summary>
    /// Kelas DoorMachine yang menerapkan state-based construction.
    /// </summary>
    public class DoorMachine
    {
        private DoorState _currentState;

        /// <summary>
        /// Konstruktor. State awal adalah "Terkunci".
        /// </summary>
        public DoorMachine()
        {
            _currentState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        /// <summary>
        /// Method untuk membuka pintu (transisi dari Terkunci ke Terbuka).
        /// </summary>
        public void BukaPintu()
        {
            if (_currentState == DoorState.Terkunci)
            {
                _currentState = DoorState.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka");
            }
        }

        /// <summary>
        /// Method untuk mengunci pintu (transisi dari Terbuka ke Terkunci).
        /// </summary>
        public void KunciPintu()
        {
            if (_currentState == DoorState.Terbuka)
            {
                _currentState = DoorState.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }
}
