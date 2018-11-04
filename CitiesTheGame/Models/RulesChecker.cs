using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CitiesTheGame.Models
{
    public class RulesChecker
    {
        private HashSet<ValidationResult> validationResults = new HashSet<ValidationResult>();
        private string cityName { get; }
        private string userName { get;  }

        public RulesChecker(string cityName, string userName)
        {
            this.cityName = cityName;
            this.userName = userName;
        }


        public HashSet<ValidationResult> ValidateAll()
        {
            IsCityEmpty();
            IsNameNull();
            if (!validationResults.Any())
            {
                IsCorrectLetter();
                HasCityUsed();
                IsCityReal();
            }
            return validationResults;
        }


        public void HasCityUsed()
        {
            if (Cities.CitiesThatWereUsed.ContainsValue(cityName.ToUpper()))
            {
                validationResults.Add(new ValidationResult("This city was arleady"));
            }
        }

        public void IsCityReal()
        {

            if (!validationResults.Any())
            {
                if (!Cities.CitiesTable.Contains(cityName.ToUpper()))
                {
                    validationResults.Add(new ValidationResult("City is not real"));
                }
            }

        }
        public void IsCorrectLetter()
        {
            if (!CorrectLetterSarted(cityName, Cities.StartLetter) && Cities.StartLetter != 0)
            {
                validationResults.Add(new ValidationResult("Wrong Letter started"));
            }
        }


        public void IsCityEmpty()
        {
            if (string.IsNullOrEmpty(cityName))
            {
                validationResults.Add(new ValidationResult("Your answer is empty"));
            }
        }

        public void IsNameNull()
        {

            if (string.IsNullOrWhiteSpace(userName))
            {
                validationResults.Add(new ValidationResult("What is ur name?"));
            }


        }
        public bool CorrectLetterSarted(string word, char letter)
        {
            return word[0].ToString().ToUpper() == letter.ToString().ToUpper();
        }
    }
}