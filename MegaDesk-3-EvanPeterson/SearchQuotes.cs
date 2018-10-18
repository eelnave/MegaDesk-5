using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

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
            using (StreamReader streamReader = new StreamReader("quotes.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    string[] line = new string[1];
                    line = streamReader.ReadLine().Split(',');
                    dataGrid.Rows.Add(line);
                }
            }
            List<SurfaceMaterial> enumList = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList(); ;
            comboBox1.DataSource = enumList;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            using (StreamReader streamReader = new StreamReader("quotes.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    string[] line = new string[1];
                    line = streamReader.ReadLine().Split(',');
                    if (line[MATERIAL].Trim(' ') == comboBox1.SelectedValue.ToString())
                    {
                        dataGrid.Rows.Add(line);
                    }
                }
            }
        }
    }
}
