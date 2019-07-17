namespace Beheer
{
    partial class BeheerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOpl = new System.Windows.Forms.TabPage();
            this.dateTimePickerOplEind = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOplStart = new System.Windows.Forms.DateTimePicker();
            this.buttonOplDel = new System.Windows.Forms.Button();
            this.buttonOplUpd = new System.Windows.Forms.Button();
            this.buttonOplCreate = new System.Windows.Forms.Button();
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
            this.tabDeelnemers = new System.Windows.Forms.TabPage();
            this.dateTimePickerDeelnGeb = new System.Windows.Forms.DateTimePicker();
            this.listBoxDeelnemers = new System.Windows.Forms.ListBox();
            this.buttonDeelnemerDel = new System.Windows.Forms.Button();
            this.buttonDeelnemerUpd = new System.Windows.Forms.Button();
            this.buttonDeelnemerCreate = new System.Windows.Forms.Button();
            this.labelDeelnemerBadgeNummer = new System.Windows.Forms.Label();
            this.labelDeelnemerWoonplaats = new System.Windows.Forms.Label();
            this.labelDeelnemerGeboortedatum = new System.Windows.Forms.Label();
            this.labelDeelnemerNaam = new System.Windows.Forms.Label();
            this.labelIdDeelnemer = new System.Windows.Forms.Label();
            this.textBoxDeelnBadge = new System.Windows.Forms.TextBox();
            this.textBoxDeelnWoon = new System.Windows.Forms.TextBox();
            this.textBoxDeelnNaam = new System.Windows.Forms.TextBox();
            this.textBoxDeelnId = new System.Windows.Forms.TextBox();
            this.tabFeest = new System.Windows.Forms.TabPage();
            this.checkBoxVerlofNamiddag = new System.Windows.Forms.CheckBox();
            this.checkBoxVerlofVoormiddag = new System.Windows.Forms.CheckBox();
            this.dateTimePickerVerlof = new System.Windows.Forms.DateTimePicker();
            this.listBoxFeestdag = new System.Windows.Forms.ListBox();
            this.buttonVerlofDel = new System.Windows.Forms.Button();
            this.buttonVerlofUpd = new System.Windows.Forms.Button();
            this.buttonVerlofAdd = new System.Windows.Forms.Button();
            this.labelVerlofNamiddag = new System.Windows.Forms.Label();
            this.labelVerlofVoormiddag = new System.Windows.Forms.Label();
            this.labelVerlofDatum = new System.Windows.Forms.Label();
            this.labelIdVerlof = new System.Windows.Forms.Label();
            this.textBoxVerlofId = new System.Windows.Forms.TextBox();
            this.tabDocent = new System.Windows.Forms.TabPage();
            this.listBoxDocent = new System.Windows.Forms.ListBox();
            this.buttonDocentDel = new System.Windows.Forms.Button();
            this.buttonDocentUpd = new System.Windows.Forms.Button();
            this.buttonDocentAdd = new System.Windows.Forms.Button();
            this.labelDocentBedrijf = new System.Windows.Forms.Label();
            this.labelDocentNaam = new System.Windows.Forms.Label();
            this.labelDocentId = new System.Windows.Forms.Label();
            this.textBoxDocentBedrijf = new System.Windows.Forms.TextBox();
            this.textBoxDocentNaam = new System.Windows.Forms.TextBox();
            this.textBoxDocentId = new System.Windows.Forms.TextBox();
            this.tabTijd = new System.Windows.Forms.TabPage();
            this.listBoxDeelnemersTijd = new System.Windows.Forms.ListBox();
            this.labelTijdDeelnemerId = new System.Windows.Forms.Label();
            this.labelTijdOpleidingId = new System.Windows.Forms.Label();
            this.labelTijdDateTime = new System.Windows.Forms.Label();
            this.labelTijdId = new System.Windows.Forms.Label();
            this.textBoxTijdDeelnId = new System.Windows.Forms.TextBox();
            this.textBoxTijdOplId = new System.Windows.Forms.TextBox();
            this.textBoxTijdStip = new System.Windows.Forms.TextBox();
            this.textBoxTijdId = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboBoxOpleiding = new System.Windows.Forms.ToolStripComboBox();
            this.errorProviderOplInfoTab = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabOpl.SuspendLayout();
            this.tabDeelnemers.SuspendLayout();
            this.tabFeest.SuspendLayout();
            this.tabDocent.SuspendLayout();
            this.tabTijd.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOplInfoTab)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOpl);
            this.tabControl1.Controls.Add(this.tabDeelnemers);
            this.tabControl1.Controls.Add(this.tabFeest);
            this.tabControl1.Controls.Add(this.tabDocent);
            this.tabControl1.Controls.Add(this.tabTijd);
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 733);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOpl
            // 
            this.tabOpl.Controls.Add(this.dateTimePickerOplEind);
            this.tabOpl.Controls.Add(this.dateTimePickerOplStart);
            this.tabOpl.Controls.Add(this.buttonOplDel);
            this.tabOpl.Controls.Add(this.buttonOplUpd);
            this.tabOpl.Controls.Add(this.buttonOplCreate);
            this.tabOpl.Controls.Add(this.labelEindDatum);
            this.tabOpl.Controls.Add(this.labelStartdatum);
            this.tabOpl.Controls.Add(this.labelOplCode);
            this.tabOpl.Controls.Add(this.labelOENummer);
            this.tabOpl.Controls.Add(this.labelRefOplPlaats);
            this.tabOpl.Controls.Add(this.labelOplPlaats);
            this.tabOpl.Controls.Add(this.labelContactPersoon);
            this.tabOpl.Controls.Add(this.labelOplNaam);
            this.tabOpl.Controls.Add(this.labelOplInstelling);
            this.tabOpl.Controls.Add(this.labelIdOpleiding);
            this.tabOpl.Controls.Add(this.textBoxOplCode);
            this.tabOpl.Controls.Add(this.textBoxOplOE);
            this.tabOpl.Controls.Add(this.textBoxOplRef);
            this.tabOpl.Controls.Add(this.textBoxOplPlaats);
            this.tabOpl.Controls.Add(this.textBoxOplContact);
            this.tabOpl.Controls.Add(this.textBoxOpl);
            this.tabOpl.Controls.Add(this.textBoxOplInstelling);
            this.tabOpl.Controls.Add(this.textBoxOplId);
            this.tabOpl.Location = new System.Drawing.Point(4, 29);
            this.tabOpl.Name = "tabOpl";
            this.tabOpl.Padding = new System.Windows.Forms.Padding(3);
            this.tabOpl.Size = new System.Drawing.Size(1046, 700);
            this.tabOpl.TabIndex = 0;
            this.tabOpl.Text = "Opleiding info";
            this.tabOpl.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerOplEind
            // 
            this.dateTimePickerOplEind.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOplEind.Location = new System.Drawing.Point(275, 366);
            this.dateTimePickerOplEind.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dateTimePickerOplEind.Name = "dateTimePickerOplEind";
            this.dateTimePickerOplEind.Size = new System.Drawing.Size(221, 26);
            this.dateTimePickerOplEind.TabIndex = 24;
            // 
            // dateTimePickerOplStart
            // 
            this.dateTimePickerOplStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOplStart.Location = new System.Drawing.Point(275, 332);
            this.dateTimePickerOplStart.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dateTimePickerOplStart.Name = "dateTimePickerOplStart";
            this.dateTimePickerOplStart.Size = new System.Drawing.Size(221, 26);
            this.dateTimePickerOplStart.TabIndex = 23;
            // 
            // buttonOplDel
            // 
            this.buttonOplDel.Location = new System.Drawing.Point(374, 507);
            this.buttonOplDel.Name = "buttonOplDel";
            this.buttonOplDel.Size = new System.Drawing.Size(122, 50);
            this.buttonOplDel.TabIndex = 22;
            this.buttonOplDel.Text = "Verwijder";
            this.buttonOplDel.UseVisualStyleBackColor = true;
            this.buttonOplDel.Click += new System.EventHandler(this.ButtonOplDel_Click);
            // 
            // buttonOplUpd
            // 
            this.buttonOplUpd.Location = new System.Drawing.Point(204, 507);
            this.buttonOplUpd.Name = "buttonOplUpd";
            this.buttonOplUpd.Size = new System.Drawing.Size(122, 50);
            this.buttonOplUpd.TabIndex = 21;
            this.buttonOplUpd.Text = "Update";
            this.buttonOplUpd.UseVisualStyleBackColor = true;
            this.buttonOplUpd.Click += new System.EventHandler(this.ButtonOplUpd_Click);
            // 
            // buttonOplCreate
            // 
            this.buttonOplCreate.Location = new System.Drawing.Point(35, 507);
            this.buttonOplCreate.Name = "buttonOplCreate";
            this.buttonOplCreate.Size = new System.Drawing.Size(122, 50);
            this.buttonOplCreate.TabIndex = 20;
            this.buttonOplCreate.Text = "Creeër nieuwe opleiding";
            this.buttonOplCreate.UseVisualStyleBackColor = true;
            this.buttonOplCreate.Click += new System.EventHandler(this.ButtonOplCreate_Click);
            // 
            // labelEindDatum
            // 
            this.labelEindDatum.AutoSize = true;
            this.labelEindDatum.Location = new System.Drawing.Point(31, 372);
            this.labelEindDatum.Name = "labelEindDatum";
            this.labelEindDatum.Size = new System.Drawing.Size(90, 20);
            this.labelEindDatum.TabIndex = 19;
            this.labelEindDatum.Text = "Eind datum";
            // 
            // labelStartdatum
            // 
            this.labelStartdatum.AutoSize = true;
            this.labelStartdatum.Location = new System.Drawing.Point(31, 338);
            this.labelStartdatum.Name = "labelStartdatum";
            this.labelStartdatum.Size = new System.Drawing.Size(96, 20);
            this.labelStartdatum.TabIndex = 18;
            this.labelStartdatum.Text = "Start Datum";
            // 
            // labelOplCode
            // 
            this.labelOplCode.AutoSize = true;
            this.labelOplCode.Location = new System.Drawing.Point(31, 302);
            this.labelOplCode.Name = "labelOplCode";
            this.labelOplCode.Size = new System.Drawing.Size(118, 20);
            this.labelOplCode.TabIndex = 17;
            this.labelOplCode.Text = "Opleidingscode";
            // 
            // labelOENummer
            // 
            this.labelOENummer.AutoSize = true;
            this.labelOENummer.Location = new System.Drawing.Point(31, 268);
            this.labelOENummer.Name = "labelOENummer";
            this.labelOENummer.Size = new System.Drawing.Size(94, 20);
            this.labelOENummer.TabIndex = 16;
            this.labelOENummer.Text = "OE nummer";
            // 
            // labelRefOplPlaats
            // 
            this.labelRefOplPlaats.AutoSize = true;
            this.labelRefOplPlaats.Location = new System.Drawing.Point(31, 234);
            this.labelRefOplPlaats.Name = "labelRefOplPlaats";
            this.labelRefOplPlaats.Size = new System.Drawing.Size(202, 20);
            this.labelRefOplPlaats.TabIndex = 15;
            this.labelRefOplPlaats.Text = "Referentie opleidingsplaats";
            // 
            // labelOplPlaats
            // 
            this.labelOplPlaats.AutoSize = true;
            this.labelOplPlaats.Location = new System.Drawing.Point(31, 200);
            this.labelOplPlaats.Name = "labelOplPlaats";
            this.labelOplPlaats.Size = new System.Drawing.Size(126, 20);
            this.labelOplPlaats.TabIndex = 14;
            this.labelOplPlaats.Text = "Opleidingsplaats";
            // 
            // labelContactPersoon
            // 
            this.labelContactPersoon.AutoSize = true;
            this.labelContactPersoon.Location = new System.Drawing.Point(31, 166);
            this.labelContactPersoon.Name = "labelContactPersoon";
            this.labelContactPersoon.Size = new System.Drawing.Size(123, 20);
            this.labelContactPersoon.TabIndex = 13;
            this.labelContactPersoon.Text = "Contactpersoon";
            // 
            // labelOplNaam
            // 
            this.labelOplNaam.AutoSize = true;
            this.labelOplNaam.Location = new System.Drawing.Point(31, 132);
            this.labelOplNaam.Name = "labelOplNaam";
            this.labelOplNaam.Size = new System.Drawing.Size(75, 20);
            this.labelOplNaam.TabIndex = 12;
            this.labelOplNaam.Text = "Opleiding";
            // 
            // labelOplInstelling
            // 
            this.labelOplInstelling.AutoSize = true;
            this.labelOplInstelling.Location = new System.Drawing.Point(31, 98);
            this.labelOplInstelling.Name = "labelOplInstelling";
            this.labelOplInstelling.Size = new System.Drawing.Size(144, 20);
            this.labelOplInstelling.TabIndex = 11;
            this.labelOplInstelling.Text = "Opleidingsinstelling";
            // 
            // labelIdOpleiding
            // 
            this.labelIdOpleiding.AutoSize = true;
            this.labelIdOpleiding.Location = new System.Drawing.Point(31, 64);
            this.labelIdOpleiding.Name = "labelIdOpleiding";
            this.labelIdOpleiding.Size = new System.Drawing.Size(119, 20);
            this.labelIdOpleiding.TabIndex = 10;
            this.labelIdOpleiding.Text = "Id van opleiding";
            // 
            // textBoxOplCode
            // 
            this.textBoxOplCode.Location = new System.Drawing.Point(275, 296);
            this.textBoxOplCode.Name = "textBoxOplCode";
            this.textBoxOplCode.Size = new System.Drawing.Size(221, 26);
            this.textBoxOplCode.TabIndex = 7;
            // 
            // textBoxOplOE
            // 
            this.textBoxOplOE.Location = new System.Drawing.Point(275, 262);
            this.textBoxOplOE.Name = "textBoxOplOE";
            this.textBoxOplOE.Size = new System.Drawing.Size(221, 26);
            this.textBoxOplOE.TabIndex = 6;
            // 
            // textBoxOplRef
            // 
            this.textBoxOplRef.Location = new System.Drawing.Point(275, 228);
            this.textBoxOplRef.Name = "textBoxOplRef";
            this.textBoxOplRef.Size = new System.Drawing.Size(221, 26);
            this.textBoxOplRef.TabIndex = 5;
            // 
            // textBoxOplPlaats
            // 
            this.textBoxOplPlaats.Location = new System.Drawing.Point(275, 194);
            this.textBoxOplPlaats.Name = "textBoxOplPlaats";
            this.textBoxOplPlaats.Size = new System.Drawing.Size(221, 26);
            this.textBoxOplPlaats.TabIndex = 4;
            // 
            // textBoxOplContact
            // 
            this.textBoxOplContact.Location = new System.Drawing.Point(275, 160);
            this.textBoxOplContact.Name = "textBoxOplContact";
            this.textBoxOplContact.Size = new System.Drawing.Size(221, 26);
            this.textBoxOplContact.TabIndex = 3;
            // 
            // textBoxOpl
            // 
            this.textBoxOpl.Location = new System.Drawing.Point(275, 126);
            this.textBoxOpl.Name = "textBoxOpl";
            this.textBoxOpl.Size = new System.Drawing.Size(221, 26);
            this.textBoxOpl.TabIndex = 2;
            // 
            // textBoxOplInstelling
            // 
            this.textBoxOplInstelling.Location = new System.Drawing.Point(275, 92);
            this.textBoxOplInstelling.Name = "textBoxOplInstelling";
            this.textBoxOplInstelling.Size = new System.Drawing.Size(221, 26);
            this.textBoxOplInstelling.TabIndex = 1;
            // 
            // textBoxOplId
            // 
            this.textBoxOplId.Location = new System.Drawing.Point(275, 58);
            this.textBoxOplId.Name = "textBoxOplId";
            this.textBoxOplId.ReadOnly = true;
            this.textBoxOplId.Size = new System.Drawing.Size(221, 26);
            this.textBoxOplId.TabIndex = 0;
            // 
            // tabDeelnemers
            // 
            this.tabDeelnemers.Controls.Add(this.dateTimePickerDeelnGeb);
            this.tabDeelnemers.Controls.Add(this.listBoxDeelnemers);
            this.tabDeelnemers.Controls.Add(this.buttonDeelnemerDel);
            this.tabDeelnemers.Controls.Add(this.buttonDeelnemerUpd);
            this.tabDeelnemers.Controls.Add(this.buttonDeelnemerCreate);
            this.tabDeelnemers.Controls.Add(this.labelDeelnemerBadgeNummer);
            this.tabDeelnemers.Controls.Add(this.labelDeelnemerWoonplaats);
            this.tabDeelnemers.Controls.Add(this.labelDeelnemerGeboortedatum);
            this.tabDeelnemers.Controls.Add(this.labelDeelnemerNaam);
            this.tabDeelnemers.Controls.Add(this.labelIdDeelnemer);
            this.tabDeelnemers.Controls.Add(this.textBoxDeelnBadge);
            this.tabDeelnemers.Controls.Add(this.textBoxDeelnWoon);
            this.tabDeelnemers.Controls.Add(this.textBoxDeelnNaam);
            this.tabDeelnemers.Controls.Add(this.textBoxDeelnId);
            this.tabDeelnemers.Location = new System.Drawing.Point(4, 29);
            this.tabDeelnemers.Name = "tabDeelnemers";
            this.tabDeelnemers.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeelnemers.Size = new System.Drawing.Size(1046, 700);
            this.tabDeelnemers.TabIndex = 1;
            this.tabDeelnemers.Text = "Deelnemers";
            this.tabDeelnemers.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDeelnGeb
            // 
            this.dateTimePickerDeelnGeb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeelnGeb.Location = new System.Drawing.Point(275, 126);
            this.dateTimePickerDeelnGeb.Name = "dateTimePickerDeelnGeb";
            this.dateTimePickerDeelnGeb.Size = new System.Drawing.Size(221, 26);
            this.dateTimePickerDeelnGeb.TabIndex = 61;
            this.dateTimePickerDeelnGeb.Value = new System.DateTime(2019, 7, 16, 11, 30, 7, 0);
            // 
            // listBoxDeelnemers
            // 
            this.listBoxDeelnemers.FormattingEnabled = true;
            this.listBoxDeelnemers.ItemHeight = 20;
            this.listBoxDeelnemers.Items.AddRange(new object[] {
            "Nieuwe deelnemer aanmaken"});
            this.listBoxDeelnemers.Location = new System.Drawing.Point(645, 43);
            this.listBoxDeelnemers.Name = "listBoxDeelnemers";
            this.listBoxDeelnemers.Size = new System.Drawing.Size(358, 624);
            this.listBoxDeelnemers.TabIndex = 60;
            this.listBoxDeelnemers.SelectedIndexChanged += new System.EventHandler(this.ListBoxDeelnemers_SelectedIndexChanged);
            // 
            // buttonDeelnemerDel
            // 
            this.buttonDeelnemerDel.Location = new System.Drawing.Point(374, 361);
            this.buttonDeelnemerDel.Name = "buttonDeelnemerDel";
            this.buttonDeelnemerDel.Size = new System.Drawing.Size(122, 50);
            this.buttonDeelnemerDel.TabIndex = 59;
            this.buttonDeelnemerDel.Text = "Verwijder";
            this.buttonDeelnemerDel.UseVisualStyleBackColor = true;
            this.buttonDeelnemerDel.Click += new System.EventHandler(this.ButtonDeelnemerDel_Click);
            // 
            // buttonDeelnemerUpd
            // 
            this.buttonDeelnemerUpd.Location = new System.Drawing.Point(204, 361);
            this.buttonDeelnemerUpd.Name = "buttonDeelnemerUpd";
            this.buttonDeelnemerUpd.Size = new System.Drawing.Size(122, 50);
            this.buttonDeelnemerUpd.TabIndex = 58;
            this.buttonDeelnemerUpd.Text = "Update";
            this.buttonDeelnemerUpd.UseVisualStyleBackColor = true;
            this.buttonDeelnemerUpd.Click += new System.EventHandler(this.ButtonDeelnemerUpd_Click);
            // 
            // buttonDeelnemerCreate
            // 
            this.buttonDeelnemerCreate.Location = new System.Drawing.Point(35, 361);
            this.buttonDeelnemerCreate.Name = "buttonDeelnemerCreate";
            this.buttonDeelnemerCreate.Size = new System.Drawing.Size(122, 50);
            this.buttonDeelnemerCreate.TabIndex = 57;
            this.buttonDeelnemerCreate.Text = "Voeg toe";
            this.buttonDeelnemerCreate.UseVisualStyleBackColor = true;
            this.buttonDeelnemerCreate.Click += new System.EventHandler(this.ButtonDeelnemerCreate_Click);
            // 
            // labelDeelnemerBadgeNummer
            // 
            this.labelDeelnemerBadgeNummer.AutoSize = true;
            this.labelDeelnemerBadgeNummer.Location = new System.Drawing.Point(31, 201);
            this.labelDeelnemerBadgeNummer.Name = "labelDeelnemerBadgeNummer";
            this.labelDeelnemerBadgeNummer.Size = new System.Drawing.Size(114, 20);
            this.labelDeelnemerBadgeNummer.TabIndex = 56;
            this.labelDeelnemerBadgeNummer.Text = "Badgenummer";
            // 
            // labelDeelnemerWoonplaats
            // 
            this.labelDeelnemerWoonplaats.AutoSize = true;
            this.labelDeelnemerWoonplaats.Location = new System.Drawing.Point(31, 166);
            this.labelDeelnemerWoonplaats.Name = "labelDeelnemerWoonplaats";
            this.labelDeelnemerWoonplaats.Size = new System.Drawing.Size(94, 20);
            this.labelDeelnemerWoonplaats.TabIndex = 55;
            this.labelDeelnemerWoonplaats.Text = "Woonplaats";
            // 
            // labelDeelnemerGeboortedatum
            // 
            this.labelDeelnemerGeboortedatum.AutoSize = true;
            this.labelDeelnemerGeboortedatum.Location = new System.Drawing.Point(31, 132);
            this.labelDeelnemerGeboortedatum.Name = "labelDeelnemerGeboortedatum";
            this.labelDeelnemerGeboortedatum.Size = new System.Drawing.Size(122, 20);
            this.labelDeelnemerGeboortedatum.TabIndex = 54;
            this.labelDeelnemerGeboortedatum.Text = "Geboortedatum";
            // 
            // labelDeelnemerNaam
            // 
            this.labelDeelnemerNaam.AutoSize = true;
            this.labelDeelnemerNaam.Location = new System.Drawing.Point(31, 98);
            this.labelDeelnemerNaam.Name = "labelDeelnemerNaam";
            this.labelDeelnemerNaam.Size = new System.Drawing.Size(51, 20);
            this.labelDeelnemerNaam.TabIndex = 53;
            this.labelDeelnemerNaam.Text = "Naam";
            // 
            // labelIdDeelnemer
            // 
            this.labelIdDeelnemer.AutoSize = true;
            this.labelIdDeelnemer.Location = new System.Drawing.Point(31, 64);
            this.labelIdDeelnemer.Name = "labelIdDeelnemer";
            this.labelIdDeelnemer.Size = new System.Drawing.Size(131, 20);
            this.labelIdDeelnemer.TabIndex = 52;
            this.labelIdDeelnemer.Text = "Id van deelnemer";
            // 
            // textBoxDeelnBadge
            // 
            this.textBoxDeelnBadge.Location = new System.Drawing.Point(275, 194);
            this.textBoxDeelnBadge.Name = "textBoxDeelnBadge";
            this.textBoxDeelnBadge.Size = new System.Drawing.Size(221, 26);
            this.textBoxDeelnBadge.TabIndex = 46;
            // 
            // textBoxDeelnWoon
            // 
            this.textBoxDeelnWoon.Location = new System.Drawing.Point(275, 160);
            this.textBoxDeelnWoon.Name = "textBoxDeelnWoon";
            this.textBoxDeelnWoon.Size = new System.Drawing.Size(221, 26);
            this.textBoxDeelnWoon.TabIndex = 45;
            // 
            // textBoxDeelnNaam
            // 
            this.textBoxDeelnNaam.Location = new System.Drawing.Point(275, 92);
            this.textBoxDeelnNaam.Name = "textBoxDeelnNaam";
            this.textBoxDeelnNaam.Size = new System.Drawing.Size(221, 26);
            this.textBoxDeelnNaam.TabIndex = 43;
            // 
            // textBoxDeelnId
            // 
            this.textBoxDeelnId.Location = new System.Drawing.Point(275, 58);
            this.textBoxDeelnId.Name = "textBoxDeelnId";
            this.textBoxDeelnId.Size = new System.Drawing.Size(221, 26);
            this.textBoxDeelnId.TabIndex = 42;
            // 
            // tabFeest
            // 
            this.tabFeest.Controls.Add(this.checkBoxVerlofNamiddag);
            this.tabFeest.Controls.Add(this.checkBoxVerlofVoormiddag);
            this.tabFeest.Controls.Add(this.dateTimePickerVerlof);
            this.tabFeest.Controls.Add(this.listBoxFeestdag);
            this.tabFeest.Controls.Add(this.buttonVerlofDel);
            this.tabFeest.Controls.Add(this.buttonVerlofUpd);
            this.tabFeest.Controls.Add(this.buttonVerlofAdd);
            this.tabFeest.Controls.Add(this.labelVerlofNamiddag);
            this.tabFeest.Controls.Add(this.labelVerlofVoormiddag);
            this.tabFeest.Controls.Add(this.labelVerlofDatum);
            this.tabFeest.Controls.Add(this.labelIdVerlof);
            this.tabFeest.Controls.Add(this.textBoxVerlofId);
            this.tabFeest.Location = new System.Drawing.Point(4, 29);
            this.tabFeest.Name = "tabFeest";
            this.tabFeest.Padding = new System.Windows.Forms.Padding(3);
            this.tabFeest.Size = new System.Drawing.Size(1046, 700);
            this.tabFeest.TabIndex = 2;
            this.tabFeest.Text = "Feestdagen";
            this.tabFeest.UseVisualStyleBackColor = true;
            // 
            // checkBoxVerlofNamiddag
            // 
            this.checkBoxVerlofNamiddag.AutoSize = true;
            this.checkBoxVerlofNamiddag.Location = new System.Drawing.Point(275, 164);
            this.checkBoxVerlofNamiddag.Name = "checkBoxVerlofNamiddag";
            this.checkBoxVerlofNamiddag.Size = new System.Drawing.Size(107, 24);
            this.checkBoxVerlofNamiddag.TabIndex = 64;
            this.checkBoxVerlofNamiddag.Text = "Namiddag";
            this.checkBoxVerlofNamiddag.UseVisualStyleBackColor = true;
            // 
            // checkBoxVerlofVoormiddag
            // 
            this.checkBoxVerlofVoormiddag.AutoSize = true;
            this.checkBoxVerlofVoormiddag.Location = new System.Drawing.Point(275, 130);
            this.checkBoxVerlofVoormiddag.Name = "checkBoxVerlofVoormiddag";
            this.checkBoxVerlofVoormiddag.Size = new System.Drawing.Size(121, 24);
            this.checkBoxVerlofVoormiddag.TabIndex = 63;
            this.checkBoxVerlofVoormiddag.Text = "Voormiddag";
            this.checkBoxVerlofVoormiddag.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerVerlof
            // 
            this.dateTimePickerVerlof.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVerlof.Location = new System.Drawing.Point(275, 92);
            this.dateTimePickerVerlof.MinDate = new System.DateTime(2019, 7, 17, 0, 0, 0, 0);
            this.dateTimePickerVerlof.Name = "dateTimePickerVerlof";
            this.dateTimePickerVerlof.Size = new System.Drawing.Size(221, 26);
            this.dateTimePickerVerlof.TabIndex = 62;
            this.dateTimePickerVerlof.Value = new System.DateTime(2019, 7, 17, 10, 40, 31, 0);
            // 
            // listBoxFeestdag
            // 
            this.listBoxFeestdag.FormattingEnabled = true;
            this.listBoxFeestdag.ItemHeight = 20;
            this.listBoxFeestdag.Location = new System.Drawing.Point(645, 43);
            this.listBoxFeestdag.Name = "listBoxFeestdag";
            this.listBoxFeestdag.Size = new System.Drawing.Size(358, 624);
            this.listBoxFeestdag.TabIndex = 61;
            this.listBoxFeestdag.SelectedIndexChanged += new System.EventHandler(this.ListBoxFeestdag_SelectedIndexChanged);
            // 
            // buttonVerlofDel
            // 
            this.buttonVerlofDel.Location = new System.Drawing.Point(374, 285);
            this.buttonVerlofDel.Name = "buttonVerlofDel";
            this.buttonVerlofDel.Size = new System.Drawing.Size(122, 50);
            this.buttonVerlofDel.TabIndex = 59;
            this.buttonVerlofDel.Text = "Verwijder";
            this.buttonVerlofDel.UseVisualStyleBackColor = true;
            this.buttonVerlofDel.Click += new System.EventHandler(this.ButtonVerlofDel_Click);
            // 
            // buttonVerlofUpd
            // 
            this.buttonVerlofUpd.Location = new System.Drawing.Point(204, 285);
            this.buttonVerlofUpd.Name = "buttonVerlofUpd";
            this.buttonVerlofUpd.Size = new System.Drawing.Size(122, 50);
            this.buttonVerlofUpd.TabIndex = 58;
            this.buttonVerlofUpd.Text = "Update";
            this.buttonVerlofUpd.UseVisualStyleBackColor = true;
            this.buttonVerlofUpd.Click += new System.EventHandler(this.ButtonVerlofUpd_Click);
            // 
            // buttonVerlofAdd
            // 
            this.buttonVerlofAdd.Location = new System.Drawing.Point(35, 285);
            this.buttonVerlofAdd.Name = "buttonVerlofAdd";
            this.buttonVerlofAdd.Size = new System.Drawing.Size(122, 50);
            this.buttonVerlofAdd.TabIndex = 57;
            this.buttonVerlofAdd.Text = "Voeg toe";
            this.buttonVerlofAdd.UseVisualStyleBackColor = true;
            this.buttonVerlofAdd.Click += new System.EventHandler(this.ButtonVerlofAdd_Click);
            // 
            // labelVerlofNamiddag
            // 
            this.labelVerlofNamiddag.AutoSize = true;
            this.labelVerlofNamiddag.Location = new System.Drawing.Point(31, 168);
            this.labelVerlofNamiddag.Name = "labelVerlofNamiddag";
            this.labelVerlofNamiddag.Size = new System.Drawing.Size(81, 20);
            this.labelVerlofNamiddag.TabIndex = 55;
            this.labelVerlofNamiddag.Text = "Namiddag";
            // 
            // labelVerlofVoormiddag
            // 
            this.labelVerlofVoormiddag.AutoSize = true;
            this.labelVerlofVoormiddag.Location = new System.Drawing.Point(31, 134);
            this.labelVerlofVoormiddag.Name = "labelVerlofVoormiddag";
            this.labelVerlofVoormiddag.Size = new System.Drawing.Size(95, 20);
            this.labelVerlofVoormiddag.TabIndex = 54;
            this.labelVerlofVoormiddag.Text = "Voormiddag";
            // 
            // labelVerlofDatum
            // 
            this.labelVerlofDatum.AutoSize = true;
            this.labelVerlofDatum.Location = new System.Drawing.Point(31, 98);
            this.labelVerlofDatum.Name = "labelVerlofDatum";
            this.labelVerlofDatum.Size = new System.Drawing.Size(57, 20);
            this.labelVerlofDatum.TabIndex = 53;
            this.labelVerlofDatum.Text = "Datum";
            // 
            // labelIdVerlof
            // 
            this.labelIdVerlof.AutoSize = true;
            this.labelIdVerlof.Location = new System.Drawing.Point(31, 64);
            this.labelIdVerlof.Name = "labelIdVerlof";
            this.labelIdVerlof.Size = new System.Drawing.Size(121, 20);
            this.labelIdVerlof.TabIndex = 52;
            this.labelIdVerlof.Text = "Id van verlofdag";
            // 
            // textBoxVerlofId
            // 
            this.textBoxVerlofId.Location = new System.Drawing.Point(275, 58);
            this.textBoxVerlofId.Name = "textBoxVerlofId";
            this.textBoxVerlofId.Size = new System.Drawing.Size(221, 26);
            this.textBoxVerlofId.TabIndex = 42;
            // 
            // tabDocent
            // 
            this.tabDocent.Controls.Add(this.listBoxDocent);
            this.tabDocent.Controls.Add(this.buttonDocentDel);
            this.tabDocent.Controls.Add(this.buttonDocentUpd);
            this.tabDocent.Controls.Add(this.buttonDocentAdd);
            this.tabDocent.Controls.Add(this.labelDocentBedrijf);
            this.tabDocent.Controls.Add(this.labelDocentNaam);
            this.tabDocent.Controls.Add(this.labelDocentId);
            this.tabDocent.Controls.Add(this.textBoxDocentBedrijf);
            this.tabDocent.Controls.Add(this.textBoxDocentNaam);
            this.tabDocent.Controls.Add(this.textBoxDocentId);
            this.tabDocent.Location = new System.Drawing.Point(4, 29);
            this.tabDocent.Name = "tabDocent";
            this.tabDocent.Padding = new System.Windows.Forms.Padding(3);
            this.tabDocent.Size = new System.Drawing.Size(1046, 700);
            this.tabDocent.TabIndex = 3;
            this.tabDocent.Text = "Docenten";
            this.tabDocent.UseVisualStyleBackColor = true;
            // 
            // listBoxDocent
            // 
            this.listBoxDocent.FormattingEnabled = true;
            this.listBoxDocent.ItemHeight = 20;
            this.listBoxDocent.Location = new System.Drawing.Point(645, 43);
            this.listBoxDocent.Name = "listBoxDocent";
            this.listBoxDocent.Size = new System.Drawing.Size(358, 624);
            this.listBoxDocent.TabIndex = 61;
            this.listBoxDocent.SelectedIndexChanged += new System.EventHandler(this.ListBoxDocent_SelectedIndexChanged);
            // 
            // buttonDocentDel
            // 
            this.buttonDocentDel.Location = new System.Drawing.Point(374, 244);
            this.buttonDocentDel.Name = "buttonDocentDel";
            this.buttonDocentDel.Size = new System.Drawing.Size(122, 50);
            this.buttonDocentDel.TabIndex = 57;
            this.buttonDocentDel.Text = "Verwijder";
            this.buttonDocentDel.UseVisualStyleBackColor = true;
            this.buttonDocentDel.Click += new System.EventHandler(this.ButtonDocentDel_Click);
            // 
            // buttonDocentUpd
            // 
            this.buttonDocentUpd.Location = new System.Drawing.Point(204, 244);
            this.buttonDocentUpd.Name = "buttonDocentUpd";
            this.buttonDocentUpd.Size = new System.Drawing.Size(122, 50);
            this.buttonDocentUpd.TabIndex = 56;
            this.buttonDocentUpd.Text = "Update";
            this.buttonDocentUpd.UseVisualStyleBackColor = true;
            this.buttonDocentUpd.Click += new System.EventHandler(this.ButtonDocentUpd_Click);
            // 
            // buttonDocentAdd
            // 
            this.buttonDocentAdd.Location = new System.Drawing.Point(35, 244);
            this.buttonDocentAdd.Name = "buttonDocentAdd";
            this.buttonDocentAdd.Size = new System.Drawing.Size(122, 50);
            this.buttonDocentAdd.TabIndex = 55;
            this.buttonDocentAdd.Text = "Voeg toe";
            this.buttonDocentAdd.UseVisualStyleBackColor = true;
            this.buttonDocentAdd.Click += new System.EventHandler(this.ButtonDocentAdd_Click);
            // 
            // labelDocentBedrijf
            // 
            this.labelDocentBedrijf.AutoSize = true;
            this.labelDocentBedrijf.Location = new System.Drawing.Point(31, 134);
            this.labelDocentBedrijf.Name = "labelDocentBedrijf";
            this.labelDocentBedrijf.Size = new System.Drawing.Size(54, 20);
            this.labelDocentBedrijf.TabIndex = 54;
            this.labelDocentBedrijf.Text = "Bedrijf";
            // 
            // labelDocentNaam
            // 
            this.labelDocentNaam.AutoSize = true;
            this.labelDocentNaam.Location = new System.Drawing.Point(31, 100);
            this.labelDocentNaam.Name = "labelDocentNaam";
            this.labelDocentNaam.Size = new System.Drawing.Size(51, 20);
            this.labelDocentNaam.TabIndex = 53;
            this.labelDocentNaam.Text = "Naam";
            // 
            // labelDocentId
            // 
            this.labelDocentId.AutoSize = true;
            this.labelDocentId.Location = new System.Drawing.Point(31, 64);
            this.labelDocentId.Name = "labelDocentId";
            this.labelDocentId.Size = new System.Drawing.Size(105, 20);
            this.labelDocentId.TabIndex = 52;
            this.labelDocentId.Text = "Id van docent";
            // 
            // textBoxDocentBedrijf
            // 
            this.textBoxDocentBedrijf.Location = new System.Drawing.Point(275, 128);
            this.textBoxDocentBedrijf.Name = "textBoxDocentBedrijf";
            this.textBoxDocentBedrijf.Size = new System.Drawing.Size(221, 26);
            this.textBoxDocentBedrijf.TabIndex = 44;
            // 
            // textBoxDocentNaam
            // 
            this.textBoxDocentNaam.Location = new System.Drawing.Point(275, 94);
            this.textBoxDocentNaam.Name = "textBoxDocentNaam";
            this.textBoxDocentNaam.Size = new System.Drawing.Size(221, 26);
            this.textBoxDocentNaam.TabIndex = 43;
            // 
            // textBoxDocentId
            // 
            this.textBoxDocentId.Location = new System.Drawing.Point(275, 58);
            this.textBoxDocentId.Name = "textBoxDocentId";
            this.textBoxDocentId.Size = new System.Drawing.Size(221, 26);
            this.textBoxDocentId.TabIndex = 42;
            // 
            // tabTijd
            // 
            this.tabTijd.Controls.Add(this.listBoxDeelnemersTijd);
            this.tabTijd.Controls.Add(this.labelTijdDeelnemerId);
            this.tabTijd.Controls.Add(this.labelTijdOpleidingId);
            this.tabTijd.Controls.Add(this.labelTijdDateTime);
            this.tabTijd.Controls.Add(this.labelTijdId);
            this.tabTijd.Controls.Add(this.textBoxTijdDeelnId);
            this.tabTijd.Controls.Add(this.textBoxTijdOplId);
            this.tabTijd.Controls.Add(this.textBoxTijdStip);
            this.tabTijd.Controls.Add(this.textBoxTijdId);
            this.tabTijd.Location = new System.Drawing.Point(4, 29);
            this.tabTijd.Name = "tabTijd";
            this.tabTijd.Padding = new System.Windows.Forms.Padding(3);
            this.tabTijd.Size = new System.Drawing.Size(1046, 700);
            this.tabTijd.TabIndex = 4;
            this.tabTijd.Text = "Tijdsregistraties";
            this.tabTijd.UseVisualStyleBackColor = true;
            // 
            // listBoxDeelnemersTijd
            // 
            this.listBoxDeelnemersTijd.FormattingEnabled = true;
            this.listBoxDeelnemersTijd.ItemHeight = 20;
            this.listBoxDeelnemersTijd.Location = new System.Drawing.Point(645, 43);
            this.listBoxDeelnemersTijd.Name = "listBoxDeelnemersTijd";
            this.listBoxDeelnemersTijd.Size = new System.Drawing.Size(358, 624);
            this.listBoxDeelnemersTijd.TabIndex = 61;
            // 
            // labelTijdDeelnemerId
            // 
            this.labelTijdDeelnemerId.AutoSize = true;
            this.labelTijdDeelnemerId.Location = new System.Drawing.Point(31, 168);
            this.labelTijdDeelnemerId.Name = "labelTijdDeelnemerId";
            this.labelTijdDeelnemerId.Size = new System.Drawing.Size(105, 20);
            this.labelTijdDeelnemerId.TabIndex = 55;
            this.labelTijdDeelnemerId.Text = "Deelnemer Id";
            // 
            // labelTijdOpleidingId
            // 
            this.labelTijdOpleidingId.AutoSize = true;
            this.labelTijdOpleidingId.Location = new System.Drawing.Point(31, 134);
            this.labelTijdOpleidingId.Name = "labelTijdOpleidingId";
            this.labelTijdOpleidingId.Size = new System.Drawing.Size(93, 20);
            this.labelTijdOpleidingId.TabIndex = 54;
            this.labelTijdOpleidingId.Text = "Opleiding Id";
            // 
            // labelTijdDateTime
            // 
            this.labelTijdDateTime.AutoSize = true;
            this.labelTijdDateTime.Location = new System.Drawing.Point(31, 100);
            this.labelTijdDateTime.Name = "labelTijdDateTime";
            this.labelTijdDateTime.Size = new System.Drawing.Size(58, 20);
            this.labelTijdDateTime.TabIndex = 53;
            this.labelTijdDateTime.Text = "Tijdstip";
            // 
            // labelTijdId
            // 
            this.labelTijdId.AutoSize = true;
            this.labelTijdId.Location = new System.Drawing.Point(31, 64);
            this.labelTijdId.Name = "labelTijdId";
            this.labelTijdId.Size = new System.Drawing.Size(154, 20);
            this.labelTijdId.TabIndex = 52;
            this.labelTijdId.Text = "Id van tijdsregistratie";
            // 
            // textBoxTijdDeelnId
            // 
            this.textBoxTijdDeelnId.Location = new System.Drawing.Point(275, 162);
            this.textBoxTijdDeelnId.Name = "textBoxTijdDeelnId";
            this.textBoxTijdDeelnId.Size = new System.Drawing.Size(221, 26);
            this.textBoxTijdDeelnId.TabIndex = 45;
            // 
            // textBoxTijdOplId
            // 
            this.textBoxTijdOplId.Location = new System.Drawing.Point(275, 128);
            this.textBoxTijdOplId.Name = "textBoxTijdOplId";
            this.textBoxTijdOplId.Size = new System.Drawing.Size(221, 26);
            this.textBoxTijdOplId.TabIndex = 44;
            // 
            // textBoxTijdStip
            // 
            this.textBoxTijdStip.Location = new System.Drawing.Point(275, 94);
            this.textBoxTijdStip.Name = "textBoxTijdStip";
            this.textBoxTijdStip.ReadOnly = true;
            this.textBoxTijdStip.Size = new System.Drawing.Size(221, 26);
            this.textBoxTijdStip.TabIndex = 43;
            // 
            // textBoxTijdId
            // 
            this.textBoxTijdId.Location = new System.Drawing.Point(275, 58);
            this.textBoxTijdId.Name = "textBoxTijdId";
            this.textBoxTijdId.Size = new System.Drawing.Size(221, 26);
            this.textBoxTijdId.TabIndex = 42;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxOpleiding});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1445, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // comboBoxOpleiding
            // 
            this.comboBoxOpleiding.Items.AddRange(new object[] {
            "Nieuwe opleiding aanmaken"});
            this.comboBoxOpleiding.Name = "comboBoxOpleiding";
            this.comboBoxOpleiding.Size = new System.Drawing.Size(242, 33);
            this.comboBoxOpleiding.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOpleiding_SelectedIndexChanged);
            // 
            // errorProviderOplInfoTab
            // 
            this.errorProviderOplInfoTab.ContainerControl = this;
            // 
            // BeheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 922);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "BeheerForm";
            this.Text = "Opleidingsbeheer";
            this.Load += new System.EventHandler(this.BeheerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOpl.ResumeLayout(false);
            this.tabOpl.PerformLayout();
            this.tabDeelnemers.ResumeLayout(false);
            this.tabDeelnemers.PerformLayout();
            this.tabFeest.ResumeLayout(false);
            this.tabFeest.PerformLayout();
            this.tabDocent.ResumeLayout(false);
            this.tabDocent.PerformLayout();
            this.tabTijd.ResumeLayout(false);
            this.tabTijd.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOplInfoTab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOpl;
        private System.Windows.Forms.TabPage tabDeelnemers;
        private System.Windows.Forms.TabPage tabFeest;
        private System.Windows.Forms.TabPage tabDocent;
        private System.Windows.Forms.TabPage tabTijd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox comboBoxOpleiding;
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
        private System.Windows.Forms.Label labelDeelnemerBadgeNummer;
        private System.Windows.Forms.Label labelDeelnemerWoonplaats;
        private System.Windows.Forms.Label labelDeelnemerGeboortedatum;
        private System.Windows.Forms.Label labelDeelnemerNaam;
        private System.Windows.Forms.Label labelIdDeelnemer;
        private System.Windows.Forms.TextBox textBoxDeelnBadge;
        private System.Windows.Forms.TextBox textBoxDeelnWoon;
        private System.Windows.Forms.TextBox textBoxDeelnNaam;
        private System.Windows.Forms.TextBox textBoxDeelnId;
        private System.Windows.Forms.Label labelVerlofNamiddag;
        private System.Windows.Forms.Label labelVerlofVoormiddag;
        private System.Windows.Forms.Label labelVerlofDatum;
        private System.Windows.Forms.Label labelIdVerlof;
        private System.Windows.Forms.TextBox textBoxVerlofId;
        private System.Windows.Forms.Label labelDocentBedrijf;
        private System.Windows.Forms.Label labelDocentNaam;
        private System.Windows.Forms.Label labelDocentId;
        private System.Windows.Forms.TextBox textBoxDocentBedrijf;
        private System.Windows.Forms.TextBox textBoxDocentNaam;
        private System.Windows.Forms.TextBox textBoxDocentId;
        private System.Windows.Forms.Label labelTijdDeelnemerId;
        private System.Windows.Forms.Label labelTijdOpleidingId;
        private System.Windows.Forms.Label labelTijdDateTime;
        private System.Windows.Forms.Label labelTijdId;
        private System.Windows.Forms.TextBox textBoxTijdDeelnId;
        private System.Windows.Forms.TextBox textBoxTijdOplId;
        private System.Windows.Forms.TextBox textBoxTijdStip;
        private System.Windows.Forms.TextBox textBoxTijdId;
        private System.Windows.Forms.Button buttonOplDel;
        private System.Windows.Forms.Button buttonOplUpd;
        private System.Windows.Forms.Button buttonOplCreate;
        private System.Windows.Forms.Button buttonDeelnemerDel;
        private System.Windows.Forms.Button buttonDeelnemerUpd;
        private System.Windows.Forms.Button buttonDeelnemerCreate;
        private System.Windows.Forms.Button buttonVerlofDel;
        private System.Windows.Forms.Button buttonVerlofUpd;
        private System.Windows.Forms.Button buttonVerlofAdd;
        private System.Windows.Forms.Button buttonDocentDel;
        private System.Windows.Forms.Button buttonDocentUpd;
        private System.Windows.Forms.Button buttonDocentAdd;
        private System.Windows.Forms.ListBox listBoxDeelnemers;
        private System.Windows.Forms.ListBox listBoxFeestdag;
        private System.Windows.Forms.ListBox listBoxDocent;
        private System.Windows.Forms.ListBox listBoxDeelnemersTijd;
        private System.Windows.Forms.DateTimePicker dateTimePickerOplEind;
        private System.Windows.Forms.DateTimePicker dateTimePickerOplStart;
        private System.Windows.Forms.ErrorProvider errorProviderOplInfoTab;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeelnGeb;
        private System.Windows.Forms.DateTimePicker dateTimePickerVerlof;
        private System.Windows.Forms.CheckBox checkBoxVerlofNamiddag;
        private System.Windows.Forms.CheckBox checkBoxVerlofVoormiddag;
    }
}

