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
                    using (var ctx = new DataContext())
                    {
                        foreach (var item in ctx.Deelnemers)
                        {
                            listBoxDeelnemers.Items.Add(item);
                        }            
                    }
                    break;
                case 3:
                    using (var ctx = new DataContext())
                    {
                        foreach (var item in ctx.NietOpleidingsDagen)
                        {
                            listBoxFeestdag.Items.Add(item);
                        }
                    }
                    break;
                case 4:
                    using (var ctx = new DataContext())
                    {
                        foreach (var item in ctx.Docenten)
                        {
                             listBoxDocent.Items.Add(item);
                        }
                    }
                    break;
                case 5:
                    using (var ctx = new DataContext())
                    {
                        foreach (var item in ctx.Deelnemers)
                        {
                            listBoxDeelnemersTijd.Items.Add(item);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
