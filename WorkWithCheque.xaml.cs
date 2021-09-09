using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace TestForJob
{
    public partial class WorkWithCheque : Window
    {
        string savepath;
        public List<Cheque> ch = new List<Cheque>();
        public WorkWithCheque(string inputpath)
        {
            try
            {
                InitializeComponent();
                savepath = inputpath;
                if (File.Exists(inputpath))
                {
                    Serialization serialization = new Serialization();
                    ch = serialization.Deserializator(inputpath);
                    dg.ItemsSource = ch;
                }
                else
                {
                    dg.ItemsSource = ch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void Save_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                XmlSerializer formatter = new XmlSerializer(typeof(List<Cheque>));
                using (FileStream fs = new FileStream(savepath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, ch);
                }
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}