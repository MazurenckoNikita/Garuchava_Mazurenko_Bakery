using System;
using System.Windows;
    
using Garuchava_Mazurenko_Bakery.Windows.ClientWindows;
namespace Garuchava_Mazurenko_Bakery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (loginTb.Text.Length > 0) 
            {
                if (PassTB.Password.Length > 0)       
                {              
                    
                    if (string.IsNullOrWhiteSpace(loginTb.Text))
                    {
                        MessageBox.Show("Пользователь авторизовался");     
                    }
                    else MessageBox.Show("Пользователя не найден");
                }
                else MessageBox.Show("Введите пароль"); 
            }
            else MessageBox.Show("Введите логин"); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowRegistration windowRegistration = new WindowRegistration();
            windowRegistration.Show();
            this.Close();   
        }

        private void loginTb_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            
        }

        private void loginTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginTb.Text == "Username")
            {
                loginTb.Clear();
            }
        }

        private void loginTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(loginTb.Text))
            {
                loginTb.Text = "Username";
            }
        }

        private void PassTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PassTB.Text == "Password")
            {
                PassTB.Clear();
            }
        }

        private void PassTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(PassTB.Text))
            {
                PassTB.Text = "Password";
            }
        }
    }
}


