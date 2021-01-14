using System;
using System.Collections;
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

namespace Lecture84_ArrayList_Nics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(inputTxt.Text);
            MessageBox.Show("Added: " + inputTxt.Text + " [DONE]");
            inputTxt.Text = "";
            arrayList.Sort();
        }

        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(inputTxt.Text);
            MessageBox.Show("Removed: " + inputTxt.Text + " [DONE]");
            inputTxt.Text = "";
            arrayList.Sort();
        }

        private void buttonShowAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }

            MessageBox.Show("Count = " + arrayList.Count.ToString());
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Clear();
            MessageBox.Show("All Cleared");
        }
    }
}
