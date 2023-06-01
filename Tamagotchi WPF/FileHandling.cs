using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF
{
    public class FileHandling
    {
        public static int saveId = 1;
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

        public static void SaveTamaFile()
        {
            var Save = JsonConvert.SerializeObject(GameState.PlayerTama, Formatting.Indented);
            File.WriteAllText($"../../../Saves/SaveFile{GameState.PlayerTama.TamaId}.json", Save);
        }

        public static void SaveTama(Tama? tama)
        {


            //bool saved = false;
            //int counter = 0;
            //List<Tama> saveFiles = ReadSaveFiles();
            //if (saveFiles.Count > 0)
            //{
            //    foreach (var save in saveFiles)
            //    {
            //        if (counter < save.TamaId)
            //        {
            //            counter = save.TamaId;
            //        }
            //        if (save.TamaId == counter && save.Name == GameState.PlayerTama.Name)
            //        {

            //            if (MessageBox.Show($"Overwrite {save.Name}?", "Overwrite", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            //            {
            //                GameState.PlayerTama.TamaId = save.TamaId;
            //                SaveTamaFile();
            //                saved = true;
            //                break;
            //            }
            //            else
            //            {
            //                saved = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //if (!saved)
            //{
            //    GameState.PlayerTama.TamaId = counter+1;
            //    //SaveTamaFile();
            //}
        }
    }
}
