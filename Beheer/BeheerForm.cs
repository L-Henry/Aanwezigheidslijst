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

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                case 2:
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
                case 3:
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
                case 4:
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
                case 5:
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
    }
}
