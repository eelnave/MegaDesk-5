using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

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
            List<Desk.SurfaceMaterial> enumList = Enum.GetValues(typeof(Desk.SurfaceMaterial)).Cast<Desk.SurfaceMaterial>().ToList(); ;
            materialBox.DataSource = enumList;
            int[] drawerNum = { 0, 1, 2, 3, 4, 5, 6, 7 };
            drawerBox.DataSource = drawerNum;
            int[] rushNums = { 0, 3, 5, 7 };
            rushBox.DataSource = rushNums;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk((int)widthNumberBox.Value, (int)depthNumberBox.Value, int.Parse(drawerBox.Text), (Desk.SurfaceMaterial)Enum.Parse(typeof(Desk.SurfaceMaterial), materialBox.Text));
            DeskQuote quote = new DeskQuote(desk, int.Parse(rushBox.Text), nameBox.Text, DateTime.Now);
            quoteTextBox.Text = DeskQuote.CalculateQuote(desk).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk((int)widthNumberBox.Value, (int)depthNumberBox.Value, int.Parse(drawerBox.Text), (Desk.SurfaceMaterial)Enum.Parse(typeof(Desk.SurfaceMaterial), materialBox.Text));
            DeskQuote quote = new DeskQuote(desk, int.Parse(rushBox.Text), nameBox.Text, DateTime.Now);
            _writeQuote(quote);

            DisplayQuote displayQuote = new DisplayQuote(quote, Tag) { Tag = this };
            displayQuote.Show(this);
            Hide();
        }

        private void _writeQuote(DeskQuote quote)
        {
            var jsonFile = @"jsonfile.json";
            List<DeskQuote> deskQuotes = new List<DeskQuote>();
            if (File.Exists(jsonFile))
            {
                using (StreamReader streamreader = new StreamReader(jsonFile))
                {
                    string quotes = streamreader.ReadToEnd();
                    deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                }
            }
            deskQuotes.Add(quote);
            string jsonQuote = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);
            File.WriteAllText(jsonFile, jsonQuote);
        }
    }
}