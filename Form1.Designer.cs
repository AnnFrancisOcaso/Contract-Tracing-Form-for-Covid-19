
namespace Contact_Tracing_Form_updated
{
    partial class Contacttracing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formlbl = new System.Windows.Forms.Label();
            this.temperaturebx = new System.Windows.Forms.TextBox();
            this.temperaturelbl = new System.Windows.Forms.Label();
            this.timebx = new System.Windows.Forms.TextBox();
            this.timelbl = new System.Windows.Forms.Label();
            this.datebx = new System.Windows.Forms.TextBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.emailbx = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.agelbl = new System.Windows.Forms.Label();
            this.agebx = new System.Windows.Forms.TextBox();
            this.birthbx = new System.Windows.Forms.TextBox();
            this.birthlbl = new System.Windows.Forms.Label();
            this.lastlbl = new System.Windows.Forms.Label();
            this.lastbx = new System.Windows.Forms.TextBox();
            this.middlebx = new System.Windows.Forms.TextBox();
            this.middlelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.namebx = new System.Windows.Forms.TextBox();
            this.profilelbl = new System.Windows.Forms.Label();
            this.barangaybx = new System.Windows.Forms.TextBox();
            this.barangaylbl = new System.Windows.Forms.Label();
            this.municipalitybx = new System.Windows.Forms.TextBox();
            this.Municipalitylbl = new System.Windows.Forms.Label();
            this.provincebx = new System.Windows.Forms.TextBox();
            this.provincelbl = new System.Windows.Forms.Label();
            this.regionbx = new System.Windows.Forms.TextBox();
            this.regionlbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formlbl
            // 
            this.formlbl.AutoSize = true;
            this.formlbl.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formlbl.Location = new System.Drawing.Point(41, 21);
            this.formlbl.Name = "formlbl";
            this.formlbl.Size = new System.Drawing.Size(439, 38);
            this.formlbl.TabIndex = 1;
            this.formlbl.Text = "COVID 19 Contact Tracing Form";
            // 
            // temperaturebx
            // 
            this.temperaturebx.Location = new System.Drawing.Point(318, 100);
            this.temperaturebx.Name = "temperaturebx";
            this.temperaturebx.Size = new System.Drawing.Size(188, 20);
            this.temperaturebx.TabIndex = 12;
            this.temperaturebx.TextChanged += new System.EventHandler(this.temperaturebx_TextChanged);
            // 
            // temperaturelbl
            // 
            this.temperaturelbl.AutoSize = true;
            this.temperaturelbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.temperaturelbl.Location = new System.Drawing.Point(314, 77);
            this.temperaturelbl.Name = "temperaturelbl";
            this.temperaturelbl.Size = new System.Drawing.Size(83, 20);
            this.temperaturelbl.TabIndex = 11;
            this.temperaturelbl.Text = "Temperature:";
            this.temperaturelbl.Click += new System.EventHandler(this.temperaturelbl_Click);
            // 
            // timebx
            // 
            this.timebx.Location = new System.Drawing.Point(190, 100);
            this.timebx.Name = "timebx";
            this.timebx.Size = new System.Drawing.Size(122, 20);
            this.timebx.TabIndex = 10;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.timelbl.Location = new System.Drawing.Point(187, 77);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(42, 20);
            this.timelbl.TabIndex = 9;
            this.timelbl.Text = "Time:";
            // 
            // datebx
            // 
            this.datebx.Location = new System.Drawing.Point(35, 100);
            this.datebx.Name = "datebx";
            this.datebx.Size = new System.Drawing.Size(149, 20);
            this.datebx.TabIndex = 8;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.datelbl.Location = new System.Drawing.Point(31, 77);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(41, 20);
            this.datelbl.TabIndex = 7;
            this.datelbl.Text = "Date: ";
            // 
            // emailbx
            // 
            this.emailbx.Location = new System.Drawing.Point(35, 266);
            this.emailbx.Name = "emailbx";
            this.emailbx.Size = new System.Drawing.Size(315, 20);
            this.emailbx.TabIndex = 33;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.emaillbl.Location = new System.Drawing.Point(31, 243);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(91, 20);
            this.emaillbl.TabIndex = 32;
            this.emaillbl.Text = "Email Address:";
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.agelbl.Location = new System.Drawing.Point(197, 197);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(34, 20);
            this.agelbl.TabIndex = 31;
            this.agelbl.Text = "Age:";
            // 
            // agebx
            // 
            this.agebx.Location = new System.Drawing.Point(199, 220);
            this.agebx.Name = "agebx";
            this.agebx.Size = new System.Drawing.Size(151, 20);
            this.agebx.TabIndex = 30;
            // 
            // birthbx
            // 
            this.birthbx.Location = new System.Drawing.Point(35, 220);
            this.birthbx.Name = "birthbx";
            this.birthbx.Size = new System.Drawing.Size(151, 20);
            this.birthbx.TabIndex = 29;
            // 
            // birthlbl
            // 
            this.birthlbl.AutoSize = true;
            this.birthlbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.birthlbl.Location = new System.Drawing.Point(31, 198);
            this.birthlbl.Name = "birthlbl";
            this.birthlbl.Size = new System.Drawing.Size(83, 20);
            this.birthlbl.TabIndex = 28;
            this.birthlbl.Text = "Date of Birth:";
            // 
            // lastlbl
            // 
            this.lastlbl.AutoSize = true;
            this.lastlbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.lastlbl.Location = new System.Drawing.Point(361, 151);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(70, 20);
            this.lastlbl.TabIndex = 27;
            this.lastlbl.Text = "Last Name:";
            // 
            // lastbx
            // 
            this.lastbx.Location = new System.Drawing.Point(365, 174);
            this.lastbx.Name = "lastbx";
            this.lastbx.Size = new System.Drawing.Size(141, 20);
            this.lastbx.TabIndex = 26;
            // 
            // middlebx
            // 
            this.middlebx.Location = new System.Drawing.Point(199, 174);
            this.middlebx.Name = "middlebx";
            this.middlebx.Size = new System.Drawing.Size(151, 20);
            this.middlebx.TabIndex = 25;
            // 
            // middlelbl
            // 
            this.middlelbl.AutoSize = true;
            this.middlelbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.middlelbl.Location = new System.Drawing.Point(197, 151);
            this.middlelbl.Name = "middlelbl";
            this.middlelbl.Size = new System.Drawing.Size(86, 20);
            this.middlelbl.TabIndex = 24;
            this.middlelbl.Text = "Middle Name:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.namelbl.Location = new System.Drawing.Point(31, 152);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(73, 20);
            this.namelbl.TabIndex = 23;
            this.namelbl.Text = "First Name:";
            // 
            // namebx
            // 
            this.namebx.Location = new System.Drawing.Point(35, 174);
            this.namebx.Name = "namebx";
            this.namebx.Size = new System.Drawing.Size(151, 20);
            this.namebx.TabIndex = 22;
            // 
            // profilelbl
            // 
            this.profilelbl.AutoSize = true;
            this.profilelbl.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilelbl.Location = new System.Drawing.Point(31, 127);
            this.profilelbl.Name = "profilelbl";
            this.profilelbl.Size = new System.Drawing.Size(49, 21);
            this.profilelbl.TabIndex = 21;
            this.profilelbl.Text = "Profile";
            // 
            // barangaybx
            // 
            this.barangaybx.Location = new System.Drawing.Point(294, 384);
            this.barangaybx.Name = "barangaybx";
            this.barangaybx.Size = new System.Drawing.Size(212, 20);
            this.barangaybx.TabIndex = 42;
            // 
            // barangaylbl
            // 
            this.barangaylbl.AutoSize = true;
            this.barangaylbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.barangaylbl.Location = new System.Drawing.Point(290, 362);
            this.barangaylbl.Name = "barangaylbl";
            this.barangaylbl.Size = new System.Drawing.Size(64, 20);
            this.barangaylbl.TabIndex = 41;
            this.barangaylbl.Text = "Barangay:";
            // 
            // municipalitybx
            // 
            this.municipalitybx.Location = new System.Drawing.Point(37, 384);
            this.municipalitybx.Name = "municipalitybx";
            this.municipalitybx.Size = new System.Drawing.Size(227, 20);
            this.municipalitybx.TabIndex = 40;
            // 
            // Municipalitylbl
            // 
            this.Municipalitylbl.AutoSize = true;
            this.Municipalitylbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.Municipalitylbl.Location = new System.Drawing.Point(34, 361);
            this.Municipalitylbl.Name = "Municipalitylbl";
            this.Municipalitylbl.Size = new System.Drawing.Size(82, 20);
            this.Municipalitylbl.TabIndex = 39;
            this.Municipalitylbl.Text = "Municipality:";
            // 
            // provincebx
            // 
            this.provincebx.Location = new System.Drawing.Point(294, 339);
            this.provincebx.Name = "provincebx";
            this.provincebx.Size = new System.Drawing.Size(212, 20);
            this.provincebx.TabIndex = 38;
            // 
            // provincelbl
            // 
            this.provincelbl.AutoSize = true;
            this.provincelbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.provincelbl.Location = new System.Drawing.Point(290, 316);
            this.provincelbl.Name = "provincelbl";
            this.provincelbl.Size = new System.Drawing.Size(61, 20);
            this.provincelbl.TabIndex = 37;
            this.provincelbl.Text = "Province:";
            // 
            // regionbx
            // 
            this.regionbx.Location = new System.Drawing.Point(37, 339);
            this.regionbx.Name = "regionbx";
            this.regionbx.Size = new System.Drawing.Size(227, 20);
            this.regionbx.TabIndex = 36;
            // 
            // regionlbl
            // 
            this.regionlbl.AutoSize = true;
            this.regionlbl.Font = new System.Drawing.Font("Sitka Display", 10F);
            this.regionlbl.Location = new System.Drawing.Point(33, 316);
            this.regionlbl.Name = "regionlbl";
            this.regionlbl.Size = new System.Drawing.Size(52, 20);
            this.regionlbl.TabIndex = 35;
            this.regionlbl.Text = "Region:";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(33, 295);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(56, 21);
            this.addresslbl.TabIndex = 34;
            this.addresslbl.Text = "Address";
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Sitka Display", 12F);
            this.Submit.Location = new System.Drawing.Point(201, 714);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(112, 33);
            this.Submit.TabIndex = 43;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // Contacttracing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 759);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.barangaybx);
            this.Controls.Add(this.barangaylbl);
            this.Controls.Add(this.municipalitybx);
            this.Controls.Add(this.Municipalitylbl);
            this.Controls.Add(this.provincebx);
            this.Controls.Add(this.provincelbl);
            this.Controls.Add(this.regionbx);
            this.Controls.Add(this.regionlbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.emailbx);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.agebx);
            this.Controls.Add(this.birthbx);
            this.Controls.Add(this.birthlbl);
            this.Controls.Add(this.lastlbl);
            this.Controls.Add(this.lastbx);
            this.Controls.Add(this.middlebx);
            this.Controls.Add(this.middlelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.namebx);
            this.Controls.Add(this.profilelbl);
            this.Controls.Add(this.temperaturebx);
            this.Controls.Add(this.temperaturelbl);
            this.Controls.Add(this.timebx);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.datebx);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.formlbl);
            this.MaximizeBox = false;
            this.Name = "Contacttracing";
            this.ShowIcon = false;
            this.Text = "Contact Tracing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formlbl;
        private System.Windows.Forms.TextBox temperaturebx;
        private System.Windows.Forms.Label temperaturelbl;
        private System.Windows.Forms.TextBox timebx;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.TextBox datebx;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.TextBox emailbx;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.TextBox agebx;
        private System.Windows.Forms.TextBox birthbx;
        private System.Windows.Forms.Label birthlbl;
        private System.Windows.Forms.Label lastlbl;
        private System.Windows.Forms.TextBox lastbx;
        private System.Windows.Forms.TextBox middlebx;
        private System.Windows.Forms.Label middlelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox namebx;
        private System.Windows.Forms.Label profilelbl;
        private System.Windows.Forms.TextBox barangaybx;
        private System.Windows.Forms.Label barangaylbl;
        private System.Windows.Forms.TextBox municipalitybx;
        private System.Windows.Forms.Label Municipalitylbl;
        private System.Windows.Forms.TextBox provincebx;
        private System.Windows.Forms.Label provincelbl;
        private System.Windows.Forms.TextBox regionbx;
        private System.Windows.Forms.Label regionlbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Button Submit;
    }
}

