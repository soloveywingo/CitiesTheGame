using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitiesTheGame.Models
{
    public class RulesChecker
    {
        public bool CorrectLetterSarted(string word, char letter)
        {
            return word[0].ToString().ToUpper() == letter.ToString().ToUpper();
    }
    }
}