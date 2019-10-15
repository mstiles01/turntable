using System.Collections.Generic;

namespace ClassyElectronics {
    public class Radionator4001 : Speakanator3001{
        public double CurrentFrequency {get; set;}
        public List<double> FavoriteSations {get; set;} = new List<double>();

        public bool IsRadioOn {get; set;}

        public void AddFavorite (double station) {
            FavoriteSations.Add(station);
    }

    public void RemoveFavorite ( double station) {
        FavoriteSations.Remove(station);
    }

    public void TurnRadio()
    {
        IsRadioOn = true;
    }
public void TurnOff()
{
    IsRadioOn = false;
}

}
}