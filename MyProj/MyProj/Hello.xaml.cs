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
using System.Data.SqlClient;

namespace MyProj
{
    /// <summary>
    /// Логика взаимодействия для Hello.xaml
    /// </summary>
    public partial class Hello : Window
    {
        public static int q;
        public Hello()
        {
            InitializeComponent();

        }
        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "Login")
            {

                if (textBox.Text != "")
                {

                    textBox.Text = "";
                    textBox.Foreground = new SolidColorBrush(Color.FromRgb(255, 228, 196));
                }
            }
        }
        private void textBox_LostFocus(object sender,RoutedEventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Login";
            }
        }
        void ShowPassword()
        {
            Visibilitybox.Visibility = Visibility.Visible;
            passwordBox.Visibility = Visibility.Hidden;
            Visibilitybox.Text = passwordBox.Password;
        }
        void HidePassword()
        {
            Visibilitybox.Visibility = Visibility.Hidden;
            passwordBox.Visibility = Visibility.Visible;
            passwordBox.Focus();
        }

        private void ImageShowHide_PreviewMouseDown(object sender, RoutedEventArgs e)
        {
            ShowPassword();
        }
        private void ImageShowHide_PreviewMouseUp(object sender, RoutedEventArgs e)
        {
            HidePassword();
        }
        private void ImageShowHide_MouseLeave(object sender, RoutedEventArgs e)
        {
            HidePassword();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            q = 1;
            SqlConnection myBase = new SqlConnection("Data Source = LENOVO-PC\\SQLEXPRESS; Initial Catalog = Курсач; Integrated Security = True");
            myBase.Open();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM LOG WHERE LOGIN='"+textBox.Text+"'AND PASSWORD='"+passwordBox.Password+"'",myBase );
            SqlDataReader myDataReader;
            myDataReader = myCommand.ExecuteReader();
            int count = 0;
            while (myDataReader.Read())
            {
                count += 1;
    
            }
            if (count == 1)
            {
                this.Close();
                
            }
            else {
                pLink.IsOpen = true;
                 }

        }
    }
}
