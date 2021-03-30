using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BytescoutBarcodeGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, RoutedEventArgs e)
        {
            SaveControl("PNG Image|*.png|TIFF Image|*.tif;*.tiff|JPEG image|*.jpg;*..jpeg");

        }

        private void PdfButton_Clicked(object sender, RoutedEventArgs e)
        {
            SaveControl("PDF|*.pdf");
        }

        private void SaveControl(string filter)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = filter;
            if(saveDialog.ShowDialog()==true)
            {
                barcodeControl.SaveImage(saveDialog.FileName);
            }
        }
    }
}
