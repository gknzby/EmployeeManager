using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.NoteBook
{
    class NoteBook
    {
        int noteCount = 0;
        string userID;
        string notesPath;
        List<Note> noteList;
        FileReadWrite fileRW;

        public List<Note> NoteList { get => noteList; set => noteList = value; }

        public NoteBook(string _userID)
        {
            userID = _userID;
            fileRW = new FileReadWrite();
            notesPath = "notes.csv";
            noteList = new List<Note>();
            LoadUserNotes();
        }
        public void LoadUserNotes()
        {
            string[] allNotes = fileRW.CsvFileRead(notesPath);


            //find which part is belong to this user
            int i = 0;
            int count;
            while (i < allNotes.Length) //search all notes, notes systematic is => userID, note count, {note1}, {note2}
            {
                if (allNotes[i] == userID)
                    break;

                count = int.Parse(allNotes[i + 1]);
                i += 2 + count * 2; //note size is 2 string
            }

            if (allNotes.Length <= i) // if can't find
            {
                return;
            }

            Note note;
            count = int.Parse(allNotes[i + 1]);
            noteCount = count;
            i = i + 2;
            for (int j = 1; j <= count; j++)
            {
                note = new Note(allNotes[i], allNotes[i + 1]);
                noteList.Add(note);
                i += 2;
            }
        }
        public void SaveUserNotes()
        {
            string[] allNotes = fileRW.CsvFileRead(notesPath);

            //find which part is belong to this user
            int i = 0;
            int count;
            while (i < allNotes.Length) //search all notes, notes systematic is => userID, note count, {note1}, {note2}
            {
                if (allNotes[i] == userID)
                    break;

                count = int.Parse(allNotes[i + 1]);
                i += 2 + count * 2; //note size is 2 string
            }

            List<string> allNotesList = new List<string>();
            for (int j = 0; j < allNotes.Length; j++)
            {
                allNotesList.Add(allNotes[j]);
            }

            if (allNotes.Length <= i) // if can't find
            {
                allNotesList.Add(userID);
                allNotesList.Add(noteList.Count.ToString());

                for (int j = 0; j < noteList.Count; j++)
                {
                    allNotesList.Add(noteList[j].Header);
                    allNotesList.Add(noteList[j].Content);
                }
            }
            else //if find, first remove previous items then add new items
            {
                count = int.Parse(allNotes[i + 1]);
                allNotesList.RemoveRange(i + 1, 1 + count * 2);
                allNotesList.Insert(i + 1, noteList.Count.ToString());
                i += 2;
                for (int j = 0; j < noteList.Count; j++)
                {
                    allNotesList.Insert(i + j * 2 + 0, noteList[j].Header);
                    allNotesList.Insert(i + j * 2 + 1, noteList[j].Content);
                }
            }
            fileRW.CsvFileWrite(notesPath, allNotesList);
        }
        public void AddNote(string header, string content)
        {
            noteList.Add(new Note(header, content));
            noteCount++;
        }
        public void RemoveNote(Note note)
        {
            noteList.Remove(note);
            noteCount--;
        }
        public void RemoveNote(int index)
        {
            noteList.RemoveAt(index);
            noteCount--;
        }
        public void ChangeNote(int index, string header, string content)
        {
            noteList[index].ChangeNote(header, content);
        }
    }
}
