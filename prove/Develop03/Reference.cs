using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Reference
    {
        private string _book;
        private string _chapter;
        private string  _verse;

        public Reference(string book, string chapter, string verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

        public string toString()
        {
            return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
        }
    }