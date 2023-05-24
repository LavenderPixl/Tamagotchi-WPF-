using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    class SavesViewModel : ViewModelBase
    {
        public List<Tama> tamaFiles { get; set; }
        public SavesViewModel()
        {
            tamaFiles = FileHandling.ReadSaveFiles();

        }
    }
}
