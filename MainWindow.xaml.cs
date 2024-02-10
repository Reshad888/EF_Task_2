using EF_Task_2.Contexts;
using EF_Task_2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace EF_Task_2
{
    public partial class MainWindow : Window
    {
        LibraryDbContext libraryDbContext = new LibraryDbContext();

        public MainWindow()
        {
            InitializeComponent();

            EntityComboBox.Items.Add("Authors");
            EntityComboBox.Items.Add("Books");
            EntityComboBox.Items.Add("Categories");
            EntityComboBox.Items.Add("Departments");
            EntityComboBox.Items.Add("Faculties");
            EntityComboBox.Items.Add("Groups");
            EntityComboBox.Items.Add("Libs");
            EntityComboBox.Items.Add("Press");
            EntityComboBox.Items.Add("S_Cards");
            EntityComboBox.Items.Add("Students");
            EntityComboBox.Items.Add("T_Cards");
            EntityComboBox.Items.Add("Teachers");
            EntityComboBox.Items.Add("Themes");
        }

        private void ButtonSelect_Click(object sender, RoutedEventArgs e)
        {
            string selectedTable = EntityComboBox.SelectedItem as string;

            switch (selectedTable)
            {
                case "Authors":
                    DataGridView.ItemsSource = libraryDbContext.Authors.ToList();
                    break;
                case "Themes":
                    DataGridView.ItemsSource = libraryDbContext.Themes.ToList();
                    break;
                case "Press":
                    DataGridView.ItemsSource = libraryDbContext.Press.ToList();
                    break;
                case "Categories":
                    DataGridView.ItemsSource = libraryDbContext.Categories.ToList();
                    break;
                case "Books":
                    DataGridView.ItemsSource = libraryDbContext.Books.ToList();
                    break;
                case "Departments":
                    DataGridView.ItemsSource = libraryDbContext.Departments.ToList();
                    break;
                case "Faculties":
                    DataGridView.ItemsSource = libraryDbContext.Faculties.ToList();
                    break;
                case "Groups":
                    DataGridView.ItemsSource = libraryDbContext.Groups.ToList();
                    break;
                case "Libs":
                    DataGridView.ItemsSource = libraryDbContext.Libs.ToList();
                    break;
                case "S_Cards":
                    DataGridView.ItemsSource = libraryDbContext.S_Cards.ToList();
                    break;
                case "Students":
                    DataGridView.ItemsSource = libraryDbContext.Students.ToList();
                    break;
                case "T_Cards":
                    DataGridView.ItemsSource = libraryDbContext.T_Cards.ToList();
                    break;
                case "Teachers":
                    DataGridView.ItemsSource = libraryDbContext.Teachers.ToList();
                    break;
            }
        }

        private void DataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonUpdate_Click(sender, e);
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            libraryDbContext.SaveChanges();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            string selectedTable = EntityComboBox.SelectedItem as string;

            int.TryParse(textBox.Text, out int id);

            switch (selectedTable)
            {
                case "Authors":
                    var delA = libraryDbContext.Authors.FirstOrDefault(a => a.Id == id);
                    libraryDbContext.Authors.Remove(delA);
                    libraryDbContext.SaveChanges();
                    break;
                case "Themes":
                    var delTh = libraryDbContext.Themes.FirstOrDefault(t => t.Id == id);
                    libraryDbContext.Themes.Remove(delTh);
                    libraryDbContext.SaveChanges();
                    break;
                case "Press":
                    var delP = libraryDbContext.Press.FirstOrDefault(p => p.Id == id);
                    libraryDbContext.Press.Remove(delP);
                    libraryDbContext.SaveChanges();
                    break;
                case "Categories":
                    var delC = libraryDbContext.Categories.FirstOrDefault(c => c.Id == id);
                    libraryDbContext.Categories.Remove(delC);
                    libraryDbContext.SaveChanges();
                    break;
                case "Books":
                    var delB = libraryDbContext.Books.FirstOrDefault(b => b.Id == id);
                    libraryDbContext.Books.Remove(delB);
                    libraryDbContext.SaveChanges();
                    break;
                case "Departments":
                    var delD = libraryDbContext.Departments.FirstOrDefault(d => d.Id == id);
                    libraryDbContext.Departments.Remove(delD);
                    libraryDbContext.SaveChanges();
                    break;
                case "Faculties":
                    var delF = libraryDbContext.Faculties.FirstOrDefault(f => f.Id == id);
                    libraryDbContext.Faculties.Remove(delF);
                    libraryDbContext.SaveChanges();
                    break;
                case "Groups":
                    var delG = libraryDbContext.Groups.FirstOrDefault(g => g.Id == id);
                    libraryDbContext.Groups.Remove(delG);
                    libraryDbContext.SaveChanges();
                    break;
                case "Libs":
                    var delL = libraryDbContext.Libs.FirstOrDefault(l => l.Id == id);
                    libraryDbContext.Libs.Remove(delL);
                    libraryDbContext.SaveChanges();
                    break;
                case "S_Cards":
                    var delSC = libraryDbContext.S_Cards.FirstOrDefault(sc => sc.Id == id);
                    libraryDbContext.S_Cards.Remove(delSC);
                    libraryDbContext.SaveChanges();
                    break;
                case "Students":
                    var delS = libraryDbContext.Students.FirstOrDefault(s => s.Id == id);
                    libraryDbContext.Students.Remove(delS);
                    libraryDbContext.SaveChanges();
                    break;
                case "T_Cards":
                    var delTC = libraryDbContext.T_Cards.FirstOrDefault(tc => tc.Id == id);
                    libraryDbContext.T_Cards.Remove(delTC);
                    libraryDbContext.SaveChanges();
                    break;
                case "Teachers":
                    var delTe = libraryDbContext.Teachers.FirstOrDefault(t => t.Id == id);
                    libraryDbContext.Teachers.Remove(delTe);
                    libraryDbContext.SaveChanges();
                    break;
            }
        }
    }
}