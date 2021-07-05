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
    /// Логика взаимодействия для PageFeed.xaml
    /// </summary>
    public partial class PageFeed : Page
    {
        public string pathPage { get; set; }
        public PageFeed(int idArticle, string path)
        {
            InitializeComponent();
            pathPage = path;
            var art = ODBClass.mAD.Articles.FirstOrDefault(x => x.ID == idArticle);
            TbName.Text = art.Name;
            TbText.Text = art.Text;
        }
        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (pathPage == "MyArticles")
            {
                FrameClass.frmUser.Navigate(new MyArticles(UserPage.IDUSR));
            }
            if (pathPage == "Nov")
            {
                FrameClass.frmUser.Navigate(new NovostiPage());
            }
        }
    }
}
