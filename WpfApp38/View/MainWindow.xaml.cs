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
using WpfApp38.Core;
using WpfApp38.Model;
using WpfApp38.View.Pages;

namespace WpfApp38
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreConnection.CoreFrame = MainFrame;
            CoreConnection.DB = new test03Entities();

            MainFrame.Navigate(new MainLoginPage());
        }
    }
}
