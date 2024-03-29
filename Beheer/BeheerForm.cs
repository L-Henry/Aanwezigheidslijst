﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using System.Data.Entity;

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
        List<Tijdsregistraties> TijdLijst = new List<Tijdsregistraties>();

        bool IsValidOpl = true;
        bool IsValidDeeln = true;
        bool IsValidVerlof = true;
        bool IsValidDocent = true;

        public BeheerForm()
        {
            InitializeComponent();
        }

        private void BeheerForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MinimumSize = Size;

            using (var ctx = new DataContext())
            {
                OplLijst = ctx.OpleidingsInformatie.ToList();
                DeelnLijst = ctx.Deelnemers.ToList();
                VerlofLijst = ctx.NietOpleidingsDagen.ToList();
                DocentLijst = ctx.Docenten.ToList();
                DeelnOplLijst = ctx.DeelnemersOpleidingen.ToList();
                DocOplLijst = ctx.DocentenOpleiding.ToList();
                TijdLijst = ctx.Tijdsregistraties.ToList();
            }
            OplLijst = OplLijst.OrderBy(x => x.Opleiding).ToList();
            foreach (var opl in OplLijst)
            {
                comboBoxOpleiding.Items.Add(opl);
            }

            checkBoxVerlofVoormiddag.Checked = true;
            checkBoxVerlofNamiddag.Checked = true;
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
                tabControl1.SelectedIndex = 0;
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
            //using (var ctx = new DataContext())
            //{
            //    OplLijst = ctx.OpleidingsInformatie.ToList();
            //    DeelnLijst = ctx.Deelnemers.ToList();
            //    VerlofLijst = ctx.NietOpleidingsDagen.ToList();
            //    DocentLijst = ctx.Docenten.ToList();
            //    DeelnOplLijst = ctx.DeelnemersOpleidingen.ToList();
            //    DocOplLijst = ctx.DocentenOpleiding.ToList();
            //    TijdLijst = ctx.Tijdsregistraties.ToList();
            //}

            //deelnemers listbox vullen
            listBoxDeelnemers.Items.Add("Nieuwe deelnemer toevoegen");
            listBoxDeelnemersTijd.Items.Add("Allemaal");
            var deelLijst = (from d in DeelnLijst
                             join deelOpl in DeelnOplLijst on d.Id equals deelOpl.Deelnemer.Id
                             //join o in OplLijst on deelOpl.OpleidingsInformatie.Id equals o.Id
                             where deelOpl.OpleidingsInformatie.Id == Opleiding.Id
                             select d);
            deelLijst = deelLijst.OrderBy(x => x.Naam);
            foreach (var deeln in deelLijst)
            {
                listBoxDeelnemers.Items.Add(deeln);
                listBoxDeelnemersTijd.Items.Add(deeln); //om de deelnemers ook in tijdregsitratie tab te laden
            }

            //verlofdagen in listbox vullen
            listBoxFeestdag.Items.Add("Voeg nieuwe feestdag toe");
            var verlofLijst = (from v in VerlofLijst
                               where v.OpleidingsInformatie.Id == Opleiding.Id
                               select v);
            verlofLijst = verlofLijst.OrderBy(v => v.Datum.Date);
            foreach (var dag in verlofLijst)
            {
                listBoxFeestdag.Items.Add(dag);
            }
            checkBoxVerlofVoormiddag.Checked = true;
            checkBoxVerlofNamiddag.Checked = true;

            //docenten in listbox invullen
            listBoxDocent.Items.Add("Voeg nieuwe docent toe.");
            var docLijst = from d in DocentLijst
                           join docOpl in DocOplLijst on d.Id equals docOpl.Docenten.Id
                           where docOpl.OpleidingsInformatie.Id == Opleiding.Id
                           select d;
            docLijst = docLijst.OrderBy(d => d.Naam);
            foreach (var doc in docLijst)
            {
                listBoxDocent.Items.Add(doc);
            }

            //tijden invullen in tijdregistratie tab
            var tijdPerOpl = from t in TijdLijst
                             join opl in OplLijst on t.OpleidingsInformatie.Id equals opl.Id
                             where t.OpleidingsInformatie.Id == Opleiding.Id
                             select t;
            foreach (Tijdsregistraties item in tijdPerOpl)
            {
                listBoxTijd.Items.Add(item);
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

            //check of OE of code al bestaat. Moet enkel in toevoeg, niet in update.
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
            int delOpldId = int.Parse(textBoxOplId.Text);
            using (var ctx = new DataContext())
            {
                Opleiding = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == delOpldId);
                ctx.NietOpleidingsDagen.RemoveRange(ctx.NietOpleidingsDagen.Where(x => x.OpleidingsInformatie.Id == delOpldId));
                ctx.DeelnemersOpleidingen.RemoveRange(ctx.DeelnemersOpleidingen.Where(x => x.OpleidingsInformatie.Id == delOpldId));
                ctx.DocentenOpleiding.RemoveRange(ctx.DocentenOpleiding.Where(x => x.OpleidingsInformatie.Id == delOpldId));
                ctx.Tijdsregistraties.RemoveRange(ctx.Tijdsregistraties.Where(x => x.OpleidingsInformatie.Id == delOpldId));
                ctx.OpleidingsInformatie.Remove(Opleiding);
                ctx.SaveChanges();

                OplLijst = ctx.OpleidingsInformatie.OrderBy(x => x.Opleiding).ToList();
            }
            comboBoxOpleiding.Items.Clear();
            comboBoxOpleiding.Items.Add("Nieuwe opleiding aanmaken");
            foreach (var opl in OplLijst)
            {
                comboBoxOpleiding.Items.Add(opl);
            }
            comboBoxOpleiding.SelectedIndex = 0;
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
            if (!textBoxDeelnNaam.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) && textBoxDeelnNaam.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxDeelnNaam, "Gelidige naam bevat enkel letters en spatie");
                IsValidDeeln = false;
            }
            else if (textBoxDeelnNaam.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxDeelnNaam, string.Empty);
            }
            //check of badgenummer een nummer is
            if (!textBoxDeelnBadge.Text.All(c => char.IsDigit(c)) && textBoxDeelnBadge.Text.Length > 0)
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

            //check of badge nummer al bestaat, moet enkel in toevoegen, niet in updaten.
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
                errorProviderOplInfoTab.SetError(buttonDeelnemerCreate, "Selecteer of creeër eerst een opleiding om deelnemer aan toe tevoegen.");
            }
            else if (IsValidDeeln && textBoxDeelnId.Text == "")
            {
                if (DeelnLijst.Any(d => d.Naam.ToLower() == textBoxDeelnNaam.Text.ToLower() && d.GeboorteDatum.Date == dateTimePickerDeelnGeb.Value.Date))
                {
                    using (var ctx = new DataContext())
                    {
                        Opleiding = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == Opleiding.Id);
                        Deelnemers deelnUpd = ctx.Deelnemers.SingleOrDefault(x => x.Naam == textBoxDeelnNaam.Text && x.GeboorteDatum == dateTimePickerDeelnGeb.Value.Date);
                        deelnUpd.Woonplaats = textBoxDeelnWoon.Text;
                        deelnUpd.Badgenummer = int.Parse(textBoxDeelnBadge.Text);
                        ctx.DeelnemersOpleidingen.Add(new DeelnemersOpleidingen { Deelnemer = deelnUpd, OpleidingsInformatie = Opleiding });
                        ctx.SaveChanges();

                        DeelnLijst = ctx.Deelnemers.ToList();
                        DeelnOplLijst = ctx.DeelnemersOpleidingen.Include(x => x.Deelnemer).Include(x => x.OpleidingsInformatie).ToList();

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
                        Opleiding = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == Opleiding.Id);
                        ctx.Deelnemers.Add(nieuweDeeln);
                        ctx.DeelnemersOpleidingen.Add(new DeelnemersOpleidingen { Deelnemer = nieuweDeeln, OpleidingsInformatie = Opleiding });
                        ctx.SaveChanges();

                        DeelnLijst = ctx.Deelnemers.ToList();
                        DeelnOplLijst = ctx.DeelnemersOpleidingen.Include(x=>x.Deelnemer).Include(x=>x.OpleidingsInformatie).ToList();
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
                errorProviderOplInfoTab.SetError(buttonDeelnemerUpd, "Selecteer of creeër eerst een opleiding om deelnemer aan toe tevoegen.");
            }
            else if (IsValidDeeln && textBoxDeelnId.Text != "")
            {
                int deelnId = int.Parse(textBoxDeelnId.Text);
                using (var ctx = new DataContext())
                {
                    Deelnemers deelnUpd = ctx.Deelnemers.SingleOrDefault(x => x.Id == deelnId);
                    deelnUpd.Naam = textBoxDeelnNaam.Text;
                    deelnUpd.GeboorteDatum = dateTimePickerDeelnGeb.Value.Date;
                    deelnUpd.Woonplaats = textBoxDeelnWoon.Text;
                    deelnUpd.Badgenummer = int.Parse(textBoxDeelnBadge.Text);
                    ctx.SaveChanges();

                    DeelnLijst = ctx.Deelnemers.ToList();
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
                var delDeelnOpl = ctx.DeelnemersOpleidingen.SingleOrDefault(d => d.Deelnemer.Id == delPerId);
                ctx.DeelnemersOpleidingen.Remove(delDeelnOpl);
                ctx.Tijdsregistraties.RemoveRange(ctx.Tijdsregistraties.Where(d => d.Deelnemers.Id == delPerId));
                ctx.SaveChanges();

                TijdLijst = ctx.Tijdsregistraties.Include(x=>x.Deelnemers).Include(x=>x.OpleidingsInformatie).ToList();
                DeelnOplLijst = ctx.DeelnemersOpleidingen.Include(x => x.Deelnemer).Include(x => x.OpleidingsInformatie).ToList();
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


        //verlof dag tab validatie
        private void VerlofTab_validatie()
        {
            IsValidVerlof = true;
            //ligt verlofdag binnen oplieidng?
            if (dateTimePickerVerlof.Value.Date > Opleiding.EindDatum)
            {
                errorProviderOplInfoTab.SetError(dateTimePickerVerlof, "Datum ligt voorbij einddatum van deze opleiding.");
                IsValidVerlof = false;
            }
            else
            {
                errorProviderOplInfoTab.SetError(dateTimePickerVerlof, string.Empty);
            }
            //is ten minste een voormiddag of namiddag aangeduid
            if (!checkBoxVerlofNamiddag.Checked && !checkBoxVerlofVoormiddag.Checked)
            {
                errorProviderOplInfoTab.SetError(checkBoxVerlofVoormiddag, "Selecteer ten minste een voormiddag of namiddag.");
                errorProviderOplInfoTab.SetError(checkBoxVerlofNamiddag, "Selecteer ten minste een voormiddag of namiddag.");
                IsValidVerlof = false;
            }
            else
            {
                errorProviderOplInfoTab.SetError(checkBoxVerlofVoormiddag, string.Empty);
                errorProviderOplInfoTab.SetError(checkBoxVerlofNamiddag, string.Empty);
            }
        }

        private void ButtonVerlofAdd_Click(object sender, EventArgs e)
        {
            VerlofTab_validatie();

            //is deze datum al toegevoegd? ja -> update ipv toevoegen
            var verlofLijst = (from v in VerlofLijst
                               where v.OpleidingsInformatie.Id == Opleiding.Id
                               select v);
            verlofLijst = verlofLijst.OrderBy(v => v.Datum.Date);
            foreach (NietOpleidingsDagen item in verlofLijst)
            {
                if (item.Datum == dateTimePickerVerlof.Value.Date)
                {
                    errorProviderOplInfoTab.SetError(dateTimePickerVerlof, "Deze dag is al toegevoegd. Probeer update.");
                    IsValidVerlof = false;
                }
            }

            if (comboBoxOpleiding.SelectedIndex < 1)
            {
                errorProviderOplInfoTab.SetError(buttonVerlofAdd, "Selecteer of creeër eerst een opleiding om deelnemer aan toe tevoegen.");
            }
            else if (IsValidVerlof && textBoxVerlofId.Text == "")
            {
                using (var ctx = new DataContext())
                {
                    Opleiding = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == Opleiding.Id);
                    NietOpleidingsDagen nieuweVerlofDag = new NietOpleidingsDagen
                    {
                        Datum = dateTimePickerVerlof.Value.Date,
                        Voormiddag = checkBoxVerlofVoormiddag.Checked,
                        Namiddag = checkBoxVerlofNamiddag.Checked,
                        OpleidingsInformatie = Opleiding
                    };
                    ctx.NietOpleidingsDagen.Add(nieuweVerlofDag);
                    ctx.SaveChanges();

                    VerlofLijst = ctx.NietOpleidingsDagen.Include(x=>x.OpleidingsInformatie).ToList();
                }
                textBoxVerlofId.Text = VerlofLijst.Last().Id.ToString();

                ClearAll();
                LaadAlleListbox();
            }
            else if (textBoxVerlofId.Text != "")
            {
                errorProviderOplInfoTab.SetError(buttonVerlofAdd, "U probeert te updaten.");
            }
        }

        private void ButtonVerlofUpd_Click(object sender, EventArgs e)
        {
            VerlofTab_validatie();

            if (comboBoxOpleiding.SelectedIndex < 1)
            {
                errorProviderOplInfoTab.SetError(buttonVerlofUpd, "Selecteer of creeër eerst een opleiding om deelnemer aan toe tevoegen.");
            }
            else if (IsValidVerlof && textBoxVerlofId.Text != "")
            {
                int dagId = int.Parse(textBoxVerlofId.Text);
                using (var ctx = new DataContext())
                {
                    NietOpleidingsDagen updDag = ctx.NietOpleidingsDagen.SingleOrDefault(x => x.Id == dagId);
                    if (dateTimePickerVerlof.Value.Date != updDag.Datum)
                    {
                        errorProviderOplInfoTab.SetError(dateTimePickerVerlof, "Om datum te veranderen voeg een nieuwe verlofdag toe en verwijder de oude indien nodig.");
                    }
                    else
                    {
                        updDag.Voormiddag = checkBoxVerlofVoormiddag.Checked;
                        updDag.Namiddag = checkBoxVerlofNamiddag.Checked;
                        ctx.SaveChanges();

                        VerlofLijst = ctx.NietOpleidingsDagen.Include(x=>x.OpleidingsInformatie).ToList();
                    }
                }
                ClearAll();
                LaadAlleListbox();
            }
            else if (textBoxVerlofId.Text == "")
            {
                errorProviderOplInfoTab.SetError(buttonVerlofUpd, "U probeert een nieuwe datum toe te voegen.");
            }
        }

        private void ButtonVerlofDel_Click(object sender, EventArgs e)
        {

            int delVerlofId = int.Parse(textBoxVerlofId.Text);
            using (var ctx = new DataContext())
            {
                var delVerlof = ctx.NietOpleidingsDagen.SingleOrDefault(d => d.Id == delVerlofId);
                ctx.NietOpleidingsDagen.Remove(delVerlof);
                ctx.SaveChanges();

                VerlofLijst = ctx.NietOpleidingsDagen.Include(x => x.OpleidingsInformatie).ToList();
            }
            ClearAll();
            LaadAlleListbox();
        }

        private void ListBoxFeestdag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFeestdag.SelectedIndex > 0)
            {
                NietOpleidingsDagen verlofDag = listBoxFeestdag.SelectedItem as NietOpleidingsDagen;
                textBoxVerlofId.Text = verlofDag.Id.ToString();
                dateTimePickerVerlof.Value = verlofDag.Datum.Date;
                checkBoxVerlofVoormiddag.Checked = verlofDag.Voormiddag;
                checkBoxVerlofNamiddag.Checked = verlofDag.Namiddag;
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonVerlofAdd, string.Empty);

                textBoxVerlofId.Text = "";
                dateTimePickerVerlof.Value = DateTime.Today;
                checkBoxVerlofVoormiddag.Checked = true;
                checkBoxVerlofNamiddag.Checked = true;
            }
        }


        //validatie docent
        private void DocentTab_Validatie()
        {
            IsValidDocent = true;
            //inhoud van textboxes validaten, of er iets in staat
            foreach (TextBox textboxgen in tabControl1.SelectedTab.Controls.OfType<TextBox>())
            {
                if (textboxgen.Name.Contains("Id"))
                {

                }
                else if (textboxgen.Text.Length < 1)
                {
                    errorProviderOplInfoTab.SetError(textboxgen, "Geen input.");
                    IsValidDocent = false;
                }
                else
                {
                    errorProviderOplInfoTab.SetError(textboxgen, string.Empty);
                }
            }
            //check of naam enkel letter is
            if (!textBoxDocentNaam.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) && textBoxDocentNaam.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxDocentNaam, "Gelidige naam bevat enkel letters en spatie");
                IsValidDocent = false;
            }
            else if (textBoxDocentNaam.Text.Length > 0)
            {
                errorProviderOplInfoTab.SetError(textBoxDocentNaam, string.Empty);
            }
        }

        private void ButtonDocentAdd_Click(object sender, EventArgs e)
        {
            DocentTab_Validatie();

            if (comboBoxOpleiding.SelectedIndex < 1)
            {
                errorProviderOplInfoTab.SetError(buttonDocentAdd, "Selecteer of creeër eerst een opleiding om deelnemer aan toe tevoegen.");
            }
            else if (IsValidDocent && textBoxDocentId.Text == "")
            {
                if (DocentLijst.Any(d => d.Naam.ToLower() == textBoxDocentNaam.Text.ToLower() && d.Bedrijf.ToLower() == textBoxDocentBedrijf.Text.ToLower()))
                {
                    using (var ctx = new DataContext())
                    {
                        Opleiding = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == Opleiding.Id);
                        Docenten docentUpd = ctx.Docenten.SingleOrDefault(x => x.Naam.ToLower() == textBoxDocentNaam.Text.ToLower() 
                                                                            && x.Bedrijf.ToLower() == textBoxDocentBedrijf.Text.ToLower());
                        ctx.DocentenOpleiding.Add(new DocentenOpleiding { Docenten = docentUpd, OpleidingsInformatie = Opleiding });
                        ctx.SaveChanges();

                        DocOplLijst = ctx.DocentenOpleiding.Include(x=>x.Docenten).Include(x=>x.OpleidingsInformatie).ToList();
                    }
                }
                else
                {
                    Docenten nieuweDoc = new Docenten
                    {
                        Naam = textBoxDocentNaam.Text,
                        Bedrijf = textBoxDocentBedrijf.Text,
                    };
                    using (var ctx = new DataContext())
                    {
                        Opleiding = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == Opleiding.Id);
                        ctx.Docenten.Add(nieuweDoc);
                        ctx.DocentenOpleiding.Add(new DocentenOpleiding { Docenten = nieuweDoc, OpleidingsInformatie = Opleiding });
                        ctx.SaveChanges();

                        DocOplLijst = ctx.DocentenOpleiding.Include(x => x.Docenten).Include(x => x.OpleidingsInformatie).ToList();
                        DocentLijst = ctx.Docenten.ToList();
                    }
                    textBoxDocentId.Text = DocentLijst.Last().Id.ToString();
                }
                ClearAll();
                LaadAlleListbox();
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonDocentAdd, "U probeert te updaten.");
            }

        }

        private void ButtonDocentUpd_Click(object sender, EventArgs e)
        {
            DocentTab_Validatie();

            if (comboBoxOpleiding.SelectedIndex <= 1)
            {
                errorProviderOplInfoTab.SetError(buttonDocentUpd, "Selecteer of creeër eerst een opleiding om deelnemer aan toe tevoegen.");
            }
            else if (IsValidDocent && textBoxDocentId.Text != "")
            {
                int docId = int.Parse(textBoxDocentId.Text);
                using (var ctx = new DataContext())
                {
                    Docenten docUpd = ctx.Docenten.SingleOrDefault(x => x.Id == docId);
                    docUpd.Naam = textBoxDocentNaam.Text;
                    docUpd.Bedrijf = textBoxDocentBedrijf.Text;
                    ctx.SaveChanges();

                    DocentLijst = ctx.Docenten.ToList();
                }
                ClearAll();
                LaadAlleListbox();
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonDocentUpd, "U probeert een nieuwe deelnemer toe te voegen..");
            }
        }

        private void ButtonDocentDel_Click(object sender, EventArgs e)
        {
            int delDocId = int.Parse(textBoxDocentId.Text);
            using (var ctx = new DataContext())
            {
                var delDocOpl = ctx.DocentenOpleiding.SingleOrDefault(d => d.Docenten.Id == delDocId);
                ctx.DocentenOpleiding.Remove(delDocOpl);
                ctx.SaveChanges();

                //DocentLijst = ctx.Docenten.ToList();
                DocOplLijst = ctx.DocentenOpleiding.Include(x => x.Docenten).Include(x => x.OpleidingsInformatie).ToList();
            }
            ClearAll();
            LaadAlleListbox();
        }

        private void ListBoxDocent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDocent.SelectedIndex > 0)
            {
                Docenten docent = listBoxDocent.SelectedItem as Docenten;
                textBoxDocentId.Text = docent.Id.ToString();
                textBoxDocentNaam.Text = docent.Naam;
                textBoxDocentBedrijf.Text = docent.Bedrijf;
            }
            else
            {
                errorProviderOplInfoTab.SetError(buttonDocentAdd, string.Empty);

                textBoxDocentId.Text = "";
                textBoxDocentNaam.Text = "";
                textBoxDocentBedrijf.Text = "";
            }
        }


        //Tijdregistraties
        private void ListBoxDeelnemersTijd_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTijd.Items.Clear();

            if (listBoxDeelnemersTijd.SelectedIndex > 0)
            {
                Deelnemers deeln = listBoxDeelnemersTijd.SelectedItem as Deelnemers;
                var tijdPerDeeln = from t in TijdLijst
                                   join opl in OplLijst on t.OpleidingsInformatie.Id equals opl.Id
                                   where t.Deelnemers.Id == deeln.Id
                                   select t;

                textBoxTijdNaamDeeln.Text = deeln.Naam;

                foreach (Tijdsregistraties item in tijdPerDeeln)
                {
                    listBoxTijd.Items.Add(item);
                }
            }
            else
            {
                var tijdPerOpl = from t in TijdLijst
                                 join opl in OplLijst on t.OpleidingsInformatie.Id equals opl.Id
                                 where t.OpleidingsInformatie.Id == Opleiding.Id
                                 select t;
                foreach (Tijdsregistraties item in tijdPerOpl)
                {
                    listBoxTijd.Items.Add(item);
                }
            }
        }

        private void DateTimePickerTijdregistraties_ValueChanged(object sender, EventArgs e)
        {
            if (Opleiding != null)
            {
                listBoxTijd.Items.Clear();
                if (listBoxDeelnemersTijd.SelectedIndex < 1)
                {
                    var tijdPerOpl = from t in TijdLijst
                                     join opl in OplLijst on t.OpleidingsInformatie.Id equals opl.Id
                                     where t.OpleidingsInformatie.Id == Opleiding.Id
                                     where t.DateTime.Date == dateTimePickerTijdregistraties.Value.Date
                                     select t;
                    foreach (Tijdsregistraties item in tijdPerOpl)
                    {
                        listBoxTijd.Items.Add(item);
                    }
                }
                else
                {
                    Deelnemers deeln = listBoxDeelnemersTijd.SelectedItem as Deelnemers;
                    var tijdPerDeeln = from t in TijdLijst
                                       join opl in OplLijst on t.OpleidingsInformatie.Id equals opl.Id
                                       where t.Deelnemers.Id == deeln.Id
                                       where t.DateTime.Date == dateTimePickerTijdregistraties.Value.Date
                                       select t;
                    foreach (Tijdsregistraties item in tijdPerDeeln)
                    {
                        listBoxTijd.Items.Add(item);
                    }
                }
            }
        }

        private void ListBoxTijd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTijd.SelectedIndex > -1)
            {
                Tijdsregistraties tijdr = listBoxTijd.SelectedItem as Tijdsregistraties;
                Deelnemers deeln = tijdr.Deelnemers as Deelnemers;
                var tijdPerDeeln = from t in TijdLijst
                                   join opl in OplLijst on t.OpleidingsInformatie.Id equals opl.Id
                                   where t.Deelnemers.Id == deeln.Id
                                   select t;

                textBoxTijdNaamDeeln.Text = deeln.Naam;

                int tijdIndex = tijdPerDeeln.Select((item, index) => new { item, index }).Single(p => p.item.Id == tijdr.Id).index;

                if (tijdIndex % 2 == 0)
                {
                    textBoxTijdBadgeStatus.Text = "Badge In";
                    textBoxTijdStip.Text = "";
                    checkBoxTijdVoorm.Checked = false;
                    checkBoxTijdNam.Checked = false;
                }
                else
                {
                    textBoxTijdBadgeStatus.Text = "Badge Out";
                    TimeSpan tijdAanwezig = tijdPerDeeln.ElementAt(tijdIndex).DateTime - tijdPerDeeln.ElementAt(tijdIndex - 1).DateTime;
                    textBoxTijdStip.Text = tijdAanwezig.ToString();

                    if (tijdAanwezig > new TimeSpan(8,0,0))
                    {
                        checkBoxTijdVoorm.Checked = true;
                        checkBoxTijdNam.Checked = true;
                    }
                    else if (tijdAanwezig > new TimeSpan(3,0,0) && tijdPerDeeln.ElementAt(tijdIndex).DateTime.Hour < 14) 
                    {
                        checkBoxTijdVoorm.Checked = true;
                        checkBoxTijdNam.Checked = false;
                    }
                    else if (tijdAanwezig > new TimeSpan(3, 0, 0) && tijdPerDeeln.ElementAt(tijdIndex).DateTime.Hour > 14)
                    {
                        checkBoxTijdVoorm.Checked = false;
                        checkBoxTijdNam.Checked = true;
                    }
                    else
                    {
                        checkBoxTijdVoorm.Checked = false;
                        checkBoxTijdNam.Checked = false;
                    }
                }
            }
            else
            {
                textBoxTijdStip.Text = "";
                textBoxTijdBadgeStatus.Text = "";
                checkBoxTijdNam.Checked = false;
                checkBoxTijdVoorm.Checked = false;         
            }
        }
    }
}

