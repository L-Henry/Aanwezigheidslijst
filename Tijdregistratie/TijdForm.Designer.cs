namespace Tijdregistratie
{
    partial class TijdForm
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxOpl = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOplEind = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOplStart = new System.Windows.Forms.DateTimePicker();
            this.labelEindDatum = new System.Windows.Forms.Label();
            this.labelStartdatum = new System.Windows.Forms.Label();
            this.labelOplCode = new System.Windows.Forms.Label();
            this.labelOENummer = new System.Windows.Forms.Label();
            this.labelRefOplPlaats = new System.Windows.Forms.Label();
            this.labelOplPlaats = new System.Windows.Forms.Label();
            this.labelContactPersoon = new System.Windows.Forms.Label();
            this.labelOplNaam = new System.Windows.Forms.Label();
            this.labelOplInstelling = new System.Windows.Forms.Label();
            this.labelIdOpleiding = new System.Windows.Forms.Label();
            this.textBoxOplCode = new System.Windows.Forms.TextBox();
            this.textBoxOplOE = new System.Windows.Forms.TextBox();
            this.textBoxOplRef = new System.Windows.Forms.TextBox();
            this.textBoxOplPlaats = new System.Windows.Forms.TextBox();
            this.textBoxOplContact = new System.Windows.Forms.TextBox();
            this.textBoxOpl = new System.Windows.Forms.TextBox();
            this.textBoxOplInstelling = new System.Windows.Forms.TextBox();
            this.textBoxOplId = new System.Windows.Forms.TextBox();
            this.labelTijd = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBoxOpl
            // 
            this.comboBoxOpl.FormattingEnabled = true;
            this.comboBoxOpl.Location = new System.Drawing.Point(16, 14);
            this.comboBoxOpl.Name = "comboBoxOpl";
            this.comboBoxOpl.Size = new System.Drawing.Size(312, 28);
            this.comboBoxOpl.TabIndex = 0;
            this.comboBoxOpl.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOpl_SelectedIndexChanged);
            // 
            // dateTimePickerOplEind
            // 
            this.dateTimePickerOplEind.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOplEind.Location = new System.Drawing.Point(851, 204);
            this.dateTimePickerOplEind.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dateTimePickerOplEind.Name = "dateTimePickerOplEind";
            this.dateTimePickerOplEind.Size = new System.Drawing.Size(318, 26);
            this.dateTimePickerOplEind.TabIndex = 44;
            // 
            // dateTimePickerOplStart
            // 
            this.dateTimePickerOplStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOplStart.Location = new System.Drawing.Point(851, 170);
            this.dateTimePickerOplStart.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dateTimePickerOplStart.Name = "dateTimePickerOplStart";
            this.dateTimePickerOplStart.Size = new System.Drawing.Size(318, 26);
            this.dateTimePickerOplStart.TabIndex = 43;
            // 
            // labelEindDatum
            // 
            this.labelEindDatum.AutoSize = true;
            this.labelEindDatum.Location = new System.Drawing.Point(618, 207);
            this.labelEindDatum.Name = "labelEindDatum";
            this.labelEindDatum.Size = new System.Drawing.Size(90, 20);
            this.labelEindDatum.TabIndex = 42;
            this.labelEindDatum.Text = "Eind datum";
            // 
            // labelStartdatum
            // 
            this.labelStartdatum.AutoSize = true;
            this.labelStartdatum.Location = new System.Drawing.Point(618, 173);
            this.labelStartdatum.Name = "labelStartdatum";
            this.labelStartdatum.Size = new System.Drawing.Size(96, 20);
            this.labelStartdatum.TabIndex = 41;
            this.labelStartdatum.Text = "Start Datum";
            // 
            // labelOplCode
            // 
            this.labelOplCode.AutoSize = true;
            this.labelOplCode.Location = new System.Drawing.Point(618, 137);
            this.labelOplCode.Name = "labelOplCode";
            this.labelOplCode.Size = new System.Drawing.Size(118, 20);
            this.labelOplCode.TabIndex = 40;
            this.labelOplCode.Text = "Opleidingscode";
            // 
            // labelOENummer
            // 
            this.labelOENummer.AutoSize = true;
            this.labelOENummer.Location = new System.Drawing.Point(618, 103);
            this.labelOENummer.Name = "labelOENummer";
            this.labelOENummer.Size = new System.Drawing.Size(94, 20);
            this.labelOENummer.TabIndex = 39;
            this.labelOENummer.Text = "OE nummer";
            // 
            // labelRefOplPlaats
            // 
            this.labelRefOplPlaats.AutoSize = true;
            this.labelRefOplPlaats.Location = new System.Drawing.Point(618, 69);
            this.labelRefOplPlaats.Name = "labelRefOplPlaats";
            this.labelRefOplPlaats.Size = new System.Drawing.Size(202, 20);
            this.labelRefOplPlaats.TabIndex = 38;
            this.labelRefOplPlaats.Text = "Referentie opleidingsplaats";
            // 
            // labelOplPlaats
            // 
            this.labelOplPlaats.AutoSize = true;
            this.labelOplPlaats.Location = new System.Drawing.Point(65, 208);
            this.labelOplPlaats.Name = "labelOplPlaats";
            this.labelOplPlaats.Size = new System.Drawing.Size(126, 20);
            this.labelOplPlaats.TabIndex = 37;
            this.labelOplPlaats.Text = "Opleidingsplaats";
            // 
            // labelContactPersoon
            // 
            this.labelContactPersoon.AutoSize = true;
            this.labelContactPersoon.Location = new System.Drawing.Point(65, 174);
            this.labelContactPersoon.Name = "labelContactPersoon";
            this.labelContactPersoon.Size = new System.Drawing.Size(123, 20);
            this.labelContactPersoon.TabIndex = 36;
            this.labelContactPersoon.Text = "Contactpersoon";
            // 
            // labelOplNaam
            // 
            this.labelOplNaam.AutoSize = true;
            this.labelOplNaam.Location = new System.Drawing.Point(65, 140);
            this.labelOplNaam.Name = "labelOplNaam";
            this.labelOplNaam.Size = new System.Drawing.Size(75, 20);
            this.labelOplNaam.TabIndex = 35;
            this.labelOplNaam.Text = "Opleiding";
            // 
            // labelOplInstelling
            // 
            this.labelOplInstelling.AutoSize = true;
            this.labelOplInstelling.Location = new System.Drawing.Point(65, 106);
            this.labelOplInstelling.Name = "labelOplInstelling";
            this.labelOplInstelling.Size = new System.Drawing.Size(144, 20);
            this.labelOplInstelling.TabIndex = 34;
            this.labelOplInstelling.Text = "Opleidingsinstelling";
            // 
            // labelIdOpleiding
            // 
            this.labelIdOpleiding.AutoSize = true;
            this.labelIdOpleiding.Location = new System.Drawing.Point(65, 72);
            this.labelIdOpleiding.Name = "labelIdOpleiding";
            this.labelIdOpleiding.Size = new System.Drawing.Size(119, 20);
            this.labelIdOpleiding.TabIndex = 33;
            this.labelIdOpleiding.Text = "Id van opleiding";
            // 
            // textBoxOplCode
            // 
            this.textBoxOplCode.Location = new System.Drawing.Point(851, 134);
            this.textBoxOplCode.Name = "textBoxOplCode";
            this.textBoxOplCode.Size = new System.Drawing.Size(318, 26);
            this.textBoxOplCode.TabIndex = 32;
            // 
            // textBoxOplOE
            // 
            this.textBoxOplOE.Location = new System.Drawing.Point(851, 100);
            this.textBoxOplOE.Name = "textBoxOplOE";
            this.textBoxOplOE.Size = new System.Drawing.Size(318, 26);
            this.textBoxOplOE.TabIndex = 31;
            // 
            // textBoxOplRef
            // 
            this.textBoxOplRef.Location = new System.Drawing.Point(851, 66);
            this.textBoxOplRef.Name = "textBoxOplRef";
            this.textBoxOplRef.Size = new System.Drawing.Size(318, 26);
            this.textBoxOplRef.TabIndex = 30;
            // 
            // textBoxOplPlaats
            // 
            this.textBoxOplPlaats.Location = new System.Drawing.Point(223, 205);
            this.textBoxOplPlaats.Name = "textBoxOplPlaats";
            this.textBoxOplPlaats.Size = new System.Drawing.Size(298, 26);
            this.textBoxOplPlaats.TabIndex = 29;
            // 
            // textBoxOplContact
            // 
            this.textBoxOplContact.Location = new System.Drawing.Point(223, 171);
            this.textBoxOplContact.Name = "textBoxOplContact";
            this.textBoxOplContact.Size = new System.Drawing.Size(298, 26);
            this.textBoxOplContact.TabIndex = 28;
            // 
            // textBoxOpl
            // 
            this.textBoxOpl.Location = new System.Drawing.Point(223, 137);
            this.textBoxOpl.Name = "textBoxOpl";
            this.textBoxOpl.Size = new System.Drawing.Size(298, 26);
            this.textBoxOpl.TabIndex = 27;
            // 
            // textBoxOplInstelling
            // 
            this.textBoxOplInstelling.Location = new System.Drawing.Point(223, 103);
            this.textBoxOplInstelling.Name = "textBoxOplInstelling";
            this.textBoxOplInstelling.Size = new System.Drawing.Size(298, 26);
            this.textBoxOplInstelling.TabIndex = 26;
            // 
            // textBoxOplId
            // 
            this.textBoxOplId.Location = new System.Drawing.Point(223, 69);
            this.textBoxOplId.Name = "textBoxOplId";
            this.textBoxOplId.ReadOnly = true;
            this.textBoxOplId.Size = new System.Drawing.Size(298, 26);
            this.textBoxOplId.TabIndex = 25;
            // 
            // labelTijd
            // 
            this.labelTijd.AutoSize = true;
            this.labelTijd.Location = new System.Drawing.Point(847, 17);
            this.labelTijd.Name = "labelTijd";
            this.labelTijd.Size = new System.Drawing.Size(33, 20);
            this.labelTijd.TabIndex = 45;
            this.labelTijd.Text = "Tijd";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // TijdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 967);
            this.Controls.Add(this.labelTijd);
            this.Controls.Add(this.dateTimePickerOplEind);
            this.Controls.Add(this.dateTimePickerOplStart);
            this.Controls.Add(this.labelEindDatum);
            this.Controls.Add(this.labelStartdatum);
            this.Controls.Add(this.labelOplCode);
            this.Controls.Add(this.labelOENummer);
            this.Controls.Add(this.labelRefOplPlaats);
            this.Controls.Add(this.labelOplPlaats);
            this.Controls.Add(this.labelContactPersoon);
            this.Controls.Add(this.labelOplNaam);
            this.Controls.Add(this.labelOplInstelling);
            this.Controls.Add(this.labelIdOpleiding);
            this.Controls.Add(this.textBoxOplCode);
            this.Controls.Add(this.textBoxOplOE);
            this.Controls.Add(this.textBoxOplRef);
            this.Controls.Add(this.textBoxOplPlaats);
            this.Controls.Add(this.textBoxOplContact);
            this.Controls.Add(this.textBoxOpl);
            this.Controls.Add(this.textBoxOplInstelling);
            this.Controls.Add(this.textBoxOplId);
            this.Controls.Add(this.comboBoxOpl);
            this.Name = "TijdForm";
            this.Text = "Badgen";
            this.Load += new System.EventHandler(this.TijdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOpl;
        private System.Windows.Forms.DateTimePicker dateTimePickerOplEind;
        private System.Windows.Forms.DateTimePicker dateTimePickerOplStart;
        private System.Windows.Forms.Label labelEindDatum;
        private System.Windows.Forms.Label labelStartdatum;
        private System.Windows.Forms.Label labelOplCode;
        private System.Windows.Forms.Label labelOENummer;
        private System.Windows.Forms.Label labelRefOplPlaats;
        private System.Windows.Forms.Label labelOplPlaats;
        private System.Windows.Forms.Label labelContactPersoon;
        private System.Windows.Forms.Label labelOplNaam;
        private System.Windows.Forms.Label labelOplInstelling;
        private System.Windows.Forms.Label labelIdOpleiding;
        private System.Windows.Forms.TextBox textBoxOplCode;
        private System.Windows.Forms.TextBox textBoxOplOE;
        private System.Windows.Forms.TextBox textBoxOplRef;
        private System.Windows.Forms.TextBox textBoxOplPlaats;
        private System.Windows.Forms.TextBox textBoxOplContact;
        private System.Windows.Forms.TextBox textBoxOpl;
        private System.Windows.Forms.TextBox textBoxOplInstelling;
        private System.Windows.Forms.TextBox textBoxOplId;
        private System.Windows.Forms.Label labelTijd;
        private System.Windows.Forms.Timer timer1;
    }
}

