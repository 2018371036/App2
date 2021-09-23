using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    { 
        private String _nombre;

        public MainPageViewModel()
        {
            _nombre = "Hola";
        }
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;

                _nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(SinUpdate));
            }
        }

        public string SinUpdate
        {
            get => _nombre;
        }
    }
}
