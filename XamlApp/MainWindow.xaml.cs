using OfficeOpenXml.FormulaParsing.ExcelUtilities;
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

namespace XamlApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            int But0 = 0;
            Screen.Text += But0.ToString();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int But1 = 1;
            Screen.Text += But1.ToString();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int But2 = 2;
            Screen.Text += But2.ToString();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int But3 = 3;
            Screen.Text += But3.ToString();
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int But4 = 4;
            Screen.Text += But4.ToString();
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            int But5 = 5;
            Screen.Text += But5.ToString();
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            int But6 = 6;
            Screen.Text += But6.ToString();
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            int But7 = 7;
            Screen.Text += But7.ToString();
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            int But8 = 8;
            Screen.Text += But8.ToString();
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            int But9 = 9;
            Screen.Text += But9.ToString();
        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            String ButAdd = "+";
            Screen.Text += ButAdd.ToString();
        }
        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            String ButSub = "-";
            Screen.Text += ButSub.ToString();
        }
        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            String ButMul = "*";
            Screen.Text += ButMul.ToString();
        }
        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            String ButDiv = "/";
            Screen.Text += ButDiv.ToString();
        }
        private void ButtonEqu_Click(object sender, RoutedEventArgs e)
        {

            int i = Int32.Parse(Screen.Text);
            string j = i.ToString();
            MessageBox.Show(j);
        }
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            Screen.Text = "";
        }

    }
}
