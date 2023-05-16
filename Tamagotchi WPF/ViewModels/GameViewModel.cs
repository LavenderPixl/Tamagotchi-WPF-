using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi_WPF.Objects;

namespace Tamagotchi_WPF.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        private Tama _tama;
        public string GifPath { get; set; }


        public string TamaName 
        { 
            get => _tama.Name;
            set
            {
                _tama.Name = value;
                OnPropertyChanged(nameof(TamaName));
            } 
        }

        //todo: Hunger value changes? 
        public int TamaHunger
        {
            get => _tama.Hunger;
            set
            {
                _tama.Hunger = value;
                OnPropertyChanged(nameof(TamaHunger));
            }
        }
        #region Level
        public int TamaLevel 
        { 
            get => _tama.Level;
            set
            {
                _tama.Level = value;
                OnPropertyChanged(nameof(TamaLevel));
            } 
        }
        public int TamaXP 
        {
            get => _tama.XP;
            set
            {
                _tama.XP = value;
                CheckXP();
                OnPropertyChanged(nameof(TamaXP));
            }
        }
        private int _maxXP;
        public int MaxXP
        {
            get => _maxXP;
            set
            {
                _maxXP = value;
                OnPropertyChanged(nameof(MaxXP));
            }
        }

        private const float Multiplier = 1.25f;

        public void LevelUp()
        {
            try
            {
                TamaLevel++;

                int TempoXP = TamaXP - MaxXP;
                TamaXP = TempoXP;
                MaxXP = Convert.ToInt32(Math.Round(MaxXP * Multiplier));
            }
            catch (Exception)
            {
                return;
            }
        }
        public void CheckXP()
        {

            if (TamaXP >= MaxXP)
            {
                LevelUp();
            }
        }
        #endregion

        public GameViewModel()
        {
            EventAggregator.OnTransmittedTama += OnTransmittedTama;
            EventAggregator.OnUpdateTama += OnUpdateTama;
            _maxXP = 100;
            GifPath = "";
        }

        private void OnTransmittedTama(Tama tama)
        {
            _tama = tama;
        }

        private void OnUpdateTama(object value, string propertyName)
        {
            if (propertyName == nameof(TamaXP))
                TamaXP += (int)value;
        }
    }
}
