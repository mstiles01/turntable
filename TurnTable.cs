namespace ClassyElectronics{
    public class TurnTable {
        public double CurrentSpeed {get; set;}
        public bool Isplaying {get; set;}
        public void Play()
        {
            Isplaying = true;
        }

        public void Stop()
        {
            Isplaying = false;
        }
    }
}