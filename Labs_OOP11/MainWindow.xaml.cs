using Labs_OOP11.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Labs_OOP11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<ToDoModel> _toDoData;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _toDoData = new BindingList<ToDoModel>()
             {
                 new ToDoModel(){Text="Доделать лабораторную с wpf",IsDone=true,Priority="High"},
                 new ToDoModel() { Text = "Почистить зубы",IsDone=true,Priority="Normal" }
            };
            choresList.ItemsSource = _toDoData;
        }
    }
}
