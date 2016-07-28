namespace DmgCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_calculate = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lb_material = new System.Windows.Forms.ListBox();
            this.lb_item = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_plusUpgrade = new System.Windows.Forms.NumericUpDown();
            this.chb_light = new System.Windows.Forms.CheckBox();
            this.chb_water = new System.Windows.Forms.CheckBox();
            this.chb_fire = new System.Windows.Forms.CheckBox();
            this.chb_earth = new System.Windows.Forms.CheckBox();
            this.chb_air = new System.Windows.Forms.CheckBox();
            this.chb_electro = new System.Windows.Forms.CheckBox();
            this.chb_shadow = new System.Windows.Forms.CheckBox();
            this.tb_elemDmg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_checksum = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_weapons = new System.Windows.Forms.TabPage();
            this.tp_armours = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plusUpgrade)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_weapons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_calculate
            // 
            this.bt_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_calculate.Location = new System.Drawing.Point(366, 207);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(103, 64);
            this.bt_calculate.TabIndex = 0;
            this.bt_calculate.Text = "CALC";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.bt_calculate_Click);
            // 
            // tb_result
            // 
            this.tb_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_result.Location = new System.Drawing.Point(475, 207);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(135, 64);
            this.tb_result.TabIndex = 1;
            this.tb_result.Text = "0";
            // 
            // lb_material
            // 
            this.lb_material.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_material.FormattingEnabled = true;
            this.lb_material.Location = new System.Drawing.Point(6, 23);
            this.lb_material.Name = "lb_material";
            this.lb_material.Size = new System.Drawing.Size(338, 143);
            this.lb_material.TabIndex = 2;
            // 
            // lb_item
            // 
            this.lb_item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_item.FormattingEnabled = true;
            this.lb_item.Location = new System.Drawing.Point(366, 23);
            this.lb_item.Name = "lb_item";
            this.lb_item.Size = new System.Drawing.Size(355, 143);
            this.lb_item.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(363, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weapon upgrade level";
            // 
            // nud_plusUpgrade
            // 
            this.nud_plusUpgrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_plusUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_plusUpgrade.Location = new System.Drawing.Point(515, 175);
            this.nud_plusUpgrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_plusUpgrade.Name = "nud_plusUpgrade";
            this.nud_plusUpgrade.Size = new System.Drawing.Size(120, 18);
            this.nud_plusUpgrade.TabIndex = 7;
            // 
            // chb_light
            // 
            this.chb_light.AutoSize = true;
            this.chb_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chb_light.Location = new System.Drawing.Point(6, 249);
            this.chb_light.Name = "chb_light";
            this.chb_light.Size = new System.Drawing.Size(110, 22);
            this.chb_light.TabIndex = 9;
            this.chb_light.Text = "Solem (light)";
            this.chb_light.UseVisualStyleBackColor = true;
            // 
            // chb_water
            // 
            this.chb_water.AutoSize = true;
            this.chb_water.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chb_water.Location = new System.Drawing.Point(6, 193);
            this.chb_water.Name = "chb_water";
            this.chb_water.Size = new System.Drawing.Size(117, 22);
            this.chb_water.TabIndex = 10;
            this.chb_water.Text = "Vesirit (water)";
            this.chb_water.UseVisualStyleBackColor = true;
            // 
            // chb_fire
            // 
            this.chb_fire.AutoSize = true;
            this.chb_fire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chb_fire.Location = new System.Drawing.Point(224, 193);
            this.chb_fire.Name = "chb_fire";
            this.chb_fire.Size = new System.Drawing.Size(102, 22);
            this.chb_fire.TabIndex = 11;
            this.chb_fire.Text = "Eldurit (fire)";
            this.chb_fire.UseVisualStyleBackColor = true;
            // 
            // chb_earth
            // 
            this.chb_earth.AutoSize = true;
            this.chb_earth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chb_earth.Location = new System.Drawing.Point(6, 221);
            this.chb_earth.Name = "chb_earth";
            this.chb_earth.Size = new System.Drawing.Size(117, 22);
            this.chb_earth.TabIndex = 12;
            this.chb_earth.Text = "Erderit (earth)";
            this.chb_earth.UseVisualStyleBackColor = true;
            // 
            // chb_air
            // 
            this.chb_air.AutoSize = true;
            this.chb_air.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chb_air.Location = new System.Drawing.Point(224, 221);
            this.chb_air.Name = "chb_air";
            this.chb_air.Size = new System.Drawing.Size(105, 22);
            this.chb_air.TabIndex = 13;
            this.chb_air.Text = "Adhairit (air)";
            this.chb_air.UseVisualStyleBackColor = true;
            // 
            // chb_electro
            // 
            this.chb_electro.AutoSize = true;
            this.chb_electro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chb_electro.Location = new System.Drawing.Point(104, 165);
            this.chb_electro.Name = "chb_electro";
            this.chb_electro.Size = new System.Drawing.Size(144, 22);
            this.chb_electro.TabIndex = 13;
            this.chb_electro.Text = "Folgorit (lightning)";
            this.chb_electro.UseVisualStyleBackColor = true;
            // 
            // chb_shadow
            // 
            this.chb_shadow.AutoSize = true;
            this.chb_shadow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chb_shadow.Location = new System.Drawing.Point(224, 249);
            this.chb_shadow.Name = "chb_shadow";
            this.chb_shadow.Size = new System.Drawing.Size(141, 22);
            this.chb_shadow.TabIndex = 14;
            this.chb_shadow.Text = "Umbral (shadow)";
            this.chb_shadow.UseVisualStyleBackColor = true;
            // 
            // tb_elemDmg
            // 
            this.tb_elemDmg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_elemDmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_elemDmg.Location = new System.Drawing.Point(656, 207);
            this.tb_elemDmg.Name = "tb_elemDmg";
            this.tb_elemDmg.Size = new System.Drawing.Size(65, 64);
            this.tb_elemDmg.TabIndex = 15;
            this.tb_elemDmg.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(617, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "+";
            // 
            // tb_checksum
            // 
            this.tb_checksum.Location = new System.Drawing.Point(6, 282);
            this.tb_checksum.Name = "tb_checksum";
            this.tb_checksum.Size = new System.Drawing.Size(712, 20);
            this.tb_checksum.TabIndex = 17;
            this.tb_checksum.Text = "Hash of item";
            this.tb_checksum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_weapons);
            this.tabControl1.Controls.Add(this.tp_armours);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 336);
            this.tabControl1.TabIndex = 18;
            // 
            // tp_weapons
            // 
            this.tp_weapons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_weapons.Controls.Add(this.lb_material);
            this.tp_weapons.Controls.Add(this.tb_checksum);
            this.tp_weapons.Controls.Add(this.label3);
            this.tp_weapons.Controls.Add(this.label4);
            this.tp_weapons.Controls.Add(this.tb_result);
            this.tp_weapons.Controls.Add(this.tb_elemDmg);
            this.tp_weapons.Controls.Add(this.label2);
            this.tp_weapons.Controls.Add(this.chb_shadow);
            this.tp_weapons.Controls.Add(this.nud_plusUpgrade);
            this.tp_weapons.Controls.Add(this.chb_electro);
            this.tp_weapons.Controls.Add(this.label1);
            this.tp_weapons.Controls.Add(this.chb_air);
            this.tp_weapons.Controls.Add(this.bt_calculate);
            this.tp_weapons.Controls.Add(this.chb_earth);
            this.tp_weapons.Controls.Add(this.lb_item);
            this.tp_weapons.Controls.Add(this.chb_fire);
            this.tp_weapons.Controls.Add(this.chb_light);
            this.tp_weapons.Controls.Add(this.chb_water);
            this.tp_weapons.Location = new System.Drawing.Point(4, 22);
            this.tp_weapons.Name = "tp_weapons";
            this.tp_weapons.Padding = new System.Windows.Forms.Padding(3);
            this.tp_weapons.Size = new System.Drawing.Size(728, 310);
            this.tp_weapons.TabIndex = 0;
            this.tp_weapons.Text = "Weapons";
            // 
            // tp_armours
            // 
            this.tp_armours.Location = new System.Drawing.Point(4, 22);
            this.tp_armours.Name = "tp_armours";
            this.tp_armours.Padding = new System.Windows.Forms.Padding(3);
            this.tp_armours.Size = new System.Drawing.Size(728, 310);
            this.tp_armours.TabIndex = 1;
            this.tp_armours.Text = "Armours";
            this.tp_armours.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(736, 334);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DMG Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_plusUpgrade)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_weapons.ResumeLayout(false);
            this.tp_weapons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.ListBox lb_material;
        private System.Windows.Forms.ListBox lb_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_plusUpgrade;
        private System.Windows.Forms.CheckBox chb_light;
        private System.Windows.Forms.CheckBox chb_water;
        private System.Windows.Forms.CheckBox chb_fire;
        private System.Windows.Forms.CheckBox chb_earth;
        private System.Windows.Forms.CheckBox chb_air;
        private System.Windows.Forms.CheckBox chb_electro;
        private System.Windows.Forms.CheckBox chb_shadow;
        private System.Windows.Forms.TextBox tb_elemDmg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_checksum;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_weapons;
        private System.Windows.Forms.TabPage tp_armours;
    }
}

