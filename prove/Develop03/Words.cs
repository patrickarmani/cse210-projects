using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Words
{
    private Scripture _scripture;
    private List<string> _textList;
    private int _totalWordsRemoved = 0;

    public Words(Scripture scripture1)
    {
        _scripture = scripture1;
        _textList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        _textList = _scripture.toString().Split(" ").ToList();
    }

    public void removeWords()
    {
        int quantityWordsToRemove = 3;
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, _textList.Count());
            if (_textList[rndIndex].Contains('_') == false)
            {
                _textList[rndIndex] = new string('_', _textList[rndIndex].Length);
                wordsRemoved++;
                _totalWordsRemoved++;

                if ((_textList.Count() - quantityWordsToRemove) <= _totalWordsRemoved && _totalWordsRemoved < (_textList.Count() + 1))
                {
                    wordsRemoved = 3;
                }
            }

        } while (wordsRemoved != quantityWordsToRemove);
    }

    public string toString()
    {
        return string.Join(" ", _textList);
    }

    public bool hasWordsLeft()
    {
        bool retValue = false;

        foreach (string word in _textList)
        {
            if (word.Contains("_") == false)
            {
                retValue = true;
                break;
            }
        }

        return retValue;
    }
}