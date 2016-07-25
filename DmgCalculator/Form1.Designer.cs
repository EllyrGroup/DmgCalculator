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
            this.bt_test = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_dmg = new System.Windows.Forms.TabPage();
            this.tp_rare = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plusUpgrade)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_dmg.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_calculate
            // 
            this.bt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_calculate.Location = new System.Drawing.Point(476, 190);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(103, 71);
            this.bt_calculate.TabIndex = 0;
            this.bt_calculate.Text = "CALC";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.bt_calculate_Click);
            // 
            // tb_result
            // 
            this.tb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_result.Location = new System.Drawing.Point(585, 190);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(137, 71);
            this.tb_result.TabIndex = 1;
            this.tb_result.Text = "0";
            // 
            // lb_material
            // 
            this.lb_material.FormattingEnabled = true;
            this.lb_material.Location = new System.Drawing.Point(23, 23);
            this.lb_material.Name = "lb_material";
            this.lb_material.Size = new System.Drawing.Size(120, 95);
            this.lb_material.TabIndex = 2;
            // 
            // lb_item
            // 
            this.lb_item.FormattingEnabled = true;
            this.lb_item.Location = new System.Drawing.Point(149, 23);
            this.lb_item.Name = "lb_item";
            this.lb_item.Size = new System.Drawing.Size(120, 95);
            this.lb_item.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weapon upgrade level";
            // 
            // nud_plusUpgrade
            // 
            this.nud_plusUpgrade.Location = new System.Drawing.Point(122, 137);
            this.nud_plusUpgrade.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_plusUpgrade.Name = "nud_plusUpgrade";
            this.nud_plusUpgrade.Size = new System.Drawing.Size(120, 20);
            this.nud_plusUpgrade.TabIndex = 7;
            // 
            // bt_test
            // 
            this.bt_test.Enabled = false;
            this.bt_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_test.Location = new System.Drawing.Point(367, 190);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(103, 71);
            this.bt_test.TabIndex = 8;
            this.bt_test.Text = "TEST";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Visible = false;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_dmg);
            this.tabControl1.Controls.Add(this.tp_rare);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 312);
            this.tabControl1.TabIndex = 9;
            // 
            // tp_dmg
            // 
            this.tp_dmg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_dmg.Controls.Add(this.lb_item);
            this.tp_dmg.Controls.Add(this.bt_test);
            this.tp_dmg.Controls.Add(this.bt_calculate);
            this.tp_dmg.Controls.Add(this.nud_plusUpgrade);
            this.tp_dmg.Controls.Add(this.tb_result);
            this.tp_dmg.Controls.Add(this.label3);
            this.tp_dmg.Controls.Add(this.lb_material);
            this.tp_dmg.Controls.Add(this.label2);
            this.tp_dmg.Controls.Add(this.label1);
            this.tp_dmg.Location = new System.Drawing.Point(4, 22);
            this.tp_dmg.Name = "tp_dmg";
            this.tp_dmg.Padding = new System.Windows.Forms.Padding(3);
            this.tp_dmg.Size = new System.Drawing.Size(755, 286);
            this.tp_dmg.TabIndex = 0;
            this.tp_dmg.Text = "DMGCalc";
            // 
            // tp_rare
            // 
            this.tp_rare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_rare.Location = new System.Drawing.Point(4, 22);
            this.tp_rare.Name = "tp_rare";
            this.tp_rare.Padding = new System.Windows.Forms.Padding(3);
            this.tp_rare.Size = new System.Drawing.Size(755, 286);
            this.tp_rare.TabIndex = 1;
            this.tp_rare.Text = "Rare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(763, 310);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DMG Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_plusUpgrade)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_dmg.ResumeLayout(false);
            this.tp_dmg.PerformLayout();
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
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_dmg;
        private System.Windows.Forms.TabPage tp_rare;
    }
}

