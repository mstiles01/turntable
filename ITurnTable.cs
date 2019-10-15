namespace ClassyElectronics{
    public interface ITurnTable {
        double CurrentSpeed {get; set;}
         bool Isplaying {get; set;}

        void AddFavorite (double station);
         void Play();


         void Stop();

    }
}