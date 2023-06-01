using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    class DisplaySavesAfterQuitViewModel : ViewModelBase
    {
        public List<Tama> tamaFiles { get; set; }
        public Tama tamaFile { get; set; }
        public DisplaySavesAfterQuitViewModel()
        {
            tamaFiles = FileHandling.ReadSaveFiles();
            tamaFile = GameState.PlayerTama;
        }
    }
}
