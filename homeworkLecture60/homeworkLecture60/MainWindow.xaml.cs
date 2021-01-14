using System;
using System.Collections.Generic;
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

namespace homeworkLecture60
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(txtIncome.Text);
            int expenses = int.Parse(txtExpenses.Text);
            int target = int.Parse(txtSaving.Text);
            int saving = income - expenses;
            int result = target / saving;

            txtResult.Text = result.ToString();

            MessageBox.Show(result.ToString() + " day (s)");
        }
    }
}
