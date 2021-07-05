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
    /// Логика взаимодействия для Aurorization.xaml
    /// </summary>
    public partial class Aurorization : Page
    {
        public Aurorization()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameClass.frmMain.Navigate(new Registration());
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (TbEmail.Text != "" && TbPass.Text != "")
            {
                var user = ODBClass.mAD.Users.FirstOrDefault(x => x.Email == TbEmail.Text && x.Password == TbPass.Text);
                if (user != null)
                {
                    FrameClass.frmMain.Navigate(new MainPage(user.ID));
                }
                else { MessageBox.Show("Пользовтель не найден!"); }
            }
            else { MessageBox.Show("Пустые поля!"); }
        }

        private void TbEmail_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var tbox = (TextBox)sender;
            if (tbox.Text == "Account" || tbox.Text == "Password")
            {
                tbox.Text = "";
                tbox.Foreground = Brushes.Black;
            }
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            FrameClass.frmMain.GoBack();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
