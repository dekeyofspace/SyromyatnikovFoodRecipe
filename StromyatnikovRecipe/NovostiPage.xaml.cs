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
    /// Логика взаимодействия для NovostiPage.xaml
    /// </summary>
    public partial class NovostiPage : Page
    {
        public NovostiPage()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameClass.frmUser.Navigate(new PageFeed(1, "Nov"));
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
           FrameClass.frmUser.Navigate(new PageFeed(2, "Nov"));
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
           FrameClass.frmUser.Navigate(new PageFeed(3, "Nov"));
        }
    }
}
