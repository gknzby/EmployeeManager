using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje.NoteBook
{
    class Note
    {
        string header;
        string content;

        public Note(string _header, string _content)
        {
            ChangeNote(_header, _content);
        }

        public string Header { get => header; set => header = value; }
        public string Content { get => content; set => content = value; }

        public void ChangeNote(string _header, string _content)
        {
            header = _header;
            content = _content;
        }
        public string[] GetInfo()
        {
            string[] info = { header, content };
            return info;
        }
    }
}
