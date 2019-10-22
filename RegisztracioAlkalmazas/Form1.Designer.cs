namespace RegisztracioAlkalmazas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_betoltes = new System.Windows.Forms.Button();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.btn_mentes = new System.Windows.Forms.Button();
            this.ujHobbiText = new System.Windows.Forms.TextBox();
            this.HobbiList = new System.Windows.Forms.ListBox();
            this.IdoPicker = new System.Windows.Forms.DateTimePicker();
            this.NevBox = new System.Windows.Forms.TextBox();
            this.radiobtn_no = new System.Windows.Forms.RadioButton();
            this.radiobutton_ferfi = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kedvenc hobbi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Új hobbi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nem:";
            // 
            // btn_betoltes
            // 
            this.btn_betoltes.Location = new System.Drawing.Point(418, 220);
            this.btn_betoltes.Name = "btn_betoltes";
            this.btn_betoltes.Size = new System.Drawing.Size(75, 23);
            this.btn_betoltes.TabIndex = 5;
            this.btn_betoltes.Text = "Betöltés";
            this.btn_betoltes.UseVisualStyleBackColor = true;
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(202, 259);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(75, 23);
            this.btn_hozzaad.TabIndex = 6;
            this.btn_hozzaad.Text = "Hozzáad";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.Btn_hozzaad_Click);
            // 
            // btn_mentes
            // 
            this.btn_mentes.Location = new System.Drawing.Point(418, 177);
            this.btn_mentes.Name = "btn_mentes";
            this.btn_mentes.Size = new System.Drawing.Size(75, 23);
            this.btn_mentes.TabIndex = 7;
            this.btn_mentes.Text = "Mentés";
            this.btn_mentes.UseVisualStyleBackColor = true;
            // 
            // ujHobbiText
            // 
            this.ujHobbiText.Location = new System.Drawing.Point(157, 233);
            this.ujHobbiText.Name = "ujHobbiText";
            this.ujHobbiText.Size = new System.Drawing.Size(120, 20);
            this.ujHobbiText.TabIndex = 8;
            // 
            // HobbiList
            // 
            this.HobbiList.FormattingEnabled = true;
            this.HobbiList.Location = new System.Drawing.Point(157, 132);
            this.HobbiList.Name = "HobbiList";
            this.HobbiList.Size = new System.Drawing.Size(120, 95);
            this.HobbiList.TabIndex = 9;
            // 
            // IdoPicker
            // 
            this.IdoPicker.Location = new System.Drawing.Point(100, 97);
            this.IdoPicker.Name = "IdoPicker";
            this.IdoPicker.Size = new System.Drawing.Size(200, 20);
            this.IdoPicker.TabIndex = 10;
            // 
            // NevBox
            // 
            this.NevBox.Location = new System.Drawing.Point(100, 26);
            this.NevBox.Name = "NevBox";
            this.NevBox.Size = new System.Drawing.Size(120, 20);
            this.NevBox.TabIndex = 11;
            // 
            // radiobtn_no
            // 
            this.radiobtn_no.AutoSize = true;
            this.radiobtn_no.Location = new System.Drawing.Point(169, 61);
            this.radiobtn_no.Name = "radiobtn_no";
            this.radiobtn_no.Size = new System.Drawing.Size(33, 17);
            this.radiobtn_no.TabIndex = 12;
            this.radiobtn_no.TabStop = true;
            this.radiobtn_no.Text = "N";
            this.radiobtn_no.UseVisualStyleBackColor = true;
            // 
            // radiobutton_ferfi
            // 
            this.radiobutton_ferfi.AutoSize = true;
            this.radiobutton_ferfi.Location = new System.Drawing.Point(115, 61);
            this.radiobutton_ferfi.Name = "radiobutton_ferfi";
            this.radiobutton_ferfi.Size = new System.Drawing.Size(31, 17);
            this.radiobutton_ferfi.TabIndex = 13;
            this.radiobutton_ferfi.TabStop = true;
            this.radiobutton_ferfi.Text = "F";
            this.radiobutton_ferfi.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Szöveges Fájlok |*.txt|Minden fájl|*.tx";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Szöveges Fájlok |*.txt|Minden fájl|*.tx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 294);
            this.Controls.Add(this.radiobutton_ferfi);
            this.Controls.Add(this.radiobtn_no);
            this.Controls.Add(this.NevBox);
            this.Controls.Add(this.IdoPicker);
            this.Controls.Add(this.HobbiList);
            this.Controls.Add(this.ujHobbiText);
            this.Controls.Add(this.btn_mentes);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.btn_betoltes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_betoltes;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_mentes;
        private System.Windows.Forms.TextBox ujHobbiText;
        private System.Windows.Forms.ListBox HobbiList;
        private System.Windows.Forms.DateTimePicker IdoPicker;
        private System.Windows.Forms.TextBox NevBox;
        private System.Windows.Forms.RadioButton radiobtn_no;
        private System.Windows.Forms.RadioButton radiobutton_ferfi;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

