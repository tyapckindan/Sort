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

namespace Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очищаем текстбокс
            richTextBox1.Clear();
            string fileName = (string)comboBox1.SelectedItem;
            string filePath = Path.Combine(@"D:\Лабы СП и РМ\Sort\Sort\File\", fileName + ".txt");

            if (File.Exists(filePath))
                richTextBox1.AppendText(File.ReadAllText(filePath));
            else
                richTextBox1.Clear();
        }
    }
}