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
using System.Windows.Shapes;

namespace AndreyISk27.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainAppWindow.xaml
    /// </summary>
    public partial class MainAppWindow : Window
    {
        public MainAppWindow()
        {
            InitializeComponent();


            ClassFrame.FrameMenu = MenuFrm;
            MenuFrm.Navigate(new View.Pages.MenuMainPage());


            ClassFrame.FrameMainBody = MainBodyFrm;
        }
    }
}
