using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Scripture
{
    private string _text;
    private Reference _scriptureSearch;

    public Scripture(Reference scriptureSearch , string text)
    {
        _scriptureSearch = scriptureSearch  ;
        _text = text;
    }

    public string toString()
    {
        return string.Format("{0}", _text);
    }
}