using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DmgCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> weapons = new List<int>();
        List<int> materials = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader("Weapons.csv", Encoding.UTF8))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] datas = line.Split(';');

                        weapons.Add(int.Parse(datas[0]));
                        lb_item.Items.Add(datas[1] + " :    " + datas[0]);
                    }
                }
                using (StreamReader sr = new StreamReader("Materials.csv", Encoding.UTF8))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] datas = line.Split(';');

                        materials.Add(int.Parse(datas[0]));
                        lb_material.Items.Add(datas[1] + " :    " + datas[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

#if DEBUG
            Text = "DMG Calculator [DEBUG]";
#endif

        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            foreach (int i in weapons)
            {
                
            }
            foreach (var pair in materials)
            {
                
            }

            MessageBox.Show("test message", "TEST");
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            int tempElemDmg = 0;
            if (chb_water.Checked) { tempElemDmg += 5; }
            if (chb_fire.Checked) { tempElemDmg += 5; }
            if (chb_earth.Checked) { tempElemDmg += 5; }
            if (chb_wind.Checked) { tempElemDmg += 5; }
            if (chb_water.Checked) { tempElemDmg += 5; }
            if (chb_electro.Checked) { tempElemDmg += 5; }
            if (chb_light.Checked) { tempElemDmg += 5; }
            if (chb_shadow.Checked) { tempElemDmg += 5; }

            tb_result.Text = (weapons[lb_item.SelectedIndex] + materials[lb_material.SelectedIndex] + ((int)nud_plusUpgrade.Value * 3)).ToString();
            tb_elemDmg.Text = tempElemDmg.ToString();
        }
    }
}
