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
using System.ComponentModel;

namespace MyProj
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        class SecondTIme : INotifyPropertyChanged
        {
            public int Second
            {
                get
                {
                    return DateTime.Now.Second;
                }
                set
                {
                    OnPropertyChanged("Second");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public void OnPropertyChanged(string propName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }

        public Page1()
        {
            InitializeComponent();

            label1.Content = DateTime.Now.ToString("ss");
            label2.Content = DateTime.Now.ToString("hh:mm");
            label3.Content = DateTime.Now.ToString("dddd");
            label4.Content = DateTime.Now.ToString("dd/M/yyyy");
            circularProgressBar1.Value = Convert.ToInt32(label1.Content);
        }
          

    }
}
