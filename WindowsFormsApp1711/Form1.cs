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

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            var helper = new WordHelper("blank.docx");

            var items = new Dictionary<string, string>
            {
                {"<NUM>", textBox6.Text },
                {"<DATE>", dateTimePicker2.Value.ToString ("dd.MM.yyyy") },
                {"<FIO>", textBox2.Text },
                {"<ADR>", textBox1.Text },
                {"<TEL>", textBox4.Text },
                {"<EMAIL>", textBox5.Text },

                {"<PASSPORT_SERIA>", textBox7.Text },
                {"<PASSPORT_NOMER>", textBox8.Text },
                {"<KEM_VIDAN>", textBox9.Text },
                {"<DATE_VIDACHI>", dateTimePicker3.Value.ToString ("dd.MM.yyyy")},
                {"<OBRAZOVANIE>", textBox11.Text },

                {"<PROF>", textBox3.Text },
                

                {"<BALL>", textBox17.Text },

                {"<FIO_MATERI>", textBox10.Text },
                {"<RABOTA_MATERI>", textBox11.Text },
                {"<TELEFON_MATERI>", textBox12.Text },
                {"<FIO_OTSHA>", textBox13.Text },
                {"<RABOTA_OTSHA>", textBox14.Text },
                {"<TELEFON_OTSHA>", textBox15.Text },

            };

          

        }

        private void  dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
