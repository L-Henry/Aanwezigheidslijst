using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace Beheer
{
    public partial class BeheerForm : Form
    {
        public OpleidingsInformatie Opleiding { get; set; }

        bool IsValid = true;

        public BeheerForm()
        {
            InitializeComponent();
        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new DataContext())
            {
                foreach (var item in ctx.OpleidingsInformatie)
                {
                    comboBoxOpleiding.Items.Add(item.Opleiding);
                }
            }

  
        }



        //validatie opleidingsinformatie
        private void OplTab_Validating(object sender, CancelEventArgs e)
        {
            IsValid = true;
            if (dateTimePickerOplStart.Value.Date > dateTimePickerOplEind.Value.Date)
            {
                errorProviderOplInfoTab.SetError(dateTimePickerOplStart, "Startdatum moet voor einddatum liggen.");
                errorProviderOplInfoTab.SetError(dateTimePickerOplEind, "Einddatum moet na startdatum liggen.");
                IsValid = false;
            }
            else
            {
                errorProviderOplInfoTab.SetError(dateTimePickerOplStart, string.Empty);
                errorProviderOplInfoTab.SetError(dateTimePickerOplEind, string.Empty);
            }

            //inhoud van textboxes validaten
            foreach (TextBox textboxgen in tabControl1.SelectedTab.Controls.OfType<TextBox>())
            {
                OplTabTextBoxGen_Validating(textboxgen, null);
            }
            
            //check of oe en code nummers zijn
            if (textBoxOplOE.Text.Length > 0 && !textBoxOplOE.Text.All(c=>char.IsDigit(c)))
            {
                errorProviderOplInfoTab.SetError(textBoxOplOE, "Enkel cijfers invoeren.");
                IsValid = false;
            }
            else if (textBoxOplOE.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxOplOE, string.Empty);
            }
            if (textBoxOplCode.Text.Length > 0 && !textBoxOplCode.Text.All(c=>char.IsDigit(c)))
            {
                errorProviderOplInfoTab.SetError(textBoxOplCode, "Enkel cijfers invoeren.");
                IsValid = false;
            }
            else if (textBoxOplCode.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxOplCode, string.Empty);
            }
            //check of OE of code al bestaat
            List<OpleidingsInformatie> checkList = new List<OpleidingsInformatie>();
            using (var ctx = new DataContext())
            {
                foreach (var item in ctx.OpleidingsInformatie)
                {
                    checkList.Add(item);
                }
            }
            foreach (OpleidingsInformatie item in checkList)
            {
                if (item.OeNummer.ToString() == textBoxOplOE.Text)
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, "OE nummer bestaat al.");
                    IsValid = false;
                }
                else
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, string.Empty);

                }
                if (item.Opleidngscode.ToString() == textBoxOplCode.Text)
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, "Opleidingscode bestaat al.");
                    IsValid = false;
                }
                else
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, string.Empty);
                }
            }
        }
        private void OplTabTextBoxGen_Validating(object sender, CancelEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Name == "textBoxOplId")
            {

            }
            else if (t.Text.Length < 1)
            {
                errorProviderOplInfoTab.SetError(t, "Geen input.");
                IsValid = false;
            }
            else
            {
                errorProviderOplInfoTab.SetError(t, string.Empty);
            }
        }


        //wat gebeurd wanneer tabbladen geselecteerd worden
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    OpleidingsInformatie opl = new OpleidingsInformatie();
                    OpleidingsInformatie oplCombo = comboBoxOpleiding.SelectedItem as OpleidingsInformatie;
                    using (var ctx = new DataContext())
                    {
                        opl = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == oplCombo.Id);
                    }
                    textBoxOplId.Text = opl.Id.ToString();
                    textBoxOplInstelling.Text = opl.OpleidingsInstelling;
                    textBoxOpl.Text = opl.Opleiding;
                    textBoxOplPlaats.Text = opl.Contactpersoon;
                    textBoxOplRef.Text = opl.ReferentieOpledingsPlaats;
                    textBoxOplOE.Text = opl.OeNummer.ToString();
                    textBoxOplCode.Text = opl.Opleidngscode.ToString();
                    dateTimePickerOplStart.Value = opl.StartDatum;
                    dateTimePickerOplEind.Value = opl.EindDatum;
                    break;
                case 1:
                    List<Deelnemers> deelnLijst = new List<Deelnemers>();
                    using (var ctx = new DataContext())
                    {
                        deelnLijst = ctx.Deelnemers.ToList();               
                    }
                    foreach (Deelnemers item in deelnLijst)
                    {
                        listBoxDeelnemers.Items.Add(item);
                    }
                    break;
                case 2:
                    List<NietOpleidingsDagen> verlofLijst = new List<NietOpleidingsDagen>();
                    using (var ctx = new DataContext())
                    {
                        verlofLijst = ctx.NietOpleidingsDagen.ToList();
                        
                    }
                    foreach (NietOpleidingsDagen item in verlofLijst)
                    {
                        listBoxFeestdag.Items.Add(item);
                    }
                    break;
                case 3:
                    List<Docenten> docentLijst = new List<Docenten>();
                    using (var ctx = new DataContext())
                    {
                        docentLijst = ctx.Docenten.ToList();
                    }
                    foreach (Docenten item in docentLijst)
                    {
                        listBoxDocent.Items.Add(item);
                    }
                    break;
                case 4:
                    List<Deelnemers> tijdDeelnLijst = new List<Deelnemers>();
                    using (var ctx = new DataContext())
                    {
                        tijdDeelnLijst = ctx.Deelnemers.ToList();
                    }
                    foreach (Deelnemers item in tijdDeelnLijst)
                    {
                        listBoxDeelnemersTijd.Items.Add(item);
                    }
                    break;
                default:
                    break;
            }
        }

        private void ButtonOplCreate_Click(object sender, EventArgs e)
        {
            OplTab_Validating(sender, null);

            if (IsValid)
            {
                OpleidingsInformatie nieuweOpl = new OpleidingsInformatie
                {
                    OpleidingsInstelling = textBoxOplInstelling.Text,
                    Opleiding = textBoxOpl.Text,
                    Contactpersoon = textBoxOplContact.Text,
                    Opleidingsplaats = textBoxOplPlaats.Text,
                    ReferentieOpledingsPlaats = textBoxOplRef.Text,
                    OeNummer = int.Parse(textBoxOplOE.Text),
                    Opleidngscode = int.Parse(textBoxOplCode.Text),
                    StartDatum = dateTimePickerOplEind.Value,
                    EindDatum = dateTimePickerOplEind.Value
                };
                using (var ctx = new DataContext())
                {
                    ctx.OpleidingsInformatie.Add(nieuweOpl);
                    ctx.SaveChanges();
                    Opleiding = ctx.OpleidingsInformatie.Last();
                }
                textBoxOplId.Text = Opleiding.Id.ToString();
            }
        }

        private void ButtonOplUpd_Click(object sender, EventArgs e)
        {
            OplTab_Validating(sender, null);

            if (IsValid && textBoxOplId.Text != "")
            {
                using (var ctx = new DataContext())
                {
                    OpleidingsInformatie oplUpd = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == Opleiding.Id);

                    oplUpd.OpleidingsInstelling = textBoxOplInstelling.Text;
                    oplUpd.Opleiding = textBoxOpl.Text;
                    oplUpd.Contactpersoon = textBoxOplContact.Text;
                    oplUpd.Opleidingsplaats = textBoxOplPlaats.Text;
                    oplUpd.ReferentieOpledingsPlaats = textBoxOplRef.Text;
                    oplUpd.OeNummer = int.Parse(textBoxOplOE.Text);
                    oplUpd.Opleidngscode = int.Parse(textBoxOplCode.Text);
                    oplUpd.StartDatum = dateTimePickerOplEind.Value;
                    oplUpd.EindDatum = dateTimePickerOplEind.Value;

                    ctx.SaveChanges();
                }
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonOplUpd, "Creeër eerst nieuwe opleiding ipv up te daten.");
            }
        }

        private void ComboBoxOpleiding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
