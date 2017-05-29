using System.Windows;
using System.Data.Entity;
using MyProj.Models;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
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

namespace MyProj
{

    public partial class EditTeach : Window
    {
        UserContext db;
        public EditTeach()
        {
            InitializeComponent();
            db = new UserContext();
            db.Teacher.Load();
            teachGrid.ItemsSource = db.Teacher.Local.ToBindingList();
            this.Closing += MainWindow_Closing;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
           
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (teachGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < teachGrid.SelectedItems.Count; i++)
                {
                    Teacher teach = teachGrid.SelectedItems[i] as Teacher;
                    if (teach != null)
                    {
                        db.Teacher.Remove(teach);
                    }
                }
            }
            db.SaveChanges();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
    }
}
