using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    public class SaveInformationViewModel : ViewModelBase
    {
        public Tama tamaFile { get; set; }
        public SaveInformationViewModel()
        {
            tamaFile = GameState.PlayerTama;
        }

    }
}
