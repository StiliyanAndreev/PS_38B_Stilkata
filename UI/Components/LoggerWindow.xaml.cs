using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace UI.Components
{
    public partial class LoggerWindow : Window
    {
        public LoggerWindow(List<LogEntry> logs)
        {
            InitializeComponent();
            loggerGrid.ItemsSource = logs;
        }

        private void LoggerGrid_DoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (loggerGrid.SelectedItem is LogEntry log)
            {
                MessageBox.Show($"Event: {log.Event}\nTime: {log.Timestamp}", "Event Details", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }

    public class LogEntry
    {
        public string Event { get; set; }
        public string Timestamp { get; set; }
    }
}
