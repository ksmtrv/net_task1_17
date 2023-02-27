using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace net_task_1_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);

                dataGridView1.RowCount = s;
                dataGridView1.ColumnCount = s;

                dataGridView1.TopLeftHeaderCell.Value = "Матрица";

                Random rnd = new Random();

                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        dataGridView1.Rows[j].Cells[i].Value = rnd.Next(-50, 50);

                    }
                    dataGridView1.Rows[i].HeaderCell.Value = System.Convert.ToString(i + 1);
                    dataGridView1.Columns[i].HeaderCell.Value = System.Convert.ToString(i + 1);
                }
            } catch
            {
                MessageBox.Show("Не задан размер матрицы");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            int[] vector = new int[dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                vector[i] = Math.Abs(int.Parse("" + dataGridView1[0, i].Value));
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {

                    if (Math.Abs(vector[i]) >= Math.Abs(int.Parse("" + dataGridView1[j, i].Value)))
                    {
                        vector[i] = int.Parse("" + dataGridView1[j, i].Value);
                    }
                }
            }

            dataGridView2.TopLeftHeaderCell.Value = "Вектор";
            dataGridView2.ColumnCount = vector.Length;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = vector[i].ToString();
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}