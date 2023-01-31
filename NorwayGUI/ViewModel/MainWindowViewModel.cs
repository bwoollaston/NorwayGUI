using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace NorwayGUI.ViewModel
{
    public class MainWindowViewModel
    {
        private ICommand m_ButtonCommand;
        public ICommand ButtonCommand
        {
            get { return m_ButtonCommand; }
            set { m_ButtonCommand = value; }
        }

        public MainWindowViewModel()
        {
            ButtonCommand=new RelayCommand
        }
    }
}
