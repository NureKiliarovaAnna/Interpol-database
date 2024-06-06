using Interpol.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpol.Forms
{
    public partial class EditCriminalForm : Form
    {
        private Criminal criminal;

        private Archive archive;

        private string PhotoFileName = "";

        public EditCriminalForm(Criminal criminal, Archive archive)
        {
            InitializeComponent();
            this.criminal = criminal;
            this.archive = archive;
            LoadCriminalDetails();
            AddEventHandlers();
            ValidateForm();
        }

        private void LoadCriminalDetails()
        {
            txtFirstNameEdit.Text = criminal.FirstName;
            txtLastNameEdit.Text = criminal.LastName;
            txtNicknameEdit.Text = criminal.Nickname;
            cmbGenderEdit.SelectedItem = criminal.Gender;
            dtpBirthDateEdit.Value = criminal.BirthDate;
            txtBirthPlaceEdit.Text = criminal.BirthPlace;
            txtLastResidenceEdit.Text = criminal.LastResidence;
            txtCitizenshipEdit.Text = criminal.Citizenship;
            txtHeightEdit.Text = criminal.Height.ToString();
            cmbHairColorEdit.SelectedItem = criminal.HairColor;
            cmbEyeColorEdit.SelectedItem = criminal.EyeColor;
            txtSpecialFeaturesEdit.Text = criminal.SpecialFeatures;
            cmbCrimeTypeEdit.SelectedItem = criminal.CrimeType;
            dtpCrimeDateEdit.Value = criminal.CrimeDate;
            txtCrimePlaceEdit.Text = criminal.CrimePlace;
            txtCourtDecisionEdit.Text = criminal.CourtDecision;
            pictureBoxPhotoEdit.Image = Image.FromFile(criminal.PhotoPath);
            PhotoFileName = criminal.PhotoPath;

            cmbGenderEdit.DropDownStyle = ComboBoxStyle.DropDown;
            cmbHairColorEdit.DropDownStyle = ComboBoxStyle.DropDown;
            cmbEyeColorEdit.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCrimeTypeEdit.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void AddEventHandlers()
        {
            txtFirstNameEdit.TextChanged += new EventHandler(FieldChanged);
            txtLastNameEdit.TextChanged += new EventHandler(FieldChanged);
            txtNicknameEdit.TextChanged += new EventHandler(FieldChanged);
            cmbGenderEdit.SelectedIndexChanged += new EventHandler(FieldChanged);
            dtpBirthDateEdit.ValueChanged += new EventHandler(FieldChanged);
            txtBirthPlaceEdit.TextChanged += new EventHandler(FieldChanged);
            txtLastResidenceEdit.TextChanged += new EventHandler(FieldChanged);
            txtCitizenshipEdit.TextChanged += new EventHandler(FieldChanged);
            txtHeightEdit.TextChanged += new EventHandler(FieldChanged);
            cmbHairColorEdit.SelectedIndexChanged += new EventHandler(
                FieldChanged);
            cmbEyeColorEdit.SelectedIndexChanged += new EventHandler(
                FieldChanged);
            txtSpecialFeaturesEdit.TextChanged += new EventHandler(
                FieldChanged);
            cmbCrimeTypeEdit.SelectedIndexChanged += new EventHandler(
                FieldChanged);
            dtpCrimeDateEdit.ValueChanged += new EventHandler(FieldChanged);
            txtCrimePlaceEdit.TextChanged += new EventHandler(FieldChanged);
            txtCourtDecisionEdit.TextChanged += new EventHandler(
                FieldChanged);
            pictureBoxPhotoEdit.BackgroundImageChanged += new EventHandler(
                FieldChanged);
        }

        private void FieldChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void ValidateForm()
        {
            btnSave.Enabled = IsFormValid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUploadPhotoEdit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhotoEdit.Image = Image.FromFile(
                        openFileDialog.FileName);
                    pictureBoxPhotoEdit.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                criminal.FirstName = txtFirstNameEdit.Text;
                criminal.LastName = txtLastNameEdit.Text;
                criminal.Nickname = txtNicknameEdit.Text;
                criminal.Gender = cmbGenderEdit.Text;
                criminal.BirthDate = dtpBirthDateEdit.Value;
                criminal.BirthPlace = txtBirthPlaceEdit.Text;
                criminal.LastResidence = txtLastResidenceEdit.Text;
                criminal.Citizenship = txtCitizenshipEdit.Text;
                criminal.Height = int.Parse(txtHeightEdit.Text);
                criminal.HairColor = cmbHairColorEdit.Text;
                criminal.EyeColor = cmbEyeColorEdit.Text;
                criminal.SpecialFeatures = txtSpecialFeaturesEdit.Text;
                criminal.CrimeType = cmbCrimeTypeEdit.Text;
                criminal.CrimePlace = txtCrimePlaceEdit.Text;
                criminal.CourtDecision = txtCourtDecisionEdit.Text;
                criminal.PhotoPath = PhotoFileName;

                archive.SaveArchive();
                MessageBox.Show("Дані змінено.", "Успіх", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Усі поля обов'язкові для заповнення.", 
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txtFirstNameEdit.Text) ||
                string.IsNullOrWhiteSpace(txtLastNameEdit.Text) ||
                string.IsNullOrWhiteSpace(txtNicknameEdit.Text) ||
                string.IsNullOrWhiteSpace(cmbGenderEdit.Text) ||
                string.IsNullOrWhiteSpace(txtBirthPlaceEdit.Text) ||
                string.IsNullOrWhiteSpace(txtLastResidenceEdit.Text) ||
                string.IsNullOrWhiteSpace(txtCitizenshipEdit.Text) ||
                string.IsNullOrWhiteSpace(txtHeightEdit.Text) ||
                string.IsNullOrWhiteSpace(cmbHairColorEdit.Text) ||
                string.IsNullOrWhiteSpace(cmbEyeColorEdit.Text) ||
                string.IsNullOrWhiteSpace(txtSpecialFeaturesEdit.Text) ||
                string.IsNullOrWhiteSpace(cmbCrimeTypeEdit.Text) ||
                string.IsNullOrWhiteSpace(txtCrimePlaceEdit.Text) ||
                string.IsNullOrWhiteSpace(txtCourtDecisionEdit.Text))
            {
                return false;
            }

            if (!int.TryParse(txtHeightEdit.Text, out _))
            {
                return false;
            }

            return true;
        }

        private void OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void OnlyLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void OnlyLetterOrHyphenOrSpace_KeyPress(object sender, 
            KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != '-' && 
                e.KeyChar != ' ' && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
    }
}