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

namespace Tijdregistratie
{
    public partial class TijdForm : Form
    {
        List<Deelnemers> DeelnLijst = new List<Deelnemers>();
        List<DeelnemersOpleidingen> DeelnOplLijst = new List<DeelnemersOpleidingen>();
        List<OpleidingsInformatie> OplLijst = new List<OpleidingsInformatie>();
        List<Tijdsregistraties> TijdLijst = new List<Tijdsregistraties>();
        OpleidingsInformatie Opleiding = new OpleidingsInformatie();

        public TijdForm()
        {
            InitializeComponent();
        }

        private void TijdForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            MinimumSize = Size;

            using (var ctx = new DataContext())
            {
                DeelnLijst = ctx.Deelnemers.ToList();
                DeelnOplLijst = ctx.DeelnemersOpleidingen.ToList();
                OplLijst = ctx.OpleidingsInformatie.ToList();
                TijdLijst = ctx.Tijdsregistraties.ToList();
            }
            OplLijst = OplLijst.OrderBy(x => x.Opleiding).ToList();
            foreach (var opl in OplLijst)
            {
                comboBoxOpl.Items.Add(opl);
            }

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelTijd.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void ComboBoxOpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteButtons();

            if (comboBoxOpl.SelectedIndex == -1)
            {
                // doe niets
            }
            else
            {

                OpleidingsInformatie comboOpl = comboBoxOpl.SelectedItem as OpleidingsInformatie;
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

                CreateButtons();
            }
        }

        private void CreateButtons()
        {
            var deeln = from d in DeelnLijst
                        join dOpl in DeelnOplLijst on d.Id equals dOpl.Deelnemer.Id
                        where dOpl.OpleidingsInformatie.Id == Opleiding.Id
                        select d;

            int tellerX = 0;
            int tellerY = 0;
            foreach (Deelnemers item in deeln)
            {
                Label label = new Label();
                label.Location = new Point(22 + tellerX * 140, 200 + tellerY * 150);
                label.Text = item.Naam;
                label.Name = "t" + item.Naam + item.Id;

                Button dynamicButton = new Button();
                dynamicButton.Height = 90;
                dynamicButton.Width = 110;
                dynamicButton.Location = new Point(22 + tellerX * 140, 225 + tellerY * 150);
                dynamicButton.Text = "Badge";
                dynamicButton.Name = item.Naam;

                tellerX++;
                if (tellerX % 7 == 0)
                {
                    tellerX = 0;
                    tellerY++;
                }

                dynamicButton.Click += DynamicButton_Click;

                Controls.Add(label);
                Controls.Add(dynamicButton);
            }
        }

        private void DeleteButtons()
        {
            var controlsToRemove = new List<Control>();
            foreach (Control item in this.Controls)
            {
                if (item is Button || (item is Label && item.Name[0] == 't'))
                    controlsToRemove.Add(item);
            }

            foreach (Control item in controlsToRemove)
            {
                Controls.Remove(item);
            }
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var deeln = from d in DeelnLijst
                        join dOpl in DeelnOplLijst on d.Id equals dOpl.Deelnemer.Id
                        where dOpl.OpleidingsInformatie.Id == Opleiding.Id
                        select d;

            using (var ctx = new DataContext())
            {
                Opleiding = ctx.OpleidingsInformatie.SingleOrDefault(x => x.Id == Opleiding.Id);
                Deelnemers deel = deeln.SingleOrDefault(d => d.Naam == button.Name);
                Tijdsregistraties nieuweTijdReg = new Tijdsregistraties
                {
                    DateTime = DateTime.Now,
                    OpleidingsInformatie = Opleiding,
                    Deelnemers = deel
                };
            }

            //button.Text


        }


    }

}
