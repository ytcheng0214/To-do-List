using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.ObjectModel;

namespace TodoApp2
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> Tasks { get; } = new();

        public MainWindow()
        {
            InitializeComponent();
            TaskList.ItemsSource = Tasks;
            AddTaskButton.Click += AddTask;
            RemoveTaskButton.Click += RemoveTask;
        }

        private void AddTask(object? sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewTaskInput.Text))
            {
                Tasks.Add(NewTaskInput.Text);
                NewTaskInput.Text = "";
            }
        }

        private void RemoveTask(object? sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem is string selectedTask)
            {
                Tasks.Remove(selectedTask);
            }
        }
    }
}
