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
    /// Логика взаимодействия для FovourtiesPage.xaml
    /// </summary>
    public partial class FovourtiesPage : Page
    {
        public FovourtiesPage(int idUSe)
        {
            InitializeComponent();
            FavData.ItemsSource = ODBClass.mAD.Favorites.Where(x => x.UserID == idUSe).ToList();
        }
    }
}
