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
    /// Логика взаимодействия для MyArticles.xaml
    /// </summary>
    public partial class MyArticles : Page
    {
        public MyArticles(int UserID)
        {
            InitializeComponent();
            FavData.ItemsSource = ODBClass.mAD.Articles.Where(x => x.UserID == UserID).ToList();
        }

        private void DataGridRow_Selected(object sender, RoutedEventArgs e)
        {
            var row = (DataGridRow)sender;
            var contex = row.DataContext as Articles;
            FrameClass.frmUser.Navigate(new PageFeed(contex.ID, "MyArticles"));
        }
    }
}
