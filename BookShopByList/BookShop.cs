using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopByList
{
    
    public partial class BookShop : Form
    {
        const int size = 100;
        List<string> customerNames = new List<string>(size);
        List<int> contactNumbers = new List<int>(size);
        List<string> addresses = new List<string>(size);
        List<string> orders = new List<string>(size);
        List<int> qualities = new List<int>(size);

        int index = 0;

       

        public BookShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerNames.Add(customerNameTextBox.Text);
            contactNumbers.Add(Convert.ToInt32(contactNoTextBox.Text));
            addresses.Add(addressTextBox.Text);
            orders.Add(orderComboBox.Text);
            qualities.Add(Convert.ToInt32(qualityTextBox.Text));

            showDetailsRichTextBox.SelectedText = "\n\t Customer Number ["+ index +"] Order Information: \n\n"
            + "\n Customer Name : " + customerNames[index] + "\n Contact No : "
            + contactNumbers[index] + "\n Address : " + addresses[index] + "\n Order: " + orders[index] +
            "\n Quality : " + qualities[index] + "\n";

            index++;

            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            qualityTextBox.Clear();
        }
    }
}
