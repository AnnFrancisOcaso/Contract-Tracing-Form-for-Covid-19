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
            file.WriteLine("Contact No.: " + contactbx.Text);
            file.WriteLine("Email Address: " + emailbx.Text);
            file.WriteLine("Region: " + regionbx.Text);
            file.WriteLine("Province: " + provincebx.Text);
            file.WriteLine("Municipality: " + municipalitybx.Text);
            file.WriteLine("Barangay: " + barangaybx.Text);

            String feverAnswer = "";
            if (feveryesrb.Checked)
            {
                feverAnswer = feveryesrb.Text;
                file.WriteLine("Do you have a fever? " + "Yes");
            }

            if (feverNorb.Checked)
            {
                feverAnswer = feverNorb.Text;
                file.WriteLine("Do you have a fever?" + "No");
            }

            //radiobutton select yes or no
                //Do you have a dry cough?
            String coughAnswer = "";
            if (coughYesrb.Checked)
            {
                coughAnswer = coughYesrb.Text;
                file.WriteLine("Do you have a dry cough? " + "Yes");
            }

            if (coughNorb.Checked)
            {
                coughAnswer = coughNorb.Text;
                file.WriteLine("Do you have a dry cough? " + "No");
            }

            //Do you have runny nose? 
            String noseAnswer = "";
            if (noseYesrb.Checked)
            {
                noseAnswer = noseYesrb.Text;
                file.WriteLine("Do you have runny nose? " + "Yes");
            }

            if (noseNorb.Checked)
            {
                noseAnswer = noseNorb.Text;
                file.WriteLine("Do you have runny nose? " + "No");
            }

            //Do you have sore throat?
            String soreAnswer = "";
            if (noseYesrb.Checked)
            {
                soreAnswer = soreYesrb.Text;
                file.WriteLine("Do you have sore throat? " + "Yes");
            }

            if (soreNorb.Checked)
            {
                soreAnswer = soreNorb.Text;
                file.WriteLine("Do you have sore throat? " + "No");
            }

            //Do you experience fatigue?
            String fatigueAnswer = "";
            if (fatigueYesrb.Checked)
            {
                fatigueAnswer = fatigueYesrb.Text;
                file.WriteLine("Do you experience fatigue? " + "Yes");
            }

            if (fatigueNorb.Checked)
            {
                fatigueAnswer = fatigueNorb.Text;
                file.WriteLine("Do you experience fatigue? " + "No");
            }

            //Do you experience headache?
            String headAnswer = "";
            if (headYesrb.Checked)
            {
                headAnswer = headYesrb.Text;
                file.WriteLine("Do you experience headache? " + "Yes");
            }

            if (headNorb.Checked)
            {
                headAnswer = headNorb.Text;
                file.WriteLine("Do you experience headache? " + "No");
            }

            //Do you experience diarrhea?
            String diarrheaAnswer = "";
            if (diarrheaYesrb.Checked)
            {
                diarrheaAnswer = diarrheaYesrb.Text;
                file.WriteLine("Do you experience diarrhea? " + "Yes");
            }

            if (diarrheaNorb.Checked)
            {
                diarrheaAnswer = diarrheaNorb.Text;
                file.WriteLine("Do you experience diarrhea? " + "No");
            }

            //Do you experience body ache?
            String bodyAnswer = "";
            if (diarrheaYesrb.Checked)
            {
                bodyAnswer = bodyYesrb.Text;
                file.WriteLine("Do you experience body ache? " + "Yes");
            }

            if (bodyNorb.Checked)
            {
                bodyAnswer = bodyNorb.Text;
                file.WriteLine("Do you experience body ache? " + "No");
            }

            //Do you experience shortness of breath?
            String breathAnswer = "";
            if (breathYesrb.Checked)
            {
                breathAnswer = breathYesrb.Text;
                file.WriteLine("Do you experience shortness of breath? " + "Yes");
            }

            if (breathNorb.Checked)
            {
                breathAnswer = breathNorb.Text;
                file.WriteLine("Do you experience shortness of breath? " + "No");
            }

            //Are you already vaccinated?
            String vacAnswer = "";
            if (vacYesrb.Checked)
            {
                vacAnswer = vacYesrb.Text;
                file.WriteLine("Do you experience shortness of breath? " + "Yes");
            }

            if (vacNorb.Checked)
            {
                vacAnswer = vacNorb.Text;
                file.WriteLine("Do you experience shortness of breath? " + "No");
            }

            file.Close();
        }

        private void feveryesrb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void feverNorb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void middlebx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
