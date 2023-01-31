using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace NorwayGUI.ViewModel
{
    internal class PrgViewChange
    {
        public bool IsPrgLoading { get; set; }
        public Brush PrglblColor { get; set; }
        public string PrglblText { get; set; }

        public PrgViewChange()
        {
            Init();
        }
        public void Init()
        {
            IsPrgLoading = false;
            PrglblText = "Ready to program";
            PrglblColor = new SolidColorBrush(Colors.Green);
        }
        public void StartPrograming()
        {
            IsPrgLoading = true;
            PrglblText = "Programing in progress";
            PrglblColor = new SolidColorBrush(Colors.Red);
        }
        public void FinishPrograming()
        {
            Init();
        }
    }
}
