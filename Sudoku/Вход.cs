using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Вход : Form
    {
        public Вход()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SudokuForm frm = new SudokuForm();
            frm.Show();
            Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            SudokuForm frm = new SudokuForm();
            frm.Show();
            Hide();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Rules frm = new Rules();
            frm.Show();
            
        }
    }
}
