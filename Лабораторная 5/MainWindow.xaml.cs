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

namespace Лабораторная_5
{
   
    public partial class MainWindow : Window
    {
        Currency currency = new Currency();
        Account account = new Account();
        int selected = 0;
        int selected1 = 0;
        double MoneyAdd = 0;

        public MainWindow()
        {
            
            InitializeComponent();
            TxtBox1.Text = Convert.ToString(account.Money);
            TxtBox2.Text = "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            account.Money = Convert.ToDouble(TxtBox1.Text);
            TxtBox1.Text = Convert.ToString(rec(account.Money, ComboBox2.SelectedIndex) + Convert.ToDouble(TxtBox2.Text));
            selected = ComboBox2.SelectedIndex;
            ComboBox1.SelectedIndex = ComboBox2.SelectedIndex;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            account.Money = Convert.ToDouble(TxtBox1.Text);

            if (ComboBox1.SelectedIndex == 0)
            {
                
                TxtBox1.Text = Convert.ToString(rec(account.Money, 0));
                selected = 0;
            }
            else if((ComboBox1.SelectedIndex == 1)&&(ComboBox1.SelectedIndex != selected))
            {
                
                TxtBox1.Text = Convert.ToString(rec(account.Money, 1));
                selected = 1;
            }
            else if ((ComboBox1.SelectedIndex == 2) && (ComboBox1.SelectedIndex != selected))
            {

                TxtBox1.Text = Convert.ToString(rec(account.Money,2));
                selected = 2;
            }


        }

        public double rec(double mon, int a)
        {
            if (a != 0)
            {
                mon = rec(mon, 0);
            }
            else
            {
                if (selected == 1)
                {
                    currency.EUR = mon;
                    mon = mon * 90.64;
                }
                else if (selected == 2)
                {
                    mon = mon * 103.98;
                }
            }

            if (a == 1)
            {
                currency.EUR = mon;
                return currency.EUR;
            }
            else if (a == 2)
            {
                currency.GBP = mon;
                return currency.GBP;
            }
            return mon;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            MoneyAdd = Convert.ToDouble(TxtBox2.Text);

            if (ComboBox2.SelectedIndex == 0)
            {

                TxtBox2.Text = Convert.ToString(rec(MoneyAdd, 0));
                selected1 = 0;
            }
            else if ((ComboBox2.SelectedIndex == 1) && (ComboBox2.SelectedIndex != selected))
            {

                TxtBox2.Text = Convert.ToString(rec(MoneyAdd, 1));
                selected1 = 1;
            }
            else if ((ComboBox2.SelectedIndex == 2) && (ComboBox2.SelectedIndex != selected))
            {

                TxtBox2.Text = Convert.ToString(rec(MoneyAdd, 2));
                selected1 = 2;
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            account.Money = Convert.ToDouble(TxtBox1.Text);
            if(rec(account.Money, ComboBox2.SelectedIndex) >= Convert.ToDouble(TxtBox2.Text))
            {
                TxtBox1.Text = Convert.ToString(rec(account.Money, ComboBox2.SelectedIndex) - Convert.ToDouble(TxtBox2.Text));
                selected = ComboBox2.SelectedIndex;
                ComboBox1.SelectedIndex = ComboBox2.SelectedIndex;
            }
            
        }
    }
}
