using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_3_EvanPeterson
{
    public partial class SearchQuotes : Form
    {
        public const int MATERIAL = 4;

        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            List<Desk.SurfaceMaterial> enumList = Enum.GetValues(typeof(Desk.SurfaceMaterial)).Cast<Desk.SurfaceMaterial>().ToList(); ;
            comboBox1.DataSource = enumList;
            BuildTable();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            var selection = comboBox.SelectedValue;

            using (StreamReader streamreader = new StreamReader("jsonfile.json"))
            {
                string quotes = streamreader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGrid.DataSource = deskQuotes.Select(d => new
                    {
                        Date = d.QuoteDate,
                        Customer = d.Name,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.Drawers,
                        Price = d.QuoteCost,
                        Material = d.Desk.Material
                    }
                )
                .Where(q => q.Material == (Desk.SurfaceMaterial)selection)
                .ToList();
            }
        }

        private void BuildTable()
        {
            using (StreamReader streamreader = new StreamReader("jsonfile.json"))
            {
                string quotes = streamreader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGrid.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.Name,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.Drawers,
                    Price = d.QuoteCost,
                    Material = d.Desk.Material
                }
                ).ToList();
            }
        }
    }
}