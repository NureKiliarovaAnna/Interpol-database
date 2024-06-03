using MainForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Forms
{
    public partial class CriminalDetailsForm : Form
    {
        private InfoCriminal criminal;
        private Archive archive;

        public CriminalDetailsForm(InfoCriminal criminal, Archive archive)
        {
            InitializeComponent();
            this.criminal = criminal;
            this.archive = archive;
            DisplayCriminalDetails();
        }

        private void DisplayCriminalDetails()
        {
            lblFirstName.Text = criminal.FirstName;
            lblLastName.Text = criminal.LastName;
            lblNickname.Text = criminal.Nickname;
            lblGender.Text = criminal.Gender;
            lblBirthDate.Text = criminal.BirthDate.ToShortDateString();
            lblBirthPlace.Text = criminal.BirthPlace;
            lblLastResidence.Text = criminal.LastResidence;
            lblCitizenship.Text = criminal.Citizenship;
            lblHeight.Text = criminal.Height.ToString();
            lblHairColor.Text = criminal.HairColor;
            lblEyeColor.Text = criminal.EyeColor;
            lblSpecialFeatures.Text = criminal.SpecialFeatures;
            lblCrimeType.Text = criminal.CrimeType;
            lblCrimeDate.Text = criminal.CrimeDate.ToShortDateString();
            lblCrimePlace.Text = criminal.CrimePlace;
            lblCourtDecision.Text = criminal.CourtDecision;
            pictureBoxPhoto.Image = criminal.Photo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCriminalForm editForm = new EditCriminalForm(criminal, archive);
            editForm.ShowDialog();
            DisplayCriminalDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете видалити цього злочинця?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                archive.Criminals.Remove(criminal);
                archive.SaveArchive(archive.Criminals);
                MessageBox.Show("Злочинця видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
