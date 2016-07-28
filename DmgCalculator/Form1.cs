using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace DmgCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double> weapons = new List<double>();
        List<double> materials = new List<double>();

        #region standalone methods

        internal string getSha256(string input)
        {
            byte[] data = Encoding.UTF8.GetBytes(input);
            byte[] hash;
            using (var sha256 = new SHA256Managed())
            {
                hash = sha256.ComputeHash(data);
            }

            return BitConverter.ToString(hash).Replace("-", "");
        }


        #endregion


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

                        weapons.Add(Convert.ToDouble(datas[0]));
                        lb_item.Items.Add(datas[1] + " :    " + datas[0]);
                    }
                }
                using (StreamReader sr = new StreamReader("WMat.csv", Encoding.UTF8))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] datas = line.Split(';');

                        materials.Add(Convert.ToDouble(datas[0]));
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
            nud_plusUpgrade.Maximum = decimal.MaxValue;
            bt_calculate.ForeColor = System.Drawing.Color.Red;
#endif

        }
        
        private void bt_calculate_Click(object sender, EventArgs e)
        {
            int tempElemDmg = 0;
            if (chb_water.Checked) { tempElemDmg += 5; }
            if (chb_fire.Checked) { tempElemDmg += 5; }
            if (chb_earth.Checked) { tempElemDmg += 5; }
            if (chb_air.Checked) { tempElemDmg += 5; }
            if (chb_electro.Checked) { tempElemDmg += 5; }
            if (chb_light.Checked) { tempElemDmg += 10; }
            if (chb_shadow.Checked) { tempElemDmg += 10; }

            tb_result.Text = ((int)((weapons[lb_item.SelectedIndex] * materials[lb_material.SelectedIndex]) + ((int)nud_plusUpgrade.Value * 3))).ToString();
            tb_elemDmg.Text = tempElemDmg.ToString();

            tb_checksum.Text = getSha256((string)lb_material.Items[0] + (string)lb_item.Items[lb_item.SelectedIndex] + nud_plusUpgrade.Value + tempElemDmg.ToString());
        }

    }
}
