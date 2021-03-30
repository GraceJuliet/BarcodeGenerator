using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytescoutBarcodeGenerator
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public BarcodeViewModel Barcode { get; set; }
      //  public MSWordService Service { get; set; }



        public MainViewModel()
        {
            Barcode = new BarcodeViewModel();
          //  Service = new MSWordService();
        }















        public event PropertyChangedEventHandler PropertyChanged;
    }
}
