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

namespace Nevjegyzek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/data.dat"))
                database.ReadXml($"{Application.StartupPath}/data.dat");
        }

        private void nevekDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                nevekBindingSource.Filter = $"Nev like '*{searchBox.Text}*' or Mobile='{searchBox.Text}'";
        }

        private void nevekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            nevekBindingSource.EndEdit();
            database.WriteXml($"{Application.StartupPath}/data.dat");
            MessageBox.Show("Adatok felvéve a névjegyzékbe.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            nevekBindingSource.EndEdit();
            database.WriteXml($"{Application.StartupPath}/data.dat");
            MessageBox.Show("Adatok felvéve a névjegyzékbe.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
