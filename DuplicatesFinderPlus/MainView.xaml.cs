using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DuplicatesFinderPlus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        bool ones = false;
        public MainView()
        {
            InitializeComponent();
        }
        public MainViewModel InputInfo = new MainViewModel();


        private void Window_Loaded(object j, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
            InnerPath.Focus();
        }


        // Clear TextBox after that user has started write
        private void Clear_Text (Object j, RoutedEventArgs e)
        {
            if (ones == false)
            {
                InnerPath.Clear();
                ones = true;
            }
        }

    }
}
