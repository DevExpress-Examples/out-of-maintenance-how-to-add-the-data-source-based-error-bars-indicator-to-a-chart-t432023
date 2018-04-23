using System.Collections.Generic;
using System.Windows;

namespace DataSourceBasedErrorBars {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        List<DataItem> GetData() {
            return new List<DataItem>() {
                new DataItem("A", 20, 5, 8),
                new DataItem("B", 50, 3, 5),
                new DataItem("C", 40, 20, 10),
                new DataItem("D", 22, 15, 5),
                new DataItem("E", 30, 5, 8),
                new DataItem("F", 45, 5, 4),
                new DataItem("G", 35, 5, 3),
                new DataItem("H", 28, 4, 2),
                new DataItem("I", 46, 6, 4),
                new DataItem("J", 27, 8, 20),
                new DataItem("K", 20, 5, 8),
                new DataItem("L", 50, 3, 5),
                new DataItem("M", 40, 20, 10),
                new DataItem("N", 22, 15, 5),
                new DataItem("O", 30, 5, 8),
                new DataItem("P", 45, 5, 2),
                new DataItem("Q", 35, 5, 5),
            };
        }
        private void OnLoaded(object sender, RoutedEventArgs e) {
            if (pointSeries != null) {
                pointSeries.ArgumentDataMember = "Argument";
                pointSeries.ValueDataMember = "Value";
                pointSeries.DataSource = GetData();
            }
        }
    }
    public class DataItem {
        public string Argument { get; private set; }
        public int Value { get; private set; }
        public int Negative { get; private set; }
        public int Positive { get; private set; }
        public DataItem(string argument, int value, int negative, int positive) {
            Argument = argument;
            Value = value;
            Negative = negative;
            Positive = positive;
        }
    }
}
