using System.Collections.Generic;

namespace ClassyElectronics {
    public class Radio : IRadio, ISpeaker {
        public double CurrentFrequency {get; set;}
     public List<double> FavoriteSations {get; set;}

     public bool IsRadioOn {get; set;}

    public void AddFavorite (double station)
        {
            FavoriteSations.Add(station);
            }
    public void RemoveFavorite ( double station)
    {
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

   public  int Volume {get; set;}
         public void VolumeUp()
         {
             Volume++;
         }


       public void VolumeDown()
       {
           Volume--;
       }


    }

    }



