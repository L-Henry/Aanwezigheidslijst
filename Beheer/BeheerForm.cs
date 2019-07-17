using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        OpleidingsInformatie Opleiding { get; set; }
        List<OpleidingsInformatie> OplLijst = new List<OpleidingsInformatie>();
        List<Deelnemers> DeelnLijst = new List<Deelnemers>();
        List<NietOpleidingsDagen> VerlofLijst = new List<NietOpleidingsDagen>();
        List<Docenten> DocentLijst = new List<Docenten>();
        List<DeelnemersOpleidingen> DeelnOplLijst = new List<DeelnemersOpleidingen>();
        List<DocentenOpleiding> DocOplLijst = new List<DocentenOpleiding>();

        bool IsValidOpl = true;
        bool IsValidDeeln = true;

        public BeheerForm()
        {
            InitializeComponent();
        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {
            using (var ctx = new DataContext())
            {
                OplLijst = ctx.OpleidingsInformatie.ToList();
                DeelnLijst = ctx.Deelnemers.ToList();
                VerlofLijst = ctx.NietOpleidingsDagen.ToList();
                DocentLijst = ctx.Docenten.ToList();
                DeelnOplLijst = ctx.DeelnemersOpleidingen.ToList();
                DocOplLijst = ctx.DocentenOpleiding.ToList();
            }
            OplLijst = OplLijst.OrderBy(x => x.Opleiding).ToList();
            foreach (var opl in OplLijst)
            {
                comboBoxOpleiding.Items.Add(opl);
            }
        }

        //combobox selectie
        private void ComboBoxOpleiding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOpleiding.SelectedIndex == -1)
            {
                ClearAll(); //of niets doen
            }
            else if (comboBoxOpleiding.SelectedIndex == 0)
            {
                ClearAll();
                LaadAlleListbox();
            }
            else
            {
                ClearAll();

                OpleidingsInformatie comboOpl = comboBoxOpleiding.SelectedItem as OpleidingsInformatie;
                Opleiding = OplLijst.SingleOrDefault(x => x.Id == comboOpl.Id);

                textBoxOplId.Text = Opleiding.Id.ToString();
                textBoxOplInstelling.Text = Opleiding.OpleidingsInstelling;
                textBoxOpl.Text = Opleiding.Opleiding;
                textBoxOplContact.Text = Opleiding.Contactpersoon;
                textBoxOplPlaats.Text = Opleiding.Opleidingsplaats;
                textBoxOplRef.Text = Opleiding.ReferentieOpledingsPlaats;
                textBoxOplOE.Text = Opleiding.OeNummer.ToString();
                textBoxOplCode.Text = Opleiding.Opleidngscode.ToString();
                dateTimePickerOplStart.Value = Opleiding.StartDatum.Date;
                dateTimePickerOplEind.Value = Opleiding.EindDatum.Date;

                LaadAlleListbox();
            }
        }
        // alle listboxen vullen
        private void LaadAlleListbox()
        {
            using (var ctx = new DataContext())
            {
                OplLijst = ctx.OpleidingsInformatie.ToList();
                DeelnLijst = ctx.Deelnemers.ToList();
                VerlofLijst = ctx.NietOpleidingsDagen.ToList();
                DocentLijst = ctx.Docenten.ToList();
                DeelnOplLijst = ctx.DeelnemersOpleidingen.ToList();
                DocOplLijst = ctx.DocentenOpleiding.ToList();
            }

            listBoxDeelnemers.Items.Add("Nieuwe deelnemer toevoegen");
            //deelnemers listbox vullen
            var deelLijst = (from d in DeelnLijst
                             join deelOpl in DeelnOplLijst on d.Id equals deelOpl.Deelnemer.Id
                             //join o in OplLijst on deelOpl.OpleidingsInformatie.Id equals o.Id
                             where deelOpl.OpleidingsInformatie.Id == Opleiding.Id
                             select d);
            deelLijst = deelLijst.OrderBy(x => x.Naam);
            foreach (var deeln in deelLijst)
            {
                listBoxDeelnemers.Items.Add(deeln);
            }

        }
        // alle listboxen en textboxen leegmaken voor creatie nieuwe opleiding
        private void ClearAll()
        {
            foreach (TabPage tab in tabControl1.Controls)
            {
                foreach (Control item in tab.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Text = string.Empty;
                    }
                    if (item is ListBox)
                    {
                        (item as ListBox).Items.Clear();
                    }
                    if (item is DateTimePicker)
                    {
                        (item as DateTimePicker).Value = DateTime.Today;
                    }
                }
            }
        }

        //validatie opleidingsinformatie
        private void OplTab_Validating()
        {
            IsValidOpl = true;
            if (dateTimePickerOplStart.Value.Date > dateTimePickerOplEind.Value.Date)
            {
                errorProviderOplInfoTab.SetError(dateTimePickerOplStart, "Startdatum moet voor einddatum liggen.");
                errorProviderOplInfoTab.SetError(dateTimePickerOplEind, "Einddatum moet na startdatum liggen.");
                IsValidOpl = false;
            }
            else
            {
                errorProviderOplInfoTab.SetError(dateTimePickerOplStart, string.Empty);
                errorProviderOplInfoTab.SetError(dateTimePickerOplEind, string.Empty);
            }
            //inhoud van textboxes validaten, of er iets in staat
            foreach (TextBox textboxgen in tabControl1.SelectedTab.Controls.OfType<TextBox>())
            {
                if (textboxgen.Name.Contains("Id"))
                {

                }
                else if (textboxgen.Text.Length < 1)
                {
                    errorProviderOplInfoTab.SetError(textboxgen, "Geen input.");
                    IsValidOpl = false;
                }
                else
                {
                    errorProviderOplInfoTab.SetError(textboxgen, string.Empty);
                }
            }
            //check of oe en code nummers zijn
            if (textBoxOplOE.Text.Length > 0 && !textBoxOplOE.Text.All(c => char.IsDigit(c)))
            {
                errorProviderOplInfoTab.SetError(textBoxOplOE, "Enkel cijfers invoeren.");
                IsValidOpl = false;
            }
            else if (textBoxOplOE.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxOplOE, string.Empty);
            }
            if (textBoxOplCode.Text.Length > 0 && !textBoxOplCode.Text.All(c => char.IsDigit(c)))
            {
                errorProviderOplInfoTab.SetError(textBoxOplCode, "Enkel cijfers invoeren.");
                IsValidOpl = false;
            }
            else if (textBoxOplCode.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxOplCode, string.Empty);
            }
        }   

        // buttons opleidingsinfo tabblad
        private void ButtonOplCreate_Click(object sender, EventArgs e)
        {
            OplTab_Validating();

            //check of OE of code al bestaat
            foreach (OpleidingsInformatie item in OplLijst)
            {
                if (item.OeNummer.ToString() == textBoxOplOE.Text)
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, "OE nummer bestaat al.");
                    IsValidOpl = false;
                }
                else
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, string.Empty);
                }
                if (item.Opleidngscode.ToString() == textBoxOplCode.Text)
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, "Opleidingscode bestaat al.");
                    IsValidOpl = false;
                }
                else
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, string.Empty);
                }
            }

            if (IsValidOpl && textBoxOplId.Text == "")// && ( comboBoxOpleiding.SelectedIndex == 0 || comboBoxOpleiding.SelectedIndex == -1)) //mogelijk nodig
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
                    StartDatum = dateTimePickerOplStart.Value,
                    EindDatum = dateTimePickerOplEind.Value
                };
                using (var ctx = new DataContext())
                {
                    ctx.OpleidingsInformatie.Add(nieuweOpl);
                    ctx.SaveChanges();
                    OplLijst = ctx.OpleidingsInformatie.ToList();
                }
                Opleiding = OplLijst.Last();
                textBoxOplId.Text = Opleiding.Id.ToString();
                comboBoxOpleiding.Items.Add(Opleiding);
                OplLijst = OplLijst.OrderBy(x => x.Opleiding).ToList();
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonOplCreate, "Selecteer eerst creeër nieuwe opleiding in menu.");
            }
        }

        private void ButtonOplUpd_Click(object sender, EventArgs e)
        {
            OplTab_Validating();

            if (IsValidOpl && textBoxOplId.Text != "")
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
                    oplUpd.StartDatum = dateTimePickerOplStart.Value;
                    oplUpd.EindDatum = dateTimePickerOplEind.Value;

                    ctx.SaveChanges();
                    OplLijst = ctx.OpleidingsInformatie.ToList();
                }
                Opleiding = OplLijst.Last();
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonOplUpd, "Creeër eerst nieuwe opleiding ipv up te daten.");
            }
        }
        //verwijder opleiding
        private void ButtonOplDel_Click(object sender, EventArgs e)
        {

        }



        //deelnemers tabblad validating
        private void DeelnTab_Validating()
        {
            IsValidDeeln = true;
            //inhoud van textboxes validaten, of er iets in staat
            foreach (TextBox textboxgen in tabControl1.SelectedTab.Controls.OfType<TextBox>())
            {
                if (textboxgen.Name.Contains("Id"))
                {

                }
                else if (textboxgen.Text.Length < 1)
                {
                    errorProviderOplInfoTab.SetError(textboxgen, "Geen input.");
                    IsValidDeeln = false;
                }
                else
                {
                    errorProviderOplInfoTab.SetError(textboxgen, string.Empty);
                }
            }
            //check of naam enkel letter is
            if (!textBoxDeelnNaam.Text.All(c=>char.IsLetter(c) || char.IsWhiteSpace(c) ) && textBoxDeelnNaam.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxDeelnNaam, "Gelidige naam bevat enkel letters en spatie");
                IsValidDeeln = false;
            }
            else if (textBoxDeelnNaam.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxDeelnNaam, string.Empty);
            }
            //check of badgenummer een nummer is
            if (!textBoxDeelnBadge.Text.All(c => char.IsDigit(c)) && textBoxDeelnBadge.Text.Length > 0 )
            {
                errorProviderOplInfoTab.SetError(textBoxDeelnBadge, "Enkel cijfers invoeren.");
                IsValidDeeln = false;
            }
            else if (textBoxDeelnBadge.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxDeelnBadge, string.Empty);
            }
        }

        //buttons deelnemer tabblad
        private void ButtonDeelnemerCreate_Click(object sender, EventArgs e)
        {
            DeelnTab_Validating();

            //check of badge nummer al bestaat
            foreach (Deelnemers item in DeelnLijst)
            {
                if (item.Badgenummer.ToString() == textBoxDeelnBadge.Text)
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, "Badge nummer bestaat al.");
                    IsValidOpl = false;
                }
                else
                {
                    errorProviderOplInfoTab.SetError(textBoxOplOE, string.Empty);
                }
            }

            if (comboBoxOpleiding.SelectedIndex < 1)
            {
                errorProviderOplInfoTab.SetError(toolStrip1, "Selecteer of creeër eerst een opleiding om deelnemer aan toe tevoegen.");
            }

            else if (IsValidDeeln && textBoxDeelnId.Text == "")
            {
                if (DeelnLijst.Any(d=>d.Naam.ToLower() == textBoxDeelnNaam.Text.ToLower() && d.GeboorteDatum.Date == dateTimePickerDeelnGeb.Value.Date ))
                {
                    using (var ctx = new DataContext())
                    {
                        Deelnemers deelnUpd = ctx.Deelnemers.SingleOrDefault(x => x.Naam == textBoxDeelnNaam.Text);
                        deelnUpd.Woonplaats = textBoxDeelnWoon.Text;
                        deelnUpd.Badgenummer = int.Parse(textBoxDeelnBadge.Text);
                        ctx.DeelnemersOpleidingen.Add(new DeelnemersOpleidingen { Deelnemer = deelnUpd, OpleidingsInformatie = Opleiding });
                        ctx.SaveChanges();

                        DeelnLijst = ctx.Deelnemers.ToList();
                    }
                }
                else
                {
                    Deelnemers nieuweDeeln = new Deelnemers
                    {
                        Naam = textBoxDeelnNaam.Text,
                        GeboorteDatum = dateTimePickerDeelnGeb.Value.Date,
                        Woonplaats = textBoxDeelnWoon.Text,
                        Badgenummer = int.Parse(textBoxDeelnBadge.Text)
                    };
                    using (var ctx = new DataContext())
                    {
                        Opleiding = ctx.OpleidingsInformatie.SingleOrDefault(x=>x.Id == Opleiding.Id);
                        ctx.Deelnemers.Add(nieuweDeeln);
                        ctx.DeelnemersOpleidingen.Add(new DeelnemersOpleidingen { Deelnemer = nieuweDeeln, OpleidingsInformatie = Opleiding });
                        ctx.SaveChanges();

                        DeelnLijst = ctx.Deelnemers.ToList();
                    }
                    textBoxDeelnId.Text = DeelnLijst.Last().Id.ToString();
                }
                ClearAll();
                LaadAlleListbox();
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonDeelnemerCreate, "U probeert te updaten.");
            }
        }

        private void ButtonDeelnemerUpd_Click(object sender, EventArgs e)
        {
            DeelnTab_Validating();

            if (comboBoxOpleiding.SelectedIndex <= 1)
            {
                errorProviderOplInfoTab.SetError(toolStrip1, "Selecteer of creeër eerst een opleiding om deelnemer aan toe tevoegen.");
            }
            else if (IsValidDeeln && textBoxDeelnId.Text != "")
            {
                using (var ctx = new DataContext())
                {
                    Deelnemers deelnUpd = ctx.Deelnemers.SingleOrDefault(x => x.Id == int.Parse(textBoxDeelnId.Text));
                    deelnUpd.Naam = textBoxDeelnNaam.Text;
                    deelnUpd.GeboorteDatum = dateTimePickerDeelnGeb.Value.Date;
                    deelnUpd.Woonplaats = textBoxDeelnWoon.Text;
                    deelnUpd.Badgenummer = int.Parse(textBoxDeelnBadge.Text);
                    ctx.SaveChanges();
                }
                ClearAll();
                LaadAlleListbox();
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonOplUpd, "U probeert een nieuwe deelnemer toe te voegen..");
            }
        }

        private void ButtonDeelnemerDel_Click(object sender, EventArgs e)
        {
            //Deelnemers deelnemer = listBoxDeelnemers.SelectedItem as Deelnemers;
            int delPerId = int.Parse(textBoxDeelnId.Text);
            using (var ctx = new DataContext())
            {
                var delDeelnOpl = ctx.DeelnemersOpleidingen/*.Include(a=>a.Deelnemer).Include(o=>o.OpleidingsInformatie)*/.SingleOrDefault(d => d.Deelnemer.Id == delPerId);
                ctx.DeelnemersOpleidingen.Remove(delDeelnOpl);
                ctx.SaveChanges();
            }
            ClearAll();
            LaadAlleListbox();
        }

        private void ListBoxDeelnemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDeelnemers.SelectedIndex > 0)
            {
                Deelnemers deelnemer = listBoxDeelnemers.SelectedItem as Deelnemers;
                textBoxDeelnId.Text = deelnemer.Id.ToString();
                textBoxDeelnNaam.Text = deelnemer.Naam;
                dateTimePickerDeelnGeb.Value = deelnemer.GeboorteDatum.Date;
                textBoxDeelnWoon.Text = deelnemer.Woonplaats;
                textBoxDeelnBadge.Text = deelnemer.Badgenummer.ToString();
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonDeelnemerCreate, string.Empty);

                textBoxDeelnId.Text = "";
                textBoxDeelnNaam.Text = "";
                dateTimePickerDeelnGeb.Value = DateTime.Today;
                textBoxDeelnWoon.Text = "";
                textBoxDeelnBadge.Text = "";
            }
        }
    }
}








//wat gebeurd wanneer tabbladen geselecteerd worden
/*
private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
{
    switch (tabControl1.SelectedIndex)
    {
        case 0:
            OpleidingsInformatie opl = new OpleidingsInformatie();
            OpleidingsInformatie oplCombo = comboBoxOpleiding.SelectedItem as OpleidingsInformatie;

            if (comboBoxOpleiding.SelectedIndex != -1)
            {
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
            }
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
}*/
