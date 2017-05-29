using System.Windows;
using System.Data.Entity;
using MyProj.Models;

namespace MyProj
{

    public partial class EditAuditorium : Window
    {
        UserContext db;
        public EditAuditorium()
        {
            InitializeComponent();
            db = new UserContext();
            db.Auditorium.Load();
            audGrid.ItemsSource = db.Auditorium.Local.ToBindingList();
            this.Closing += MainWindow_Closing;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (audGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < audGrid.SelectedItems.Count; i++)
                {
                    Auditorium audit = audGrid.SelectedItems[i] as Auditorium;
                    if (audit != null)
                    {
                        db.Auditorium.Remove(audit);
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
