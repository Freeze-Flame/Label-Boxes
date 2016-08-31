using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Demo_1
{
    public partial class TimeZones : Form
    {
        public TimeZones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city;

            // Get the city that was selected
            city = lbxCities.SelectedItem.ToString();

            // Switch based on the city selected
            switch(city)
            {
                case "Honolulu":
                    lblTimeZone.Text = "Hawdi-Aleutian";
                    break;
                case "San Francisco":
                case "Los Angeles":
                    lblTimeZone.Text = "Pacific";
                    break;
                case "Denver":
                case "Misueahvasoa":
                    lblTimeZone.Text = "Mountain";
                    break;
                case "Minneapolis":
                case "Chicago":
                    lblTimeZone.Text = "Central";
                    break;
                case "New York":
                    lblTimeZone.Text = "Eastern";
                    break;
                default:
                    MessageBox.Show("City Not Found", "City Lost",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
