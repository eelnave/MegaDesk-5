using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_EvanPeterson
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Add functionality for opening a new form window
            addForm addNewQuoteForm = new addForm
            {
                Tag = this
            };
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes
            {
                Tag = this
            };
            viewAllQuotes.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes
            {
                Tag = this
            };
            searchQuotes.Show(this);
            Hide();
        }
    }
}