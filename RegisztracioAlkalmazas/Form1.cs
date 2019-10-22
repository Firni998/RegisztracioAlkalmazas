using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btn_mentes.Click += (sender, e) =>
            {
                Mentes();
            };
            btn_betoltes.Click += (sender, e) =>
            {

                Megnyitas();
            };
        }
        private void Mentes()

        {
            if (NevBox.Text != "" && (radiobutton_ferfi.Checked || radiobtn_no.Checked) && HobbiList.SelectedItem != null)
            {
                string tartalom = NevBox.Text + ";" + IdoPicker.Value + ";";
                if (radiobutton_ferfi.Checked == true)
                {
                    tartalom += "F;";
                }
                else
                {
                    tartalom += "N;";
                }
                tartalom += HobbiList.SelectedItem.ToString() + Environment.NewLine;


                for (int i = 0; i < HobbiList.Items.Count - 1; i++)
                {
                    tartalom += HobbiList.Items[i] + ";";
                }
                tartalom += HobbiList.Items[HobbiList.Items.Count - 1];



                var eredmeny = saveFileDialog.ShowDialog(this);
                if (eredmeny == DialogResult.OK)
                {
                    string fileNev = saveFileDialog.FileName;
                    /* 
                    using (var file = File.CreateText(fileNev))
                     {
                         file.Write(tartalom);
                     }
                     */
                    File.WriteAllText(fileNev, tartalom);
                }
            }


        }

        private void Megnyitas()
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string sor = sr.ReadLine();

                    string[] adattag = sor.Split(';');

                    NevBox.Text = adattag[0];

                    IdoPicker.Value = Convert.ToDateTime(adattag[1]);

                    if (adattag[2] == "F")
                    {
                        radiobutton_ferfi.Checked = true;
                    }
                    else
                    {
                        radiobtn_no.Checked = true;
                    }

                    if (HobbiList.Items.Contains(adattag[3]))
                    {
                        HobbiList.SelectedItem = adattag[3];
                    }
                    else
                    {
                        HobbiList.Items.Add(adattag[3]);
                        HobbiList.SelectedItem = adattag[3];
                    }


                    string[] masodiksor = sr.ReadLine().Split(';');

                    for (int i = 0; i < masodiksor.Length; i++)
                    {
                        if (!HobbiList.Items.Contains(masodiksor[i]))
                        {
                            HobbiList.Items.Add(masodiksor[i]);
                        }
                    }
                }
            }
        }

        private void Btn_hozzaad_Click(object sender, EventArgs e)
        {
            HobbiList.Items.Add(ujHobbiText.Text);
        }
    }
}
