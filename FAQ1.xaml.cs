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
using System.Windows.Shapes;

namespace t
{
    /// <summary>
    /// Interaction logic for FAQ1.xaml
    /// </summary>
    public partial class FAQ1 : Window
    {
        public FAQ1()
        {
            InitializeComponent();
        }
        int oldvalue = 0;
        int ans = 0;
 
        private object checkBoxclick;

        private void First_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll1.Content);
            if(checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll1.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;


        }

        private void Second_Checked(object sender, RoutedEventArgs e)
        {
       
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll2.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll2.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }

        private void Third_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.  ToInt32(lbll3.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll3.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }

        private void Fourth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll4.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll4.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }

        private void Sixth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll6.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll6.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }

        private void Seventh_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll7.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll7.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }

        private void Eighth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll8.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll8.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }

        private void Nineth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll9.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll9.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }

        private void Tenth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll10.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll10.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }

        private void Btnfinish_Click(object sender, RoutedEventArgs e)
        {
            int value1 = Convert.ToInt32(lbll1.Content);
            int value2 = Convert.ToInt32(lbll2.Content);
            int value3 = Convert.ToInt32(lbll3.Content);
            int value4 = Convert.ToInt32(lbll4.Content);
            int value5 = Convert.ToInt32(lbll5.Content);
            int value6 = Convert.ToInt32(lbll6.Content);
            int value7 = Convert.ToInt32(lbll7.Content);
            int value8 = Convert.ToInt32(lbll8.Content);
            int value9 = Convert.ToInt32(lbll9.Content);
            int value10 = Convert.ToInt32(lbll10.Content);

            int value = value1 + value2 + value3 + value4 + value5 + value6 + value7 + value8 + value9 + value10;
            lblfinish.Content = Convert.ToString(value);

            if(value<500)
            {
                MessageBox.Show("Your score is " + value + " (Sorry you are not qualified)");
            }
            else
            {
                MessageBox.Show("Your score is " + value + " (You are qualified)");
            }
        }

        private void Fifth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbll5.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue = oldvalue + 100;
            }
            else
            {
                oldvalue = oldvalue - 100;
            }
            lbll5.Content = oldvalue.ToString();
            checkBoxclick.IsEnabled = false;

        }
    }
    
}