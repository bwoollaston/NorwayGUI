using System;
using System.IO;
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
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace NorwayGUI
{
    public partial class MainWindow : Window
    {
        public Compiler compiler = new Compiler();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunMain_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                compiler.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("CCS failed","Exception Sample",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

    }
}
