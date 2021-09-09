using System;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace TestForJob
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Open_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                ofd.Filter = "(*.xml)|*.xml";
                string inputpath = ofd.FileName;
                WorkWithCheque wwc = new WorkWithCheque(inputpath);
                wwc.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string inputpath = Directory.GetCurrentDirectory() + @"\Cheque.xml";
                WorkWithCheque wwc = new WorkWithCheque(inputpath);
                wwc.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
