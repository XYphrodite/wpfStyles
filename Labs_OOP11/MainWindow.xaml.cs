using Labs_OOP11.Models;
using System.ComponentModel;
using System.Windows;

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _toDoData.Clear();
        }
    }
}
