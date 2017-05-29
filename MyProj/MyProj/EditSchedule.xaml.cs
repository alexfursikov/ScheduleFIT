using System.Windows;
using System.Data.Entity;
using System.Windows.Data;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using MyProj.Models;
using System;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Data;


namespace MyProj
{
    /// <summary>
    /// Логика взаимодействия для EditSchedule.xaml
    /// </summary>
    public partial class EditSchedule : Window, INotifyPropertyChanged
    {

        public ObservableCollection<Teacher> Teachers = new ObservableCollection<Teacher>();
        public ObservableCollection<Auditorium> Auditoriums = new ObservableCollection<Auditorium>();
        public ObservableCollection<Subject> Subjects = new ObservableCollection<Subject>();
        public ObservableCollection<Subject_Type> Subject_Types = new ObservableCollection<Subject_Type>();
        int x = 1;
        int y = 1;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private Teacher _teacher;
        private Subject _subject;
        private Auditorium _auditorium;
        private Subject_Type _subject_type;
        public Teacher SelectedTeacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                _teacher = value;
                OnPropertyChanged("SelectedTeacher");

            }
        }
        public Subject SelectedSubject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
                OnPropertyChanged("SelectedSubject");

            }
        }
        public Auditorium SelectedAuditorium
        {
            get
            {
                return _auditorium;
            }
            set
            {
                _auditorium = value;
                OnPropertyChanged("SelectedAuditorium");

            }
        }
        public Subject_Type SelectedSubject_Type
        {
            get
            {
                return _subject_type;
            }
            set
            {
                _subject_type = value;
                OnPropertyChanged("SelectedSubject_Type");

            }
        }
        XDocument xd = new XDocument();
        public EditSchedule()
        {

            this.DataContext = this;
            UserContext db;
            xd.Add(new XElement("schedule"));
            InitializeComponent();
            db = new UserContext();
            db.Teacher.Load();
            db.Subject.Load();
            db.Subject_Type.Load();
            db.Auditorium.Load();
            foreach (var item in db.Teacher.Local)
            {
                Teachers.Add(item);
            }

            foreach (var item in db.Auditorium.Local)
            {
                Auditoriums.Add(item);
            }

            foreach (var item in db.Subject.Local)
            {
                Subjects.Add(item);
            }
            foreach (var item in db.Subject_Type.Local)
            {
                Subject_Types.Add(item);
            }

            teachGrid.ItemsSource = Teachers;
            audGrid.ItemsSource = Auditoriums;
            subGrid.ItemsSource = Subjects;
            subJGrid.ItemsSource = Subject_Types;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 2; j <= 21; j++)
                {
                    Border border = new Border();
                    border.BorderThickness = new Thickness(1);
                    border.BorderBrush = Brushes.Black;
                    border.SetValue(Grid.RowProperty, i);
                    border.SetValue(Grid.ColumnProperty, j);
                    TextBlock tb = new TextBlock();
                    tb.FontSize = 5;
                    tb.TextWrapping = TextWrapping.Wrap;
                    tb.AllowDrop = true;
                    tb.Drop += txtTarget_Drop_1;
                    tb.MouseDown += txtTarget_MouseDown;
                    border.Child = tb; 
                    alex.Children.Add(border);
                }
            }
        }

        private void OpenTeach_Click(object sender, RoutedEventArgs e)
        {
            EditTeach eT = new EditTeach();
            eT.Show();
        }
        private void OpenSubject_Click(object sender, RoutedEventArgs e)
        {
            EditSubject eS = new EditSubject();
            eS.Show();
        }
        private void OpenAuditorium_Click(object sender, RoutedEventArgs e)
        {
            EditAuditorium eA = new EditAuditorium();
            eA.Show();
        }
        private void OpenSubjectType_Click(object sender, RoutedEventArgs e)
        {
            EditSubjectType eST = new EditSubjectType();
            eST.Show();
        }


        private void lbl2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock lbl = (TextBlock)sender;
            DragDrop.DoDragDrop(lbl, lbl.Text, DragDropEffects.Copy);
            XDocument a = XDocument.Load("Schedule for first week.xml");
            IEnumerable<XElement> elements = a.Descendants("group");
            a.Element("schedule").Element("day").Element("times").Element("group").Value = lbl.Text;
            if (csc.IsChecked == false)
            {
                a.Save("1.xml");
            }
            if (csc.IsChecked == true)
            {
                a.Save("2.xml");
            }


        }

        private void txtTarget_Drop_1(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
        }
        private void txtTarget_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (csc.IsChecked==true)
            {
                    for (int i = 1; i <= 30; i++)
                    {
                        for (int j = 2; j <= 21; j++)
                        {
                            Border bordex = new Border();
                            bordex.BorderThickness = new Thickness(1);
                            bordex.BorderBrush = Brushes.Black;
                            bordex.SetValue(Grid.RowProperty, i);
                            bordex.SetValue(Grid.ColumnProperty, j);
                            TextBlock tb1 = new TextBlock();
                            tb1.FontSize = 5;
                            tb1.TextWrapping = TextWrapping.Wrap;
                            tb1.AllowDrop = true;
                            tb1.Drop += txtTarget_Drop_1;
                            tb1.MouseDown += txtTarget_MouseDown;
                            bordex.Child = tb1;
                            alex1.Children.Add(bordex);
                    }

                    alex1.Visibility = Visibility.Visible;
                    alex.Visibility = Visibility.Hidden;
                }
            }
            if (csc.IsChecked== false)
            {
                alex1.Visibility = Visibility.Hidden;
                alex.Visibility = Visibility.Visible;
            }
        }

        private void txtTarget_PreviewDrop(object sender, DragEventArgs e)
        {

        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.Filter = "XML-Document (.xml)|*.xml";
            if (ofd.ShowDialog() == true)
            {
                string filename = ofd.FileName;
            }
        }

        private void Exp_Click(object sender, RoutedEventArgs e)
        { 
            for (int q = 1; q <= 6; q++)
            {
                XElement day = new XElement("day");
                XAttribute dayID = new XAttribute("dayValue", "Понедельник");
                if (q== 2)
                {
                    dayID.Value = "Вторник";
                }
                if (q == 3)
                {
                    dayID.Value = "Среда";
                }
                if (q == 4)
                {
                    dayID.Value = "Четверг";
                }
                if (q == 5)
                {
                    dayID.Value = "Пятница";
                }
                if (q == 6)
                {
                    dayID.Value = "Суббота";
                }
                day.Add(dayID);
                for (int w = 1; w <= 5; w++)
                {
                    XElement time = new XElement("times");
                    XAttribute timeValue = new XAttribute("timeValue","8.00-9.35");
                    if (w == 2)
                    {
                        timeValue.Value = "9.50-11.25";
                    }
                    if (w == 3)
                    {
                        timeValue.Value = "11.40-13.15";
                    }
                    if (w == 4)
                    {
                        timeValue.Value = "13.50-15.25";
                    }
                    if (w == 5)
                    {
                        timeValue.Value = "15.40-17.15";
                    }
                    time.Add(timeValue);
                    for (int r = 1; r <= 20; r++)
                    {
                        if (x > 10)
                        {
                            x = 1;
                        }
                        if (y > 2)
                        {
                            y = 1;
                        }
                        XElement group = new XElement("group");
                        XAttribute groupID = new XAttribute("groupID", x++);
                        XAttribute podgroupID = new XAttribute("podgroupID", y++);
                        group.Add(groupID);
                        group.Add(podgroupID);
                        time.Add(group);
                    }
                    day.Add(time);
                }

                xd.Root.Add(day);
            }
            if (csc.IsChecked == false)
            {

                xd.Save("Schedule for first week.xml");
            }
            if (csc.IsChecked == true)
            {
                xd.Save("Schedule for second week.xml");
            }
        }
    }
}
