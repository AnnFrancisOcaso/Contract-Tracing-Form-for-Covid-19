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
            file.WriteLine("Date: " + Datebttn.Text);
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

            //radiobutton select yes or no
            //1 Do you have a fever?
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

            //2 Do you have a dry cough
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

            //3 Do you experience headache?
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

            //4 Do you have sore throat?
            String soreAnswer = "";
            if (soreYesrb.Checked)
            {
                soreAnswer = soreYesrb.Text;
                file.WriteLine("Do you have sore throat? " + "Yes");
            }

            if (soreNorb.Checked)
            {
                soreAnswer = soreNorb.Text;
                file.WriteLine("Do you have sore throat? " + "No");
            }

            //5 Do you experience fatigue?
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

            //6 Do you experience shortness of breath?
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

            //7 Do you experience body ache?
            String bodyAnswer = "";
            if (bodyYesrb.Checked)
            {
                bodyAnswer = bodyYesrb.Text;
                file.WriteLine("Do you experience body ache? " + "Yes");
            }

            if (bodyNorb.Checked)
            {
                bodyAnswer = bodyNorb.Text;
                file.WriteLine("Do you experience body ache? " + "No");
            }

            //8 Do you experience diarrhea?
            String diAnswer = "";
            if (bodyYesrb.Checked)
            {
                diAnswer = diYesrb.Text;
                file.WriteLine("Do you experience diarrhea? " + "Yes");
            }

            if (diNorb.Checked)
            {
                diAnswer = diNorb.Text;
                file.WriteLine("Do you experience diarrhea? " + "No");
            }

            //9 Do you experience loss of smell?
            String smellAnswer = "";
            if (smellYesrb.Checked)
            {
                smellAnswer = smellYesrb.Text;
                file.WriteLine("Do you experience loss of smell? " + "Yes");
            }

            if (smellNorb.Checked)
            {
                smellAnswer = smellNorb.Text;
                file.WriteLine("Do you experience loss of smell? " + "No");
            }

            //10 close contact with patient
            String patientAnswer = "";
            if (patientYesrb.Checked)
            {
                patientAnswer = patientYesrb.Text;
                file.WriteLine("Have you had close contact with a covid 19 patient? " + "Yes");
            }

            if (patientNorb.Checked)
            {
                patientAnswer = patientNorb.Text;
                file.WriteLine("Have you had close contact with a covid 19 patient? " + "No");
            }

            //11 date of exposure
            file.WriteLine("If yes, state the date of the exposure. " + DateExposure.Text);

            //Have you gone somewhere outside your residence/city?
            String cityAnswer = "";
            if (ctYesrb.Checked)
            {
                cityAnswer = ctYesrb.Text;
                file.WriteLine("Have you had close contact with a covid 19 patient? " + "Yes");
            }

            if (ctNorb.Checked)
            {
                cityAnswer = ctNorb.Text;
                file.WriteLine("Have you had close contact with a covid 19 patient? " + "No");
            }


            file.Close();
        }


        private void feverNorb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void middlebx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
