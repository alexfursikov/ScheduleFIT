using System.Windows;
using System.Data.Entity;
using MyProj.Models;

namespace MyProj
{

    public partial class EditSubject : Window
    {
        UserContext db;
        public EditSubject()
        {
            InitializeComponent();
            db = new UserContext();
            db.Subject.Load();
            subGrid.ItemsSource = db.Subject.Local.ToBindingList();
            this.Closing += MainWindow_Closing;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (subGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < subGrid.SelectedItems.Count; i++)
                {
                    Subject subj = subGrid.SelectedItems[i] as Subject;
                    if (subj != null)
                    {
                        db.Subject.Remove(subj);
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
