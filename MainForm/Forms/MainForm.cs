using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        private Archive archive;

        public MainForm()
        {
            InitializeComponent();
            archive = new Archive();
        }

        private void btnAddCriminal_Click(object sender, EventArgs e)
        {
            AddCriminalForm addForm = new AddCriminalForm(archive);
            addForm.ShowDialog();
            RefreshCriminalList();
        }

        private void RefreshCriminalList()
        {
            // Оновлення списку злочинців
            lstCriminals.Items.Clear();
            foreach (var criminal in archive.Злочинці)
            {
                lstCriminals.Items.Add(criminal);
            }
        }
    }
}