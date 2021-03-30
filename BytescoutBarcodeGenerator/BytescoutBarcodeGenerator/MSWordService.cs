/*using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows;
//using  System.Windows.Application;
using Bytescout.BarCode;
//using Application = System.Net.Mime.MediaTypeNames.Application;

namespace BytescoutBarcodeGenerator
{
     public class MSWordService
    {
        private object fileInputPath;
        private object fileOutputPath;
        private Application MSWord;

        public MSWordService()
        {
            MSWord = new Application();
            MSWord.Visible = false;
        }

        public void SetInputPath(string path)
        {
            fileInputPath = path;
        }

        public void SetOutputPath(string path)
        {
            fileOutputPath = path;
        }

        public void GenerateBarcodesToOutput(int initialBarcodeValue)
        {
            var wordDocument = GetDocument();
            var bookmarks = wordDocument.Bookmarks;
            int code = initialBarcodeValue;
            Barcode barcode = GetBarcodeWithValue(code.ToString());

            foreach(Bookmark mark in bookmarks)
            {
                barcode.Value = code.ToString();
                var bookmarkRange = GetBookmarkLocation(mark.Name, wordDocument);
                var barcodeImage = barcode.GetImage();

                System.Windows.Clipboard.SetDataObject(barcodeImage);
                bookmarkRange.Paste();
                code++;
            }

            wordDocument.SaveAs(ref fileOutputPath);
            QuiteWord(MSWord);
        }
       /* public Document GetDocument()
        {
            //Document docWord = MSWord.Documents.Open(ref fileInputPath);
            //return docWord;
        }

        private Range GetBookmarkLocation(object bookmarkName, Document document)
        {
            Range bookmarkLocation = document.Bookmarks.get_Item(ref bookmarkName).Range;
            return bookmarkLocation;
        }

        private Barcode GetBarcodeWithValue(string value)
        {
            Barcode barcode = new Barcode();
            barcode.Value = value;
            barcode.Symbology = SymbologyType.Code128;
            return barcode;
        }

        private void QuiteWord(Application app)
        {
            object saveChanges = false;
            //app.Quit(ref saveChanges);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }

    }
}*/
