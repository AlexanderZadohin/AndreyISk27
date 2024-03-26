using AndreyISk27.Class;
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

namespace AndreyISk27.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistationLogInPage.xaml
    /// </summary>
    public partial class RegistationLogInPage : Page
    {
        public RegistationLogInPage()
        {
            InitializeComponent();
        }

        private void PasswordPb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == "")
            {
                PasswordPb.Password = "0000";
            }

        }

        private void PasswordPb_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordPb.Password = "";
        }

        private void PhoneNumTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PhoneNumTb.Text == "")
            {
                PhoneNumTb.Text = "+79999999999";
            }
        }

        private void PhoneNumTb_GotFocus(object sender, RoutedEventArgs e)
        {
            PhoneNumTb.Text = string.Empty;
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.LogInEnterPage());
        }

    }
}
