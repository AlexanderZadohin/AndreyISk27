using AndreyISk27.Class;
using AndreyISk27.View.Windows;
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
    /// Логика взаимодействия для LogInEnterPage.xaml
    /// </summary>
    public partial class LogInEnterPage : Page
    {
        public LogInEnterPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (PhoneNumTb.Text == "+79999999999")
                mes += "Введите номер телефона";
            if (PasswordPb.Password == "0000")
                mes += " и пароль!";
            if (!string.IsNullOrEmpty(mes))
            {
                MessageBox.Show(mes, "Окно предупреждения", MessageBoxButton.OK, MessageBoxImage.Error);
                mes = "";
                return;
            }
            else
            {
                UserApp userApp = App.context.UserApp.FirstOrDefault(u =>
                    u.Password == PasswordPb.Password && u.Phone == PhoneNumTb.Text);
                if (userApp != null)
                {
                    MainAppWindow mainScreenWindow = new MainAppWindow(userApp);
                    mainScreenWindow.Show();

                    Window mainWindow = Window.GetWindow(this);
                    mainWindow.Close();
                }
                else
                {
                    MessageBox.Show("Данные для входа неверны", "Окно предупреждения", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
            }
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
            ClassFrame.FrameBody.Navigate(new View.Pages.RegistationLogInPage());
        }
    }
}
