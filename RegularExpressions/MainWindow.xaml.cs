using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegularExpressions
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string name = "[A-Za-z]";
            string whitespace = @"\s";

            //string pattern = "^(" + name + whitespace "*)+$";

            if (!Regex.IsMatch(txtName.Text, @"^([A-Za-z]+\s*)+$"))
                MessageBox.Show("The name is invalid (only aplhabetgical characters are allowed)");

            //if (!Regex.IsMatch(txtName.Text, @"^([A-Za-z]+\s*)+$"))
            //    MessageBox.Show("The name is invalid (only aplhabetgical characters are allowed)");


            //if (!Regex.IsMatch(txtPhone.Text, @"^(\+[0-9]{11})$"))
            //    MessageBox.Show("The phone is invalid ");
            string formattedPhoneNum = formatPhoneNumber(txtPhone.Text);

            if (!Regex.IsMatch(formattedPhoneNum, @"_^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$_"))
                MessageBox.Show("The phone is invalid ");

            if (!Regex.IsMatch(txtEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                MessageBox.Show("The email is invalid ");
        }

        private string formatPhoneNumber(string phoneNumberString)
        {
            MessageBox.Show(String.Format("{0:(###) ###-####}", Int64.Parse(phoneNumberString)));
            return String.Format("{0:(###) ###-####}", Int64.Parse(phoneNumberString));
        }

        


    }

    public class Validation {
        

        public bool phoneNumberValidation(string name)
        {
            if (!Regex.IsMatch(name, @"^([A-Za-z]+\s*)+$"))
                MessageBox.Show("The name is invalid (only aplhabetgical characters are allowed)");
            else
            {
                return true;
            }
            return false;
        }
    }
}
