using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    public class NewGameViewModel : ViewModelBase
    {
        public int TamaType { get; set; }

        public string TamaName { get; set; }

        public string NotificationText { get; set;}

        private Tama _newTama;

        private string GetCreatureType() => dal.CreatureTypes[TamaType];

        public NewGameViewModel()
        {
            RandomCreatureType();
        }

        public void RandomCreatureType()
        {
            Random rnd = new Random();
            TamaType = rnd.Next(0, 4);
        }

        public string GetNotificationText(int counter)
        {
            switch (counter)
            {
                case 1:
                    return "Your Egg is starting to shake! Is it hatching?";
                case 2:
                    return $"Congratulations, it's a {GetCreatureType()} creature!";
                case >=3:
                    return "Please name your Tama";
                default:
                    return "";
            }
        }

        public void StartGame()
        {
            CreateTama();
            EventAggregator.Broadcast(typeof(GameViewModel));
            EventAggregator.CreateNewGame(_newTama);
        }

        public void CreateTama()
        {           
            _newTama = new Tama(TamaName, 1, 0, 100, 100, 100, 100,
            $"../../../TamaIMG/{GetCreatureType()}/Idle.gif", GetCreatureType());
        }
    }
}
