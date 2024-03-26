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
    /// Логика взаимодействия для MenuMainPage.xaml
    /// </summary>
    public partial class MenuMainPage : Page
    {
        public MenuMainPage()
        {
            InitializeComponent();
        }

        private void NewsBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMainBody.Navigate(new View.Pages.MainNewsBodyPage());
        }

        private void AfishaBtn_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrameMainBody.Navigate(new View.Pages.AfishaMainPage());
        }

        private void ProposalBtn_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrameMainBody.Navigate(new View.Pages.ProposalMainPage());
        }

        private void ClaimsBtn_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrameMainBody.Navigate(new View.Pages.ClaimsMainPage());
        }
    }
}
