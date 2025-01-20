using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DCEvaluacion3P.Models;

namespace DCEvaluacion3P.ViewModels
{
    public class DCCatDetallesViewModel : INotifyPropertyChanged
    {

        private DCCat _cat;
        public DCCat Cat
        {
            get => _cat;
            set
            {
                _cat = value;
                OnPropertyChanged();
            }
        }
        
        public DCCatDetallesViewModel()
        {

        }
        public void initialize(DCCat gatSelec)
        {
            Cat = gatSelec;
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
