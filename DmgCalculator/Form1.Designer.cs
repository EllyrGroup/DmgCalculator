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
            this.bt_calculate = new System.Windows.Forms.Button();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.lb_material = new System.Windows.Forms.ListBox();
            this.lb_item = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_plusUpgrade = new System.Windows.Forms.NumericUpDown();
            this.bt_test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_plusUpgrade)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_calculate
            // 
            this.bt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_calculate.Location = new System.Drawing.Point(526, 195);
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
            this.tb_result.Location = new System.Drawing.Point(635, 195);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(98, 71);
            this.tb_result.TabIndex = 1;
            this.tb_result.Text = "666";
            // 
            // lb_material
            // 
            this.lb_material.FormattingEnabled = true;
            this.lb_material.Location = new System.Drawing.Point(34, 28);
            this.lb_material.Name = "lb_material";
            this.lb_material.Size = new System.Drawing.Size(120, 95);
            this.lb_material.TabIndex = 2;
            // 
            // lb_item
            // 
            this.lb_item.FormattingEnabled = true;
            this.lb_item.Location = new System.Drawing.Point(160, 28);
            this.lb_item.Name = "lb_item";
            this.lb_item.Size = new System.Drawing.Size(120, 95);
            this.lb_item.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weapon upgrade level";
            // 
            // nud_plusUpgrade
            // 
            this.nud_plusUpgrade.Location = new System.Drawing.Point(133, 142);
            this.nud_plusUpgrade.Name = "nud_plusUpgrade";
            this.nud_plusUpgrade.Size = new System.Drawing.Size(120, 20);
            this.nud_plusUpgrade.TabIndex = 7;
            // 
            // bt_test
            // 
            this.bt_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_test.Location = new System.Drawing.Point(417, 195);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(103, 71);
            this.bt_test.TabIndex = 8;
            this.bt_test.Text = "TEST";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 276);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.nud_plusUpgrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_item);
            this.Controls.Add(this.lb_material);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.bt_calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_plusUpgrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

