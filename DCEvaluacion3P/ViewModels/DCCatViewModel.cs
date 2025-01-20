using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DCEvaluacion3P.Models;

namespace DCEvaluacion3P.ViewModels
{
    public class DCCatViewModel : INotifyPropertyChanged
    {
        private readonly DCServicioAPI _dCServicioAPI;
        public ObservableCollection<DCCat> Razas { get; set; } = new();
        /*public ObservableCollection<String> NombresRazas { get; set; } = new();*/

        private bool _cargando;
        public bool Cargando
        {
            get => _cargando;
            set
            {
                _cargando = value;
                OnPropertyChanged();
            }
        }

        /*private string _buscarTexto;
        public string BuscarTexto
        {
                get => _buscarTexto;
                set
                {
                    _buscarTexto = value;
                    OnPropertyChanged();
                }
        }

        private string _razaSelec;
        public string RazaSelec
        {
            get => _razaSelec;
            set
            {
                _razaSelec = value;
                OnPropertyChanged();
                BuscarPorRaza();
            }
        }

        public Command Buscar {  get; }*/

        public DCCatViewModel()
        {
            _dCServicioAPI = new DCServicioAPI();
            cargarRaza();
            //Buscar = new Command(async () => await EncontrarRaza());
        }

        private async void cargarRaza()
        {
            Cargando = true;
            var breeds = await _dCServicioAPI.GetBreedsAsync();
            Razas.Clear();
            foreach (var raz in breeds)
            {
                Razas.Add(raz);
            }
            Cargando = false;
        }

       /* private async Task EncontrarRaza()
        {
            var raz = await _dCServicioAPI.GetBreedsAsync();
            Razas.Clear();

            var filteredBreeds = string.IsNullOrEmpty(BuscarTexto)
                ? raz
                : raz.Where(b => b.Nombre.Contains(BuscarTexto, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var ra in filteredBreeds)
            {
                raz.Add(ra);
            }
        }
        private async void BuscarPorRaza()
        {
            if (string.IsNullOrEmpty(RazaSelec)) return;

            var raz = await _dCServicioAPI.GetBreedsAsync();
            Razas.Clear();

            var razSelec = raz.FirstOrDefault(b => b.Nombre.Equals(RazaSelec, StringComparison.OrdinalIgnoreCase));
            if (razSelec != null)
            {
                Razas.Add(razSelec); 
            }
        }*/

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
