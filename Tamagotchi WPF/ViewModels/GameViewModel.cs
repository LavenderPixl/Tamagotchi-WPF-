using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public int TamaHunger
        {
            get => _tama.Hunger;
            set
            {
                _tama.Hunger = value;
                OnPropertyChanged(nameof(TamaHunger));
            }
        }

        public int TamaCare
        {
            get => _tama.Care;
            set
            {
                _tama.Care = value;
                OnPropertyChanged(nameof(TamaCare));
            }
        }
        public int TamaAmusement
        {
            get => _tama.Amusement;
            set
            {
                _tama.Amusement = value;
                OnPropertyChanged(nameof(TamaAmusement));
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
        //private int _maxXP;
        public int MaxXP
        {
            get => GameState.PlayerTama.CurrentMaxXP;
            set
            {
                GameState.PlayerTama.CurrentMaxXP = value;
                OnPropertyChanged(nameof(MaxXP));
            }
        }

        private const float Multiplier = 1.25f;
        public void CheckXP()
        {

            if (TamaXP >= MaxXP)
            {
                LevelUp();
            }
        }
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

        #endregion

        public GameViewModel()
        {
            EventAggregator.OnTransmittedTama += OnTransmittedTama;
            EventAggregator.OnUpdateTama += OnUpdateTama;
            //_maxXP = GameState.PlayerTama.CurrentMaxXP;
            GifPath = "";
        }

        private void OnTransmittedTama(Tama tama)
        {
            _tama = tama;
        }


        #region UpdatedProps
        //Todo: Apply Care & Amusement props
        private void OnUpdateTama(object value, string propertyName)
        {
            if (propertyName == nameof(TamaXP))
            {
                TamaXP += (int)value;
            }
            else if (propertyName == nameof(TamaHunger))
            {
                TamaHunger += (int)value;
                if (TamaHunger > 100)
                {
                    TamaHunger = 100;
                }
            }
            else if (propertyName == nameof(TamaCare))
            {
                TamaCare += (int)value;
                if (TamaCare > 100)
                {
                    TamaCare = 100;
                }
            }
            else if (propertyName == nameof(TamaAmusement))
            {
                TamaAmusement += (int)value;
                if (TamaAmusement > 100)
                {
                    TamaAmusement = 100;
                }
            }
        }
        #endregion
    }
}
