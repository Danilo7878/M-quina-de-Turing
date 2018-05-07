using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_2_MT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vaciarFilaCabeza()
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++) {
                dataGridView1[i, 0].Value = "";
            }
        }

        private void vaciarFilaCabeza2()
        {
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                dataGridView2[i, 0].Value = "";
            }
        }

        private void vaciarFilaCabeza3()
        {
            for (int i = 0; i < dataGridView3.ColumnCount; i++)
            {
                dataGridView3[i, 0].Value = "";
            }
        }

        private void vaciarFilaCabeza4()
        {
            for (int i = 0; i < dataGridView4.ColumnCount; i++)
            {
                dataGridView4[i, 0].Value = "";
            }
        }

        private void vaciarFilaCabeza5()
        {
            for (int i = 0; i < dataGridView5.ColumnCount; i++)
            {
                dataGridView5[i, 0].Value = "";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = textBox1.Text;
            if (cadena != "")
            {
                label2.Visible = true;
                label4.Visible = true;
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                for (int i = 0; i <= cadena.Length; i++)
                {
                    dataGridView1.Columns.Add("", "");
                }
                dataGridView1.Rows.Add();

                for (int i = 0; i < cadena.Length; i++)
                {
                    dataGridView1[i, 1].Value = cadena[i];
                }
                dataGridView1[cadena.Length, 1].Value = "ß";
                dataGridView1[0, 0].Value = "⌛";
                dataGridView1.ClearSelection();
                button1.Enabled = false;
                button1.Visible = false;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar una cadena");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Visible = false;
            button1.Enabled = true;
            button1.Visible = true;
            label2.Visible = false;
            estado.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            textBox1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            label4.Visible = false;
            estado.Text = "q0";
            bool active = true;
            bool accept = false;
            int cabezal = 0;
            while (active)
            {
                this.Refresh();
                System.Threading.Thread.Sleep(800);
                if (cabezal >= 0)
                {
                    switch (estado.Text)
                    {
                        case "q0":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    dataGridView1[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado.Text = "q1";
                                    break;

                                case "b":
                                    dataGridView1[cabezal, 1].Value = "Y";
                                    cabezal++;
                                    estado.Text = "q2";
                                    break;

                                case "c":
                                    dataGridView1[cabezal, 1].Value = "Z";
                                    cabezal++;
                                    estado.Text = "q3";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q1":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "ß":
                                    cabezal--;
                                    estado.Text = "q4";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q2":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "ß":
                                    cabezal--;
                                    estado.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q3":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "ß":
                                    cabezal--;
                                    estado.Text = "q6";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q4":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    dataGridView1[cabezal, 1].Value = "X";
                                    cabezal--;
                                    estado.Text = "q7";
                                    break;

                                case "X":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                case "Y":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                case "Z":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q5":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "b":
                                    dataGridView1[cabezal, 1].Value = "Y";
                                    cabezal--;
                                    estado.Text = "q7";
                                    break;

                                case "X":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                case "Y":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                case "Z":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q6":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "c":
                                    dataGridView1[cabezal, 1].Value = "Z";
                                    cabezal--;
                                    estado.Text = "q7";
                                    break;

                                case "X":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                case "Y":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                case "Z":
                                    cabezal++;
                                    estado.Text = "q12";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q7":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal--;
                                    break;

                                case "b":
                                    cabezal--;
                                    break;

                                case "c":
                                    cabezal--;
                                    break;

                                case "X":
                                    cabezal++;
                                    estado.Text = "q8";
                                    break;

                                case "Y":
                                    cabezal++;
                                    estado.Text = "q8";
                                    break;

                                case "Z":
                                    cabezal++;
                                    estado.Text = "q8";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q8":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    dataGridView1[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado.Text = "q9";
                                    break;

                                case "b":
                                    dataGridView1[cabezal, 1].Value = "Y";
                                    cabezal++;
                                    estado.Text = "q10";
                                    break;

                                case "c":
                                    dataGridView1[cabezal, 1].Value = "Z";
                                    cabezal++;
                                    estado.Text = "q11";
                                    break;

                                case "X":
                                    cabezal--;
                                    estado.Text = "q12";
                                    break;

                                case "Y":
                                    cabezal--;
                                    estado.Text = "q12";
                                    break;

                                case "Z":
                                    cabezal--;
                                    estado.Text = "q12";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q9":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "X":
                                    cabezal--;
                                    estado.Text = "q4";
                                    break;

                                case "Y":
                                    cabezal--;
                                    estado.Text = "q4";
                                    break;

                                case "Z":
                                    cabezal--;
                                    estado.Text = "q4";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q10":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "X":
                                    cabezal--;
                                    estado.Text = "q5";
                                    break;

                                case "Y":
                                    cabezal--;
                                    estado.Text = "q5";
                                    break;

                                case "Z":
                                    cabezal--;
                                    estado.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q11":
                            switch (dataGridView1[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "X":
                                    cabezal--;
                                    estado.Text = "q6";
                                    break;

                                case "Y":
                                    cabezal--;
                                    estado.Text = "q6";
                                    break;

                                case "Z":
                                    cabezal--;
                                    estado.Text = "q6";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q12":
                            accept = true;
                            active = false;
                            break;
                    }
                    vaciarFilaCabeza();
                    dataGridView1[cabezal, 0].Value = "⌛";

                }
                else
                {
                    active = false;
                }
            }

            if (accept)
            {
                MessageBox.Show("cadena aceptada. ES UN PALÍNDROMO");
            }
            else
            {
                MessageBox.Show("cadena no aceptada. LA MÁQUINA SE DETUVO");
            }

            button2.Visible = true;
            button2.Enabled = true;
        }

        private void escribir2_Click(object sender, EventArgs e)
        {
            string cadena = textBox2.Text;
            if (cadena != "")
            {
                iniciar2.Visible = true;
                estadoact2.Visible = true;
                play2.Enabled = true;
                play2.Visible = true;
                for (int i = 0; i <= cadena.Length; i++)
                {
                    dataGridView2.Columns.Add("", "");
                }
                dataGridView2.Rows.Add();

                for (int i = 0; i < cadena.Length; i++)
                {
                    dataGridView2[i, 1].Value = cadena[i];
                }
                dataGridView2[cadena.Length, 1].Value = "ß";
                dataGridView2[0, 0].Value = "⌛";
                dataGridView2.ClearSelection();
                escribir2.Enabled = false;
                escribir2.Visible = false;
                nuevacinta2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar una cadena");
            }
        }

        private void play2_Click(object sender, EventArgs e)
        {
            play2.Visible = false;
            play2.Enabled = false;
            iniciar2.Visible = false;
            estado2.Text = "q0";
            bool active = true;
            bool accept = false;
            int cabezal = 0;
            while (active)
            {
                this.Refresh();
                System.Threading.Thread.Sleep(800);
                if (cabezal >= 0)
                {
                    switch (estado2.Text)
                    {
                        case "q0":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    dataGridView2[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado2.Text = "q1";
                                    break;

                                case "b":
                                    dataGridView2[cabezal, 1].Value = "Y";
                                    cabezal++;
                                    estado2.Text = "q2";
                                    break;

                                case "c":
                                    dataGridView2[cabezal, 1].Value = "Z";
                                    cabezal++;
                                    estado2.Text = "q3";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q1":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView2[cabezal, 1].Value = "M";
                                    dataGridView2.Columns.Add("", "");
                                    dataGridView2[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado2.Text = "q4";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q2":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView2[cabezal, 1].Value = "N";
                                    dataGridView2.Columns.Add("", "");
                                    dataGridView2[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado2.Text = "q4";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q3":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView2[cabezal, 1].Value = "O";
                                    dataGridView2.Columns.Add("", "");
                                    dataGridView2[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado2.Text = "q4";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q4":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal--;
                                    break;

                                case "b":
                                    cabezal--;
                                    break;

                                case "c":
                                    cabezal--;
                                    break;

                                case "X":
                                    dataGridView2[cabezal, 1].Value = "a";
                                    cabezal++;
                                    estado2.Text = "q5";
                                    break;

                                case "Y":
                                    dataGridView2[cabezal, 1].Value = "b";
                                    cabezal++;
                                    estado2.Text = "q5";
                                    break;

                                case "Z":
                                    dataGridView2[cabezal, 1].Value = "c";
                                    cabezal++;
                                    estado2.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q5":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    dataGridView2[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado2.Text = "q6";
                                    break;

                                case "b":
                                    dataGridView2[cabezal, 1].Value = "Y";
                                    cabezal++;
                                    estado2.Text = "q7";
                                    break;

                                case "c":
                                    dataGridView2[cabezal, 1].Value = "Z";
                                    cabezal++;
                                    estado2.Text = "q8";
                                    break;

                                case "M":
                                    dataGridView2[cabezal, 1].Value = "a";
                                    cabezal++;
                                    estado2.Text = "q10";
                                    break;

                                case "N":
                                    dataGridView2[cabezal, 1].Value = "b";
                                    cabezal++;
                                    estado2.Text = "q10";
                                    break;

                                case "O":
                                    dataGridView2[cabezal, 1].Value = "c";
                                    cabezal++;
                                    estado2.Text = "q10";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q6":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "M":
                                    cabezal++;
                                    break;

                                case "N":
                                    cabezal++;
                                    break;

                                case "O":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView2[cabezal, 1].Value = "M";
                                    dataGridView2.Columns.Add("", "");
                                    dataGridView2[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado2.Text = "q9";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q7":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "M":
                                    cabezal++;
                                    break;

                                case "N":
                                    cabezal++;
                                    break;

                                case "O":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView2[cabezal, 1].Value = "N";
                                    dataGridView2.Columns.Add("", "");
                                    dataGridView2[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado2.Text = "q9";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q8":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal++;
                                    break;

                                case "b":
                                    cabezal++;
                                    break;

                                case "c":
                                    cabezal++;
                                    break;

                                case "M":
                                    cabezal++;
                                    break;

                                case "N":
                                    cabezal++;
                                    break;

                                case "O":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView2[cabezal, 1].Value = "O";
                                    dataGridView2.Columns.Add("", "");
                                    dataGridView2[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado2.Text = "q9";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q9":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "a":
                                    cabezal--;
                                    break;

                                case "b":
                                    cabezal--;
                                    break;

                                case "c":
                                    cabezal--;
                                    break;

                                case "M":
                                    cabezal--;
                                    break;

                                case "N":
                                    cabezal--;
                                    break;

                                case "O":
                                    cabezal--;
                                    break;

                                case "X":
                                    dataGridView2[cabezal, 1].Value = "a";
                                    cabezal++;
                                    estado2.Text = "q5";
                                    break;

                                case "Y":
                                    dataGridView2[cabezal, 1].Value = "b";
                                    cabezal++;
                                    estado2.Text = "q5";
                                    break;

                                case "Z":
                                    dataGridView2[cabezal, 1].Value = "c";
                                    cabezal++;
                                    estado2.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q10":
                            switch (dataGridView2[cabezal, 1].Value.ToString())
                            {
                                case "M":
                                    dataGridView2[cabezal, 1].Value = "a";
                                    cabezal++;
                                    break;

                                case "N":
                                    dataGridView2[cabezal, 1].Value = "b";
                                    cabezal++;
                                    break;

                                case "O":
                                    dataGridView2[cabezal, 1].Value = "c";
                                    cabezal++;
                                    break;

                                case "ß":
                                    cabezal--;
                                    estado2.Text = "q11";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q11":
                            active = false;
                            accept = true;
                            break;
                    }
                }
                else
                {
                    active = false;
                }
                vaciarFilaCabeza2();
                dataGridView2[cabezal, 0].Value = "⌛";
            }

            if (accept)
            {
                MessageBox.Show("cadena aceptada. DUPLICADA");
            }
            else
            {
                MessageBox.Show("cadena no aceptada. LA MÁQUINA SE DETUVO");
            }

            nuevacinta2.Visible = true;
            nuevacinta2.Enabled = true;
        }

        private void nuevacinta2_Click(object sender, EventArgs e)
        {
            nuevacinta2.Enabled = false;
            nuevacinta2.Visible = false;
            escribir2.Enabled = true;
            escribir2.Visible = true;
            estadoact2.Visible = false;
            estado2.Text = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            textBox2.Text = "";
        }

        private void escribir3_Click(object sender, EventArgs e)
        {
            string cadena = textBox3.Text;
            if (cadena != "")
            {
                iniciar3.Visible = true;
                estadoactual3.Visible = true;
                play3.Enabled = true;
                play3.Visible = true;
                for (int i = 0; i <= cadena.Length; i++)
                {
                    dataGridView3.Columns.Add("", "");
                }
                dataGridView3.Rows.Add();

                for (int i = 0; i < cadena.Length; i++)
                {
                    dataGridView3[i, 1].Value = cadena[i];
                }
                dataGridView3[cadena.Length, 1].Value = "ß";
                dataGridView3[0, 0].Value = "⌛";
                dataGridView3.ClearSelection();
                escribir3.Enabled = false;
                escribir3.Visible = false;
                nuevacinta3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar una cadena");
            }
        }

        private void play3_Click(object sender, EventArgs e)
        {
            play3.Visible = false;
            play3.Enabled = false;
            iniciar3.Visible = false;
            estado3.Text = "q0";
            bool active = true;
            bool accept = false;
            int cabezal = 0;
            while (active)
            {
                this.Refresh();
                System.Threading.Thread.Sleep(800);
                if (cabezal >= 0)
                {
                    switch (estado3.Text)
                    {
                        case "q0":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView3[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado3.Text = "q1";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q1":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "*":
                                    cabezal++;
                                    estado3.Text = "q2";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q2":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView3[cabezal, 1].Value = "Y";
                                    cabezal++;
                                    estado3.Text = "q3";
                                    break; 

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q3":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "=":
                                    cabezal++;
                                    estado3.Text = "q4";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q4":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "ß":
                                    dataGridView3[cabezal, 1].Value = "1";
                                    dataGridView3.Columns.Add("", "");
                                    dataGridView3[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado3.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q5":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal--;
                                    break;

                                case "=":
                                    cabezal--;
                                    break;

                                case "*":
                                    cabezal--;
                                    break;

                                case "Y":
                                    dataGridView3[cabezal, 1].Value = "1";
                                    cabezal++;
                                    estado3.Text = "q6";
                                    break;

                                case "X":
                                    dataGridView3[cabezal, 1].Value = "1";
                                    cabezal++;
                                    estado3.Text = "q9";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q6":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView3[cabezal, 1].Value = "Y";
                                    cabezal++;
                                    estado3.Text = "q7";
                                    break;

                                case "=":
                                    cabezal--;
                                    estado3.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q7":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "=":
                                    cabezal++;
                                    estado3.Text = "q8";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q8":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView3[cabezal, 1].Value = "1";
                                    dataGridView3.Columns.Add("", "");
                                    dataGridView3[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado3.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q9":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView3[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado3.Text = "q10";
                                    break;

                                case "*":
                                    cabezal++;
                                    estado3.Text = "q11";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q10":
                            switch (dataGridView3[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "*":
                                    cabezal++;
                                    estado3.Text = "q6";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q11":
                            active = false;
                            accept = true;
                            break;
                    }
                }
                else
                {
                    active = false;
                }
                vaciarFilaCabeza3();
                dataGridView3[cabezal, 0].Value = "⌛";
            }

            if (accept)
            {
                MessageBox.Show("cadena aceptada. SE REALIZÓ LA OPERACIÓN");
            }
            else
            {
                MessageBox.Show("cadena no aceptada. LA MÁQUINA SE DETUVO");
            }

            nuevacinta3.Visible = true;
            nuevacinta3.Enabled = true;
        }

        private void nuevacinta3_Click(object sender, EventArgs e)
        {
            nuevacinta3.Enabled = false;
            nuevacinta3.Visible = false;
            escribir3.Enabled = true;
            escribir3.Visible = true;
            estadoactual3.Visible = false;
            estado3.Text = "";
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            textBox3.Text = "";
        }

        private void escribir4_Click(object sender, EventArgs e)
        {
            string cadena = textBox4.Text;
            if (cadena != "")
            {
                iniciar4.Visible = true;
                estadoactual4.Visible = true;
                play4.Enabled = true;
                play4.Visible = true;
                for (int i = 0; i <= cadena.Length; i++)
                {
                    dataGridView4.Columns.Add("", "");
                }
                dataGridView4.Rows.Add();

                for (int i = 0; i < cadena.Length; i++)
                {
                    dataGridView4[i, 1].Value = cadena[i];
                }
                dataGridView4[cadena.Length, 1].Value = "ß";
                dataGridView4[0, 0].Value = "⌛";
                dataGridView4.ClearSelection();
                escribir4.Enabled = false;
                escribir4.Visible = false;
                nuevacinta4.Enabled = true;
            }
        }

        private void play4_Click(object sender, EventArgs e)
        {
            play4.Visible = false;
            play4.Enabled = false;
            iniciar4.Visible = false;
            estado4.Text = "q0";
            bool active = true;
            bool accept = false;
            int cabezal = 0;
            while (active)
            {
                this.Refresh();
                System.Threading.Thread.Sleep(800);
                if (cabezal >= 0)
                {
                    switch (estado4.Text)
                    {
                        case "q0":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView4[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado4.Text = "q1";
                                    break;
                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q1":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "+":
                                    cabezal++;
                                    estado4.Text = "q2";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q2":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView4[cabezal, 1].Value = "Y";
                                    cabezal++;
                                    estado4.Text = "q3";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q3":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "=":
                                    cabezal++;
                                    estado4.Text = "q4";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q4":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "ß":
                                    dataGridView4[cabezal, 1].Value = "1";
                                    dataGridView4.Columns.Add("", "");
                                    dataGridView4[cabezal+1, 1].Value = "ß";
                                    cabezal--;
                                    estado4.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q5":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal--;
                                    break;

                                case "=":
                                    cabezal--;
                                    break;

                                case "Y":
                                    dataGridView4[cabezal, 1].Value = "1";
                                    cabezal++;
                                    estado4.Text = "q6";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q6":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView4[cabezal, 1].Value = "Y";
                                    cabezal++;
                                    estado4.Text = "q7";
                                    break;

                                case "=":
                                    cabezal++;
                                    estado4.Text = "q7";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q7":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "=":
                                    cabezal++;
                                    break;

                                case "+":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView4[cabezal, 1].Value = "1";
                                    dataGridView4.Columns.Add("", "");
                                    dataGridView4[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado4.Text = "q8";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q8":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal--;
                                    break;

                                case "=":
                                    cabezal--;
                                    break;

                                case "+":
                                    cabezal--;
                                    break;

                                case "Y":
                                    dataGridView4[cabezal, 1].Value = "1";
                                    cabezal++;
                                    estado4.Text = "q6";
                                    break;

                                case "X":
                                    dataGridView4[cabezal, 1].Value = "1";
                                    cabezal++;
                                    estado4.Text = "q9";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q9":
                            switch (dataGridView4[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView4[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado4.Text = "q7";
                                    break;

                                case "+":
                                    cabezal++;
                                    estado4.Text = "q10";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q10":
                            active = false;
                            accept = true;
                            break;
                    }
                }
                else
                {
                    active = false;
                }
                vaciarFilaCabeza4();
                dataGridView4[cabezal, 0].Value = "⌛";
            }

            if (accept)
            {
                MessageBox.Show("cadena aceptada. SE REALIZÓ LA OPERACIÓN");
            }
            else
            {
                MessageBox.Show("cadena no aceptada. LA MÁQUINA SE DETUVO");
            }

            nuevacinta4.Visible = true;
            nuevacinta4.Enabled = true;
        }

        private void nuevacinta4_Click(object sender, EventArgs e)
        {
            nuevacinta4.Enabled = false;
            nuevacinta4.Visible = false;
            escribir4.Enabled = true;
            escribir4.Visible = true;
            estadoactual4.Visible = false;
            estado4.Text = "";
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            textBox4.Text = "";
        }

        private void escribir5_Click(object sender, EventArgs e)
        {
            string cadena = textBox5.Text;
            if (cadena != "")
            {
                iniciar5.Visible = true;
                estadoactual5.Visible = true;
                play5.Enabled = true;
                play5.Visible = true;
                for (int i = 0; i <= cadena.Length; i++)
                {
                    dataGridView5.Columns.Add("", "");
                }
                dataGridView5.Rows.Add();

                for (int i = 0; i < cadena.Length; i++)
                {
                    dataGridView5[i, 1].Value = cadena[i];
                }
                dataGridView5[cadena.Length, 1].Value = "ß";
                dataGridView5[0, 0].Value = "⌛";
                dataGridView5.ClearSelection();
                escribir5.Enabled = false;
                escribir5.Visible = false;
                nuevacinta5.Enabled = true;
            }
        }

        private void play5_Click(object sender, EventArgs e)
        {
            play5.Visible = false;
            play5.Enabled = false;
            iniciar5.Visible = false;
            estado5.Text = "q0";
            bool active = true;
            bool accept = false;
            int cabezal = 0;
            while (active)
            {
                this.Refresh();
                System.Threading.Thread.Sleep(800);
                if (cabezal >= 0)
                {
                    switch (estado5.Text)
                    {
                        case "q0":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView5[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado5.Text = "q1";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q1":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "-":
                                    cabezal++;
                                    estado5.Text = "q2";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q2":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView5[cabezal, 1].Value = "Y";
                                    cabezal--;
                                    estado5.Text = "q3";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q3":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal--;
                                    break;

                                case "-":
                                    cabezal--;
                                    break;

                                case "X":
                                    dataGridView5[cabezal, 1].Value = "1";
                                    cabezal++;
                                    estado5.Text = "q4";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q4":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView5[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado5.Text = "q5";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q5":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "-":
                                    cabezal++;
                                    estado5.Text = "q6";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q6":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "Y":
                                    dataGridView5[cabezal, 1].Value = "1";
                                    cabezal++;
                                    estado5.Text = "q7";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q7":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView5[cabezal, 1].Value = "Y";
                                    cabezal--;
                                    estado5.Text = "q3";
                                    break;

                                case "=":
                                    cabezal++;
                                    estado5.Text = "q8";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q8":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "ß":
                                    dataGridView5[cabezal, 1].Value = "1";
                                    dataGridView5.Columns.Add("", "");
                                    dataGridView5[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado5.Text = "q9";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q9":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal--;
                                    break;

                                case "-":
                                    cabezal--;
                                    break;

                                case "=":
                                    cabezal--;
                                    break;

                                case "X":
                                    dataGridView5[cabezal, 1].Value = "1";
                                    cabezal++;
                                    estado5.Text = "q10";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q10":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    dataGridView5[cabezal, 1].Value = "X";
                                    cabezal++;
                                    estado5.Text = "q11";
                                    break;

                                case "-":
                                    cabezal++;
                                    estado5.Text = "q13";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q11":
                            switch (dataGridView5[cabezal, 1].Value.ToString())
                            {
                                case "1":
                                    cabezal++;
                                    break;

                                case "-":
                                    cabezal++;
                                    break;

                                case "=":
                                    cabezal++;
                                    break;

                                case "ß":
                                    dataGridView5[cabezal, 1].Value = "1";
                                    dataGridView5.Columns.Add("", "");
                                    dataGridView5[cabezal + 1, 1].Value = "ß";
                                    cabezal--;
                                    estado5.Text = "q9";
                                    break;

                                default:
                                    active = false;
                                    break;
                            }
                            break;

                        case "q13":
                            accept = true;
                            active = false;
                            break;
                    }
                }
                else
                {
                    active = false;
                }
                vaciarFilaCabeza5();
                dataGridView5[cabezal, 0].Value = "⌛";
            }

            if (accept)
            {
                MessageBox.Show("cadena aceptada. SE REALIZÓ LA OPERACIÓN");
            }
            else
            {
                MessageBox.Show("cadena no aceptada. LA MÁQUINA SE DETUVO");
            }

            nuevacinta5.Visible = true;
            nuevacinta5.Enabled = true;
        }

        private void nuevacinta5_Click(object sender, EventArgs e)
        {
            nuevacinta5.Enabled = false;
            nuevacinta5.Visible = false;
            escribir5.Enabled = true;
            escribir5.Visible = true;
            estadoactual5.Visible = false;
            estado5.Text = "";
            dataGridView5.Rows.Clear();
            dataGridView5.Columns.Clear();
            textBox5.Text = "";
        }
    }
}
