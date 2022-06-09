using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Form_updated
{
    public partial class Contacttracing : Form
    {
        public Contacttracing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void temperaturelbl_Click(object sender, EventArgs e)
        {

        }

        private void temperaturebx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Phenyang\source\repos\Contact Tracing Form_updated\Contacttracinginformation.txt", true);
            file.WriteLine("Date: " + datebx.Text);
            file.WriteLine("Time: " + timebx.Text);
            file.WriteLine("Temperature: " + temperaturebx.Text);
            file.WriteLine("First Name: " + namebx.Text);
            file.WriteLine("Middle Name: " + middlebx.Text);
            file.WriteLine("Last Name: " + lastbx.Text);
            file.WriteLine("Date of Birth: " + birthbx.Text);
            file.WriteLine("Age: " + agebx.Text);
            file.WriteLine("Email Address: " + emailbx.Text);
            file.WriteLine("Region: " + regionbx.Text);
            file.WriteLine("Province: " + provincebx.Text);
            file.WriteLine("Municipality: " + municipalitybx.Text);
            file.WriteLine("Barangay: " + barangaybx.Text);

            file.Close();
        }
    }
}
