using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        Guna.UI2.WinForms.Guna2TextBox[] n;
        Guna.UI2.WinForms.Guna2TextBox[] n2;
        Guna.UI2.WinForms.Guna2TextBox[] n3;
        List<string> lineups = new List<string> { "4-4-2", "4-3-3", "4-5-1" };
        public Form1()
        {
            InitializeComponent();
            var countries = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(x => new RegionInfo(x.LCID))
                .Select(x => x.DisplayName)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            Country.Items.AddRange(countries.ToArray());
            C2.Items.AddRange(lineups.ToArray());

            
        }

        private void C2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C2.SelectedIndex == 0)
            {
                for (int i = 0; i < 11; i++)
                {
                    if (i >= 0 && i <= 3)
                    {
                        n[i].Text = "F";
                    }
                    else if (i >= 4 && i <= 7)
                    {
                        n[i].Text = "MD";
                    }
                    else if (i >= 8 && i <= 9)
                    {
                        n[i].Text = "DD";
                    }
                    else
                    {
                        n[i].Text = "GK";
                    }
                }
            }
            else if (C2.SelectedIndex == 1)
            {
                for (int i = 0; i < 11; i++)
                {
                    if (i >= 0 && i <= 3)
                    {
                        n[i].Text = "F";
                    }
                    else if (i >= 4 && i <= 6)
                    {
                        n[i].Text = "MD";
                    }
                    else if (i >= 7 && i <= 9)
                    {
                        n[i].Text = "DD";
                    }
                    else
                    {
                        n[i].Text = "GK";
                    }
                }
            }
            else if (C2.SelectedIndex == 2)
            {
                for (int i = 0; i < 11; i++)
                {
                    if (i >= 0 && i <= 3)
                    {
                        n[i].Text = "F";
                    }
                    else if (i >= 4 && i <= 8)
                    {
                        n[i].Text = "MD";
                    }
                    else if (i == 9)
                    {
                        n[i].Text = "DD";
                    }
                    else
                    {
                        n[i].Text = "GK";
                    }
                }
            }
            if (Country.SelectedIndex != -1)
            {
                for (int i = 0; i < 11; i++)
                {
                    n2[i].Enabled = true;
                }
                for (int i = 0; i < 11; i++)
                {
                    n3[i].Enabled = true;
                }
                guna2Button1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n = new Guna.UI2.WinForms.Guna2TextBox[] { Pos1, Pos2, Pos3, Pos4, Pos5, Pos6, Pos7, Pos8, Pos9, Pos10, Pos11 };
            n2 = new Guna.UI2.WinForms.Guna2TextBox[] { Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num11 };
            n3 = new Guna.UI2.WinForms.Guna2TextBox[] { Name1, Name2, Name3, Name4, Name5, Name6, Name7, Name8, Name9, Name10, Name11 };
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            for (int i = 0; i < 11; i++)
            {
                form.Names.Add(n3[i].Text);
            }
            for (int i = 0; i < 11; i++)
            {
                form.Numbers.Add(n2[i].Text);
            }
            var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            var englishRegion = regions.FirstOrDefault(region => region.EnglishName.Contains(Country.SelectedItem.ToString()));
            var countryAbbrev = englishRegion.TwoLetterISORegionName;
            form.countrycode = countryAbbrev;
            form.pos = C2.SelectedIndex;
            form.Labell.Text = Country.SelectedItem.ToString();
            form.ShowDialog();
        }

        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C2.SelectedIndex != -1)
            {
                for (int i = 0; i < 11; i++)
                {
                    n2[i].Enabled = true;
                }
                for (int i = 0; i < 11; i++)
                {
                    n3[i].Enabled = true;
                }
                guna2Button1.Enabled = true;
            }
        }
    }
}
