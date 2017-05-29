using System.Windows;
using System.Data.Entity;
using System.Windows.Data;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Windows.Input;
using System.IO;
using System.Data;
using System;
using MyProj.Models;

namespace MyProj
{
    /// <summary>
    /// Логика взаимодействия для AddTask.xaml
    /// </summary>
    public partial class AddTask : Page, INotifyPropertyChanged
    {
        public ObservableCollection<Subject> Subjects = new ObservableCollection<Subject>();
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private Subject _subject;
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
        int taskID = 1;
        XDocument xd = new XDocument();
        // XDocument xdoc = XDocument.Load("tasks.xml");

        public AddTask()
        {
            UserContext db;
            InitializeComponent();
            db = new UserContext();
            db.Subject.Load();
            foreach (var item in db.Subject.Local)
            {
                Subjects.Add(item);
            }
            comboBox1.ItemsSource = Subjects;
            xd.Add(new XElement("tasks"));

            if (File.Exists("tasks.xml"))
            {
                XDocument xdoc = XDocument.Load("tasks.xml");
                foreach (XElement subj in xdoc.Element("tasks").Elements("task"))
                {
                    XElement header = subj.Element("header");
                    XAttribute taski = subj.Attribute("taskID");
                    XElement description = subj.Element("description");
                    XElement dateT = subj.Element("date");
                    XElement sub = subj.Element("subject");
                    las.Content = taski.Value;
                    if (taski.Value != null)
                    {
                        Label lb2 = new Label()
                        {
                            Content = dateT.Value
                        };
                        lb2.HorizontalContentAlignment = HorizontalAlignment.Center;
                        lb2.VerticalContentAlignment = VerticalAlignment.Top;
                        lb2.Width = 320;
                        Container.Children.Add(lb2);

                        Label lb1 = new Label()
                        {
                            Content = sub.Value.Trim()
                        };
                        lb1.Background = Brushes.OrangeRed;
                        lb1.FontWeight = FontWeights.DemiBold;
                        lb1.HorizontalAlignment = HorizontalAlignment.Left;
                        lb1.VerticalAlignment = VerticalAlignment.Top;

                        Container.Children.Add(lb1);

                        Label lb3 = new Label()
                        {
                            Content = header.Value
                        };
                        lb3.Foreground = Brushes.Black;
                        lb3.FontWeight = FontWeights.DemiBold;

                        Container.Children.Add(lb3);
                    }
                }
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (zagolovok.Text == "Новая задача")
            {

                if (zagolovok.Text != "")
                {

                    zagolovok.Text = "";
                    zagolovok.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                }
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (zagolovok.Text == "")
            {
                zagolovok.Text = "Новая задача";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("tasks.xml"))
            {
                XDocument xdoc = XDocument.Load("tasks.xml");
              
               

                XElement tasks1 = new XElement("tasks");
                XElement task1 = new XElement("task");
                XElement header1 = new XElement("header", zagolovok.Text);
                XElement description1 = new XElement("description", opisanie.Text);
                XElement dateT1 = new XElement("date", date.Text);
                XElement subj1 = new XElement("subject", comboBox1.Text);
                XAttribute taskid1 = new XAttribute("taskID", taskID++);
                task1.Add(taskid1);
                task1.Add(header1);
                task1.Add(description1);
                task1.Add(dateT1);
                task1.Add(subj1);
                tasks1.Add(task1);

                xdoc.Root.Add(task1);
                xdoc.Save("tasks.xml");
                zagolovok.Text = "Новая задача";
                opisanie.Text = "";
                date.Text = "";
                comboBox1.Text = "АЛОЦВМ";

            }
            else
            {
                XElement tasks = new XElement("tasks");
                XElement task = new XElement("task");
                XElement header = new XElement("header", zagolovok.Text);
                XElement description = new XElement("description", opisanie.Text);
                XElement dateT = new XElement("date", date.Text);
                XElement subj = new XElement("subject", comboBox1.Text);
                XAttribute taskid = new XAttribute("taskID", taskID++);
                task.Add(taskid);
                task.Add(header);
                task.Add(description);
                task.Add(dateT);
                task.Add(subj);
                tasks.Add(task);

                xd.Root.Add(task);
                xd.Save("tasks.xml");

                zagolovok.Text = "Новая задача";
                opisanie.Text = "";
                date.Text = "";
                comboBox1.Text = "АЛОЦВМ";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Container.Children.Count != 0)
            {
                Container.Children.Clear();
            }
            if (File.Exists("tasks.xml")) { 
                XDocument xdoc = XDocument.Load("tasks.xml");
                foreach (XElement subj in xdoc.Element("tasks").Elements("task"))
                {
                    XElement header = subj.Element("header");
                    XAttribute taski = subj.Attribute("taskID");
                    XElement description = subj.Element("description");
                    XElement dateT = subj.Element("date");
                    XElement sub = subj.Element("subject");
                    las.Content = taski.Value;

                    if (taski.Value != null)
                    {
                        Label lb2 = new Label()
                        {
                            Content = dateT.Value
                        };
                        lb2.HorizontalContentAlignment = HorizontalAlignment.Center;
                        lb2.VerticalContentAlignment = VerticalAlignment.Top;
                        lb2.Width = 320;
                        Container.Children.Add(lb2);

                        Label lb1 = new Label()
                        {
                            Content = sub.Value.Trim()
                        };
                        lb1.Background = Brushes.OrangeRed;
                        lb1.FontWeight = FontWeights.DemiBold;
                        lb1.HorizontalAlignment = HorizontalAlignment.Left;
                        lb1.VerticalAlignment = VerticalAlignment.Top;

                        Container.Children.Add(lb1);

                        Label lb3 = new Label()
                        {
                            Content = header.Value
                        };
                        lb3.Foreground = Brushes.Black;
                        lb3.FontWeight = FontWeights.DemiBold;

                        Container.Children.Add(lb3);

                    }
                }
            }
        }
    }
}