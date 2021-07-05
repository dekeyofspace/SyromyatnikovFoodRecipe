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

namespace StromyatnikovRecipe
{
    /// <summary>
    /// Логика взаимодействия для OnePage.xaml
    /// </summary>
    public partial class OnePage : Page
    {
        public OnePage()
        {
            InitializeComponent();
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameClass.frmMain.Navigate(new TwoPage());
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
