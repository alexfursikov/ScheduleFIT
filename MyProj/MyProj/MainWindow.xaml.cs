using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
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
using System.IO;
using Microsoft.Win32;
using System.ComponentModel;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Data;
using MyProj.Models;


namespace MyProj
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

       

        private void EditSchedule_Click(object sender, RoutedEventArgs e)
        {
            EditSchedule edSch = new EditSchedule();
            edSch.Show();
            
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void csc_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Hello.q == 0)
            {
               
                EditSchedule.Visibility = Visibility.Hidden;
            }
        }

        private void csc_Checked(object sender, RoutedEventArgs e)
        {
            Hello hello = new Hello();
            hello.ShowDialog();
            if (Hello.q == 1)
            {
            
                EditSchedule.Visibility = Visibility.Visible;
                Hello.q = 0;
            }
            
        }
    }

}
