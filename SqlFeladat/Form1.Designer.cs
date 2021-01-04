
namespace HarcosokApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnharcosadd = new System.Windows.Forms.Button();
            this.txtharcosnev = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkepessegad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leirastextbox = new System.Windows.Forms.TextBox();
            this.kepessegnevetextbox = new System.Windows.Forms.TextBox();
            this.hasznalocombobox = new System.Windows.Forms.ComboBox();
            this.harcosoklistbox = new System.Windows.Forms.ListBox();
            this.kepessegeklistbox = new System.Windows.Forms.ListBox();
            this.kepessegleirasatextbox = new System.Windows.Forms.TextBox();
            this.leirasmodostbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kepessegtorolbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnharcosadd);
            this.groupBox1.Controls.Add(this.txtharcosnev);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcos létrehozása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név:";
            // 
            // btnharcosadd
            // 
            this.btnharcosadd.Location = new System.Drawing.Point(184, 17);
            this.btnharcosadd.Name = "btnharcosadd";
            this.btnharcosadd.Size = new System.Drawing.Size(75, 23);
            this.btnharcosadd.TabIndex = 1;
            this.btnharcosadd.Text = "Létrehozás";
            this.btnharcosadd.UseVisualStyleBackColor = true;
            this.btnharcosadd.Click += new System.EventHandler(this.btnharcosadd_Click);
            // 
            // txtharcosnev
            // 
            this.txtharcosnev.Location = new System.Drawing.Point(45, 19);
            this.txtharcosnev.Name = "txtharcosnev";
            this.txtharcosnev.Size = new System.Drawing.Size(133, 20);
            this.txtharcosnev.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnkepessegad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.leirastextbox);
            this.groupBox2.Controls.Add(this.kepessegnevetextbox);
            this.groupBox2.Controls.Add(this.hasznalocombobox);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 141);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Képesség hozzáadása";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Leírás:";
            // 
            // btnkepessegad
            // 
            this.btnkepessegad.Location = new System.Drawing.Point(19, 91);
            this.btnkepessegad.Name = "btnkepessegad";
            this.btnkepessegad.Size = new System.Drawing.Size(75, 23);
            this.btnkepessegad.TabIndex = 5;
            this.btnkepessegad.Text = "Hozzáad";
            this.btnkepessegad.UseVisualStyleBackColor = true;
            this.btnkepessegad.Click += new System.EventHandler(this.btnkepessegad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Név: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Használó: ";
            // 
            // leirastextbox
            // 
            this.leirastextbox.Location = new System.Drawing.Point(378, 41);
            this.leirastextbox.Multiline = true;
            this.leirastextbox.Name = "leirastextbox";
            this.leirastextbox.Size = new System.Drawing.Size(165, 50);
            this.leirastextbox.TabIndex = 2;
            // 
            // kepessegnevetextbox
            // 
            this.kepessegnevetextbox.Location = new System.Drawing.Point(69, 64);
            this.kepessegnevetextbox.Name = "kepessegnevetextbox";
            this.kepessegnevetextbox.Size = new System.Drawing.Size(175, 20);
            this.kepessegnevetextbox.TabIndex = 1;
            // 
            // hasznalocombobox
            // 
            this.hasznalocombobox.FormattingEnabled = true;
            this.hasznalocombobox.Location = new System.Drawing.Point(69, 25);
            this.hasznalocombobox.Name = "hasznalocombobox";
            this.hasznalocombobox.Size = new System.Drawing.Size(175, 21);
            this.hasznalocombobox.TabIndex = 0;
            // 
            // harcosoklistbox
            // 
            this.harcosoklistbox.FormattingEnabled = true;
            this.harcosoklistbox.Location = new System.Drawing.Point(21, 246);
            this.harcosoklistbox.Name = "harcosoklistbox";
            this.harcosoklistbox.Size = new System.Drawing.Size(160, 95);
            this.harcosoklistbox.TabIndex = 3;
            this.harcosoklistbox.SelectedValueChanged += new System.EventHandler(this.harcosoklistbox_SelectedValueChanged);
            // 
            // kepessegeklistbox
            // 
            this.kepessegeklistbox.FormattingEnabled = true;
            this.kepessegeklistbox.Location = new System.Drawing.Point(223, 246);
            this.kepessegeklistbox.Name = "kepessegeklistbox";
            this.kepessegeklistbox.Size = new System.Drawing.Size(120, 95);
            this.kepessegeklistbox.TabIndex = 4;
            this.kepessegeklistbox.SelectedValueChanged += new System.EventHandler(this.kepessegeklistbox_SelectedValueChanged);
            // 
            // kepessegleirasatextbox
            // 
            this.kepessegleirasatextbox.Location = new System.Drawing.Point(390, 246);
            this.kepessegleirasatextbox.Multiline = true;
            this.kepessegleirasatextbox.Name = "kepessegleirasatextbox";
            this.kepessegleirasatextbox.Size = new System.Drawing.Size(165, 65);
            this.kepessegleirasatextbox.TabIndex = 5;
            // 
            // leirasmodostbtn
            // 
            this.leirasmodostbtn.Location = new System.Drawing.Point(480, 319);
            this.leirasmodostbtn.Name = "leirasmodostbtn";
            this.leirasmodostbtn.Size = new System.Drawing.Size(75, 23);
            this.leirasmodostbtn.TabIndex = 6;
            this.leirasmodostbtn.Text = "Módosít";
            this.leirasmodostbtn.UseVisualStyleBackColor = true;
            this.leirasmodostbtn.Click += new System.EventHandler(this.leirasmodostbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Harcosok:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Képességek: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Képesség leírása: ";
            // 
            // kepessegtorolbtn
            // 
            this.kepessegtorolbtn.Location = new System.Drawing.Point(240, 347);
            this.kepessegtorolbtn.Name = "kepessegtorolbtn";
            this.kepessegtorolbtn.Size = new System.Drawing.Size(75, 23);
            this.kepessegtorolbtn.TabIndex = 10;
            this.kepessegtorolbtn.Text = "Törlés";
            this.kepessegtorolbtn.UseVisualStyleBackColor = true;
            this.kepessegtorolbtn.Click += new System.EventHandler(this.kepessegtorolbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 381);
            this.Controls.Add(this.kepessegtorolbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leirasmodostbtn);
            this.Controls.Add(this.kepessegleirasatextbox);
            this.Controls.Add(this.kepessegeklistbox);
            this.Controls.Add(this.harcosoklistbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnharcosadd;
        private System.Windows.Forms.TextBox txtharcosnev;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnkepessegad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox leirastextbox;
        private System.Windows.Forms.TextBox kepessegnevetextbox;
        private System.Windows.Forms.ComboBox hasznalocombobox;
        private System.Windows.Forms.ListBox harcosoklistbox;
        private System.Windows.Forms.ListBox kepessegeklistbox;
        private System.Windows.Forms.TextBox kepessegleirasatextbox;
        private System.Windows.Forms.Button leirasmodostbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kepessegtorolbtn;
    }
}

