using System.Windows;
using System.Data.Entity;
using MyProj.Models;

namespace MyProj
{

    public partial class EditSubjectType : Window
    {
        UserContext db;
        public EditSubjectType()
        {
            InitializeComponent();
            db = new UserContext();
            db.Subject_Type.Load();
            subJGrid.ItemsSource = db.Subject_Type.Local.ToBindingList();
            this.Closing += MainWindow_Closing;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (subJGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < subJGrid.SelectedItems.Count; i++)
                {
                    Subject_Type subj = subJGrid.SelectedItems[i] as Subject_Type;
                    if (subj != null)
                    {
                        db.Subject_Type.Remove(subj);
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
