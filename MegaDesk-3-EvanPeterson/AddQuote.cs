using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_3_EvanPeterson
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();

        }

        private void cancelAddQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void widthNumberBox_ValueChanged(object sender, EventArgs e)
        {
            if (widthNumberBox.Value > 96 || widthNumberBox.Value < 24)
            {
                widthLabel.Text = "Please Enter Valid Number";
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            List<SurfaceMaterial> enumList = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList(); ;
            materialBox.DataSource = enumList;
            int[] drawerNum = { 0, 1, 2, 3, 4, 5, 6, 7 };
            drawerBox.DataSource = drawerNum;
            int[] rushNums = { 0, 3, 5, 7 };
            rushBox.DataSource = rushNums;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk((int)widthNumberBox.Value, (int)depthNumberBox.Value, int.Parse(drawerBox.Text), (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), materialBox.Text));
            DeskQuote quote = new DeskQuote(desk, int.Parse(rushBox.Text), nameBox.Text, DateTime.Now);
            quoteTextBox.Text = DeskQuote.CalculateQuote(desk).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk((int)widthNumberBox.Value, (int)depthNumberBox.Value, int.Parse(drawerBox.Text), (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), materialBox.Text));
            DeskQuote quote = new DeskQuote(desk, int.Parse(rushBox.Text), nameBox.Text, DateTime.Now);
            _writeQuote(quote, desk);
        }

        private void _writeQuote (DeskQuote quote, Desk desk)
        {
            StreamWriter writer = new StreamWriter("quotes.txt");
            writer.Write(desk.CsvString());
            writer.WriteLine(quote.CsvString());
            writer.Close();
        }
    }
}