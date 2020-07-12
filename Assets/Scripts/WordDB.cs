
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class WordDB
{
    // public Dictionary<string, int> dictionary = new Dictionary<string, int>();
    public HashSet<String> dictionary = new HashSet<string>();
    public List<String> words7 = new List<string>();
    public List<String> words5 = new List<string>();

    public WordDB(string lang)
    {
        if (null == lang)
        {
            lang = "ca";
        }
        // dictionary.Add("ABELLA", 6);
        // dictionary.Add("CASA", 4);
        // dictionary.Add("BOSSA", 5);
        // dictionary.Add("COSA", 4);

        loadWords(lang);

    }


    private void loadWords(string lang)
    {
        FileStream fs = new FileStream("./Assets/Data/words-" + lang + ".txt", FileMode.Open,
                FileAccess.Read);

        using (StreamReader streamReader = new StreamReader(fs))   //, Encoding.UTF8))
        {
            string line = String.Empty;
            while ((line = streamReader.ReadLine()) != null)
            {
                dictionary.Add(line);
                if (isValidWord7(line))
                {
                    words7.Add(line);
                }
                else if (isValidWord5(line))
                {
                    words5.Add(line);
                }
            }
        }
    }


    bool isValidWord7(string word)
    {
        return (word.Length == 7 && countVowels(word) >= 3);
    }

    bool isValidWord5(string word)
    {
        return (word.Length == 5 && countVowels(word) >= 2);
    }

    int countVowels(string word)
    {
        return word.Count(c => "AEIOU".Contains(c));
    }

}