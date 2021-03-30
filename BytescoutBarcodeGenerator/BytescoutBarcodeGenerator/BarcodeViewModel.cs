using Bytescout.BarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytescoutBarcodeGenerator
{
    public class BarcodeViewModel:INotifyPropertyChanged
    {
        private string value;
        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                OnPropertyChanged("Value");

            }
        }

        private SymbologyType symbology;

        public SymbologyType Symbology
        {
            get
            {
                return symbology;
            }
            set
            {
                symbology = value;
                OnPropertyChanged("Symbology");

            }
        }

        public BarcodeViewModel()
        {
            Value = "12345";
            Symbology = SymbologyType.Code128;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
