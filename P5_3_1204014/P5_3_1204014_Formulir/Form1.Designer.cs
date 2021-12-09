namespace P5_3_1204014_Formulir
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PilihMatkul = new System.Windows.Forms.Button();
            this.lk = new System.Windows.Forms.RadioButton();
            this.prm = new System.Windows.Forms.RadioButton();
            this.ALAMAT = new System.Windows.Forms.TextBox();
            this.TA = new System.Windows.Forms.TextBox();
            this.PROGSTU = new System.Windows.Forms.ComboBox();
            this.NIM = new P5_3_1204014.NumericTextBox();
            this.SEMESTER = new P5_3_1204014.NumericTextBox();
            this.kurikulum = new System.Windows.Forms.GroupBox();
            this.kurikulum2014 = new System.Windows.Forms.RadioButton();
            this.kurikulum2010 = new System.Windows.Forms.RadioButton();
            this.kurikulum2006 = new System.Windows.Forms.RadioButton();
            this.Matkul = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pemrograman1 = new System.Windows.Forms.CheckBox();
            this.MTK = new System.Windows.Forms.CheckBox();
            this.simpan = new System.Windows.Forms.Button();
            this.batal = new System.Windows.Forms.Button();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.NAMA = new P5_3_1204014_Formulir.CharTextBox();
            this.kurikulum.SuspendLayout();
            this.Matkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Program Studi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tahun Akademik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Semester";
            // 
            // PilihMatkul
            // 
            this.PilihMatkul.Location = new System.Drawing.Point(451, 185);
            this.PilihMatkul.Name = "PilihMatkul";
            this.PilihMatkul.Size = new System.Drawing.Size(113, 23);
            this.PilihMatkul.TabIndex = 8;
            this.PilihMatkul.Text = "Pilih Mata Kuliah";
            this.PilihMatkul.UseVisualStyleBackColor = true;
            this.PilihMatkul.Click += new System.EventHandler(this.PilihMatkul_Click);
            // 
            // lk
            // 
            this.lk.AutoSize = true;
            this.lk.Location = new System.Drawing.Point(92, 127);
            this.lk.Name = "lk";
            this.lk.Size = new System.Drawing.Size(74, 17);
            this.lk.TabIndex = 15;
            this.lk.TabStop = true;
            this.lk.Text = "Laki - Laki";
            this.lk.UseVisualStyleBackColor = true;
            // 
            // prm
            // 
            this.prm.AutoSize = true;
            this.prm.Location = new System.Drawing.Point(172, 127);
            this.prm.Name = "prm";
            this.prm.Size = new System.Drawing.Size(79, 17);
            this.prm.TabIndex = 16;
            this.prm.TabStop = true;
            this.prm.Text = "Perempuan";
            this.prm.UseVisualStyleBackColor = true;
            // 
            // ALAMAT
            // 
            this.ALAMAT.Location = new System.Drawing.Point(92, 167);
            this.ALAMAT.Multiline = true;
            this.ALAMAT.Name = "ALAMAT";
            this.ALAMAT.Size = new System.Drawing.Size(171, 59);
            this.ALAMAT.TabIndex = 17;
            // 
            // TA
            // 
            this.TA.Location = new System.Drawing.Point(443, 89);
            this.TA.Name = "TA";
            this.TA.Size = new System.Drawing.Size(210, 20);
            this.TA.TabIndex = 18;
            this.TA.TextChanged += new System.EventHandler(this.TA_TextChanged);
            // 
            // PROGSTU
            // 
            this.PROGSTU.FormattingEnabled = true;
            this.PROGSTU.Items.AddRange(new object[] {
            "D3",
            "D4",
            "S1",
            "S2",
            "S3"});
            this.PROGSTU.Location = new System.Drawing.Point(443, 47);
            this.PROGSTU.Name = "PROGSTU";
            this.PROGSTU.Size = new System.Drawing.Size(210, 21);
            this.PROGSTU.TabIndex = 19;
            this.PROGSTU.Text = "      - Pilih Program Studi -";
            // 
            // NIM
            // 
            this.NIM.Location = new System.Drawing.Point(92, 55);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(159, 20);
            this.NIM.TabIndex = 20;
            // 
            // SEMESTER
            // 
            this.SEMESTER.Location = new System.Drawing.Point(443, 124);
            this.SEMESTER.Name = "SEMESTER";
            this.SEMESTER.Size = new System.Drawing.Size(210, 20);
            this.SEMESTER.TabIndex = 21;
            // 
            // kurikulum
            // 
            this.kurikulum.Controls.Add(this.kurikulum2014);
            this.kurikulum.Controls.Add(this.kurikulum2010);
            this.kurikulum.Controls.Add(this.kurikulum2006);
            this.kurikulum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurikulum.Location = new System.Drawing.Point(16, 260);
            this.kurikulum.Name = "kurikulum";
            this.kurikulum.Size = new System.Drawing.Size(200, 175);
            this.kurikulum.TabIndex = 23;
            this.kurikulum.TabStop = false;
            this.kurikulum.Text = "Kurikulum Pilihan";
            // 
            // kurikulum2014
            // 
            this.kurikulum2014.AutoSize = true;
            this.kurikulum2014.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurikulum2014.Location = new System.Drawing.Point(6, 102);
            this.kurikulum2014.Name = "kurikulum2014";
            this.kurikulum2014.Size = new System.Drawing.Size(98, 17);
            this.kurikulum2014.TabIndex = 2;
            this.kurikulum2014.TabStop = true;
            this.kurikulum2014.Text = "Kurikulum 2014";
            this.kurikulum2014.UseVisualStyleBackColor = true;
            // 
            // kurikulum2010
            // 
            this.kurikulum2010.AutoSize = true;
            this.kurikulum2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurikulum2010.Location = new System.Drawing.Point(6, 65);
            this.kurikulum2010.Name = "kurikulum2010";
            this.kurikulum2010.Size = new System.Drawing.Size(98, 17);
            this.kurikulum2010.TabIndex = 1;
            this.kurikulum2010.TabStop = true;
            this.kurikulum2010.Text = "Kurikulum 2010";
            this.kurikulum2010.UseVisualStyleBackColor = true;
            // 
            // kurikulum2006
            // 
            this.kurikulum2006.AutoSize = true;
            this.kurikulum2006.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurikulum2006.Location = new System.Drawing.Point(6, 32);
            this.kurikulum2006.Name = "kurikulum2006";
            this.kurikulum2006.Size = new System.Drawing.Size(98, 17);
            this.kurikulum2006.TabIndex = 0;
            this.kurikulum2006.TabStop = true;
            this.kurikulum2006.Text = "Kurikulum 2006";
            this.kurikulum2006.UseVisualStyleBackColor = true;
            // 
            // Matkul
            // 
            this.Matkul.Controls.Add(this.checkBox9);
            this.Matkul.Controls.Add(this.checkBox10);
            this.Matkul.Controls.Add(this.checkBox11);
            this.Matkul.Controls.Add(this.checkBox12);
            this.Matkul.Controls.Add(this.checkBox5);
            this.Matkul.Controls.Add(this.checkBox6);
            this.Matkul.Controls.Add(this.checkBox7);
            this.Matkul.Controls.Add(this.checkBox8);
            this.Matkul.Controls.Add(this.checkBox4);
            this.Matkul.Controls.Add(this.checkBox3);
            this.Matkul.Controls.Add(this.pemrograman1);
            this.Matkul.Controls.Add(this.MTK);
            this.Matkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matkul.Location = new System.Drawing.Point(280, 260);
            this.Matkul.Name = "Matkul";
            this.Matkul.Size = new System.Drawing.Size(433, 175);
            this.Matkul.TabIndex = 24;
            this.Matkul.TabStop = false;
            this.Matkul.Text = "Mata Kuliah Pilihan";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(277, 132);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(148, 17);
            this.checkBox9.TabIndex = 11;
            this.checkBox9.Text = "Manajemen Rantai Pasok";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(277, 99);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(96, 17);
            this.checkBox10.TabIndex = 10;
            this.checkBox10.Text = "Sistem Operasi";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(277, 66);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(114, 17);
            this.checkBox11.TabIndex = 9;
            this.checkBox11.Text = "Jaringan Komputer";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(277, 33);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(117, 17);
            this.checkBox12.TabIndex = 8;
            this.checkBox12.Text = "Perangkat Logistik ";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(140, 126);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 17);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Pemrograman 7";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(140, 95);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(100, 17);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Pemrograman 6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(140, 64);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(100, 17);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "Pemrograman 5";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(140, 33);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(100, 17);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "Pemrograman 4";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(20, 126);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Pemrograman 3";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(20, 95);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Pemrograman 2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // pemrograman1
            // 
            this.pemrograman1.AutoSize = true;
            this.pemrograman1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemrograman1.Location = new System.Drawing.Point(20, 64);
            this.pemrograman1.Name = "pemrograman1";
            this.pemrograman1.Size = new System.Drawing.Size(100, 17);
            this.pemrograman1.TabIndex = 1;
            this.pemrograman1.Text = "Pemrograman 1";
            this.pemrograman1.UseVisualStyleBackColor = true;
            // 
            // MTK
            // 
            this.MTK.AutoSize = true;
            this.MTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTK.Location = new System.Drawing.Point(20, 33);
            this.MTK.Name = "MTK";
            this.MTK.Size = new System.Drawing.Size(81, 17);
            this.MTK.TabIndex = 0;
            this.MTK.Text = "Matematika";
            this.MTK.UseVisualStyleBackColor = true;
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(140, 467);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(75, 23);
            this.simpan.TabIndex = 25;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // batal
            // 
            this.batal.Location = new System.Drawing.Point(313, 467);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(75, 23);
            this.batal.TabIndex = 26;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            // 
            // NAMA
            // 
            this.NAMA.Location = new System.Drawing.Point(92, 85);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(159, 20);
            this.NAMA.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 505);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.Matkul);
            this.Controls.Add(this.kurikulum);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.SEMESTER);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.PROGSTU);
            this.Controls.Add(this.TA);
            this.Controls.Add(this.ALAMAT);
            this.Controls.Add(this.prm);
            this.Controls.Add(this.lk);
            this.Controls.Add(this.PilihMatkul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.kurikulum.ResumeLayout(false);
            this.kurikulum.PerformLayout();
            this.Matkul.ResumeLayout(false);
            this.Matkul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PilihMatkul;
        private System.Windows.Forms.RadioButton lk;
        private System.Windows.Forms.RadioButton prm;
        private System.Windows.Forms.TextBox ALAMAT;
        private System.Windows.Forms.TextBox TA;
        private System.Windows.Forms.ComboBox PROGSTU;
        private P5_3_1204014.NumericTextBox NIM;
        private P5_3_1204014.NumericTextBox SEMESTER;
        private CharTextBox NAMA;
        private System.Windows.Forms.GroupBox kurikulum;
        private System.Windows.Forms.RadioButton kurikulum2014;
        private System.Windows.Forms.RadioButton kurikulum2010;
        private System.Windows.Forms.RadioButton kurikulum2006;
        private System.Windows.Forms.GroupBox Matkul;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox pemrograman1;
        private System.Windows.Forms.CheckBox MTK;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.ErrorProvider epWarning;
    }
}

