﻿using System;
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
                    DataTable dt_user = mainWindow.Select("SELECT * FROM [DB_Garuchava_Mazurenko_Bakery]. WHERE [login] = '" + loginTb.Text + "' AND [password] = '" + PassTB.Password + "'");
                    if (dt_user.Rows.Count > 0)
                    {
                        MessageBox.Show("Пользователь авторизовался");     
                    }
                    else MessageBox.Show("Пользователя не найден");
                }
                else MessageBox.Show("Введите пароль"); 
            }
            else MessageBox.Show("Введите логин"); 
        }
    }
    }


