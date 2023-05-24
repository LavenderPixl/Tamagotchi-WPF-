using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF
{
    public class FileHandling
    {
        private static string[] GetSaveFiles()
        {
            string[] saves = Directory.GetFiles("../../../Saves/", "*.json", SearchOption.TopDirectoryOnly);
            return saves;
        }
        /// <summary>
        /// Reads Save files, and converts them into a List.
        /// </summary>
        /// <returns>List of Tamas</returns>
        public static List<Tama> ReadSaveFiles()
        {
            List<Tama> savesList = new List<Tama>();
            foreach (var save in GetSaveFiles())
            {
                string fileLoad = File.ReadAllText(save);
                var deserial = JsonConvert.DeserializeObject<Tama>(fileLoad);
                savesList.Add(deserial);
            }
            return savesList;
        }

        public static void SaveTama()
        {
            var Save = JsonConvert.SerializeObject(GameState.PlayerTama, Formatting.Indented);
            File.WriteAllText($"../../../Saves/{GameState.PlayerTama.Name}.json", Save);
        }
    }
}
