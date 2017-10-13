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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLoginWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _usernameTB.LabelText = "Username";
            _passwordTB.LabelText = "Password";
            _passwordTB.IsPassword = true;

            animation.From = 0;
            animation.To = 360;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));
            animation.RepeatBehavior = RepeatBehavior.Forever;
            _image.RenderTransform = _rt;
        }

        DoubleAnimation animation = new DoubleAnimation();
        RotateTransform _rt = new RotateTransform();

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            string user = _usernameTB.Text;
            string pass = _passwordTB.Text;

            MessageBox.Show($"{user}:{pass}", "Login");
            //_rt.BeginAnimation(RotateTransform.AngleProperty, animation);
        }
    }
}
