using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NesneProje.Users
{
    public partial class BMOCalculator : Form
    {
        Form appForm;
        UserManagement userMng;
        BMOSalary bmoS;
        bool fromButton = false;
        User currentUser;

        public BMOCalculator(Form _appForm, User _currentUser, UserManagement _userMng)
        {
            InitializeComponent();

            appForm = _appForm;
            userMng = _userMng;
            currentUser = _currentUser;

            bmoS = new BMOSalary(currentUser.UserID);

            MarryWorkShowHide(false);
            LoadBMOInfo();
        }

        private void BMOCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fromButton)
                return;

            var closeMsg = MessageBox.Show("Değişiklilerinizi kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (closeMsg == DialogResult.Yes)
            {
                float _sal = bmoS.CalculateBMOSalary();
                DefineBMOInfos();
                currentUser.BmoSalary = _sal;
                userMng.UserList[userMng.GetUserIndex(currentUser.UserID)].BmoSalary = _sal;
                bmoS.SaveBMOInfo();
                appForm.Show();
            }
            else if (closeMsg == DialogResult.No)
            {
                appForm.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        void KidsShowHide(bool kid1, bool kid2)
        {
            if (kid1)
            {
                lblChild1.Show();
                cmbBxCh1.Show();
            }
            else
            {
                lblChild1.Hide();
                cmbBxCh1.Hide();
            }

            if (kid2)
            {
                lblChild2.Show();
                cmbBxCh2.Show();
            }
            else
            {
                lblChild2.Hide();
                cmbBxCh2.Hide();
            }
        }
        private void cmbBxKids_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbBxKids.SelectedIndex;

            if (index == 0)
            {
                KidsShowHide(false, false);
            }
            else if (index == 1)
            {
                KidsShowHide(true, false);
            }
            else if (index == 2)
            {
                KidsShowHide(true, true);
            }
        }


        void LansShowHide(bool lan1, bool lan2, bool lan3, bool lan4, bool lan5)
        {
            if (lan1)
            {
                lblLan1.Show();
                txtLan1.Show();
            }
            else
            {
                lblLan1.Hide();
                txtLan1.Hide();
            }

            if (lan2)
            {
                lblLan2.Show();
                txtLan2.Show();
            }
            else
            {
                lblLan2.Hide();
                txtLan2.Hide();
            }

            if (lan3)
            {
                lblLan3.Show();
                txtLan3.Show();
            }
            else
            {
                lblLan3.Hide();
                txtLan3.Hide();
            }

            if (lan4)
            {
                lblLan4.Show();
                txtLan4.Show();
            }
            else
            {
                lblLan4.Hide();
                txtLan4.Hide();
            }

            if (lan5)
            {
                lblLan5.Show();
                txtLan5.Show();
            }
            else
            {
                lblLan5.Hide();
                txtLan5.Hide();
            }
        }
        private void cmbBxLans_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbBxLans.SelectedIndex;

            if (index == 0)
            {
                LansShowHide(false, false, false, false, false);
            }
            else if (index == 1)
            {
                LansShowHide(true, false, false, false, false);
            }
            else if (index == 2)
            {
                LansShowHide(true, true, false, false, false);
            }
            else if (index == 3)
            {
                LansShowHide(true, true, true, false, false);
            }
            else if (index == 4)
            {
                LansShowHide(true, true, true, true, false);
            }
            else if (index == 5)
            {
                LansShowHide(true, true, true, true, true);
            }
        }

        void MarryWorkShowHide(bool Married)
        {
            if(Married)
            {
                lblCoWork.Show();
                chkBxCoWork.Show();
            }
            else
            {
                lblCoWork.Hide();
                chkBxCoWork.Hide();
            }
        }
        private void chkBxMarried_CheckedChanged(object sender, EventArgs e)
        {
            bool married = chkBxMarried.Checked;

            MarryWorkShowHide(married);
        }


        List<string> GetLanguages()
        {
            int index = cmbBxLans.SelectedIndex;
            List<string> lans = new List<string>();

            if (0 < index)
                lans.Add(txtLan1.Text);
            if (1 < index)
                lans.Add(txtLan2.Text);
            if (2 < index)
                lans.Add(txtLan3.Text);
            if (3 < index)
                lans.Add(txtLan4.Text);
            if (4 < index)
                lans.Add(txtLan5.Text);

            return lans;
        }
        string[] GetKids()
        {
            int index = cmbBxKids.SelectedIndex;
            string[] kids = new string[2];

            if (0 < index)
                kids[0] = cmbBxCh1.SelectedIndex.ToString();
            else
                kids[0] = "3";
            if(1 < index)
                kids[1] = cmbBxCh2.SelectedIndex.ToString();
            else
                kids[1] = "3";

            return kids;
        }

        void DefineBMOInfos()
        {
            List<string> _lanKn = GetLanguages();
            string _enKn = chkBxEn.Checked ? "1" : "0";
            string _exp = txtExp.Text;
            string _hCity = cmbBxHCity.SelectedItem.ToString();
            string _wCity = cmbBxWCity.SelectedItem.ToString();
            string _educ = cmbBxEduc.SelectedIndex.ToString();
            string _pos = cmbBxPos.SelectedIndex.ToString();
            string _married = !chkBxMarried.Checked ? "-1" : (chkBxCoWork.Checked ? "1" : "0");
            string[] _childs = GetKids();

            bmoS.DefineBMOInfo(_lanKn, _enKn, _exp, _hCity, _wCity, _educ, _pos, _married, _childs);
        }
        private void CalculateSalary(object sender, EventArgs e)
        {
            DefineBMOInfos();

            float salary = bmoS.CalculateBMOSalary();
            int type = currentUser.UserType;

            if (type == 2)
                txtSalary.Text = (salary / 2.0f).ToString();
            else
                txtSalary.Text = salary.ToString();
        }
        void LoadBMOInfo()
        {
            SetLanguages();
            chkBxEn.Checked = bmoS.EnKnowledge == "1" ? true : false;
            txtExp.Text = bmoS.Experience;
            cmbBxHCity.SelectedIndex = cmbBxHCity.FindString(bmoS.HomeCity);
            cmbBxWCity.SelectedIndex = cmbBxWCity.FindString(bmoS.WorkCity);
            cmbBxEduc.SelectedIndex = int.Parse(bmoS.Education);
            cmbBxPos.SelectedIndex = int.Parse(bmoS.Position);
            chkBxMarried.Checked = bmoS.Married != "-1" ? true : false;
            chkBxCoWork.Checked = bmoS.Married == "1" ? true : false;

            cmbBxKids.SelectedIndex = bmoS.Childs[0] != "3" ? 1 : 0;
            cmbBxKids.SelectedIndex += bmoS.Childs[1] != "3" ? 1 : 0;

            cmbBxCh1.SelectedIndex = int.Parse(bmoS.Childs[0]);
            cmbBxCh2.SelectedIndex = int.Parse(bmoS.Childs[1]);
        }
        void SetLanguages()
        {
            int index = bmoS.LanKnowledge.Count;
            cmbBxLans.SelectedIndex = index;

            if (0 < index)
                txtLan1.Text = bmoS.LanKnowledge[0];
            if (1 < index)
                txtLan2.Text = bmoS.LanKnowledge[1];
            if (2 < index)
                txtLan3.Text = bmoS.LanKnowledge[2];
            if (3 < index)
                txtLan4.Text = bmoS.LanKnowledge[3];
            if (4 < index)
                txtLan5.Text = bmoS.LanKnowledge[4];
        }

        private void SaveClose(object sender, EventArgs e)
        {
            fromButton = true;

            float _sal = bmoS.CalculateBMOSalary();
            DefineBMOInfos();
            currentUser.BmoSalary = _sal;
            userMng.UserList[userMng.GetUserIndex(currentUser.UserID)].BmoSalary = _sal;
            bmoS.SaveBMOInfo();
            appForm.Show();
            this.Close();
        }

        private void CancelClose(object sender, EventArgs e)
        {
            fromButton = true;

            appForm.Show();
            this.Close();
        }
    }
}
