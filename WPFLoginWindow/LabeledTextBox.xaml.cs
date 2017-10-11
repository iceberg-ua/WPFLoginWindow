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

namespace WPFLoginWindow
{
    /// <summary>
    /// Interaction logic for LabeledTextBox.xaml
    /// </summary>
    public partial class LabeledTextBox : UserControl
    {
        public event TextChangedEventHandler TextChanged;

        public LabeledTextBox()
        {
            InitializeComponent();
            _username.TextChanged += UsernameTextChanged;
            _password.PasswordChanged += PasswordPasswordChanged;
        }

        private void PasswordPasswordChanged(object sender, RoutedEventArgs e)
        {
        }

        private void UsernameTextChanged(object sender, TextChangedEventArgs e)
        {
        }

        public static readonly DependencyProperty LabelTextProperty = DependencyProperty.Register(
            "LabelText", typeof(string), typeof(LabeledTextBox), new PropertyMetadata(""));

        public string LabelText
        {
            get { return (string)_label.Content; }
            set { _label.Content = value; }
        }

        public static readonly DependencyProperty IsPasswordProperty = DependencyProperty.Register(
            "IsPassword", typeof(bool), typeof(LabeledTextBox), new PropertyMetadata(false));

        public bool IsPassword
        {
            get { return (bool)GetValue(IsPasswordProperty); }
            set {
                SetValue(IsPasswordProperty, value);
                if (IsPassword)
                {
                    _password.Visibility = Visibility.Visible;
                    _username.Visibility = Visibility.Collapsed;
                }
                else
                {
                    _password.Visibility = Visibility.Collapsed;
                    _username.Visibility = Visibility.Visible;
                }
            }
        }

        public string Text
        {
            get {
                if (!IsPassword)
                    return _username.Text;
                else
                    return _password.Password;
            }

            set
            {
                if (!IsPassword)
                    _username.Text = value;
                else
                    _password.Password = value;
            }
        }

    }
}
