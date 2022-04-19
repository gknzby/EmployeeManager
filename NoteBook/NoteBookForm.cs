using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.NoteBook
{
    public partial class NoteBookForm : Form
    {
        Form appForm;
        NoteBook nBook;
        int dtgIndex;
        int changeStat = 0;

        public NoteBookForm(Form _appForm, string userID)
        {
            InitializeComponent();
            nBook = new NoteBook(userID);
            appForm = _appForm;
            ListNotes();
        }

        private void NoteBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changeStat == 1)
            {
                var closeMsg = MessageBox.Show("Değişiklilerinizi kaydetmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (closeMsg == DialogResult.Yes)
                {
                    nBook.SaveUserNotes();
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
            else
            {
                appForm.Show();
            }
        }
        private void ListNotes()
        {
            dataGridNotes.Rows.Clear();
            string[] note;
            for (int i = 0; i < nBook.NoteList.Count; i++)
            {
                note = nBook.NoteList[i].GetInfo();
                dataGridNotes.Rows.Add(note[0], note[1]);
            }
        }
        private void AddNote(object sender, EventArgs e)
        {
            nBook.AddNote(txtHeader.Text, txtContent.Text);
            ListNotes();
            changeStat = 1;
        }

        private void ChangeNote(object sender, EventArgs e)
        {
            if (dtgIndex < 0 || dataGridNotes.Rows.Count - 1 < dtgIndex)
            {
                MessageBox.Show("Önce yandan bir not seçiniz", "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nBook.NoteList[dtgIndex].Header = txtHeader.Text;
            nBook.NoteList[dtgIndex].Content = txtContent.Text;

            ListNotes();
            changeStat = 1;
        }

        private void RemoveNote(object sender, EventArgs e)
        {
            if (dtgIndex < 0 || dataGridNotes.Rows.Count - 1 < dtgIndex)
            {
                MessageBox.Show("Önce yandan bir not seçiniz", "Hatalı Girdi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            nBook.RemoveNote(dtgIndex);
            ListNotes();
            changeStat = 1;
        }

        private void SaveNotes(object sender, EventArgs e)
        {
            changeStat = 0;
            nBook.SaveUserNotes();
            appForm.Show();
            this.Close();
        }
        private void CancelChanges(object sender, EventArgs e)
        {
            appForm.Show();
            this.Close();
        }
        private void dataGridNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgIndex = e.RowIndex;
            if (dtgIndex < 0) return;
            txtHeader.Text = nBook.NoteList[dtgIndex].Header;
            txtContent.Text = nBook.NoteList[dtgIndex].Content;
        }
    }
}
