using CitiesTheGame.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CitiesTheGame.ViewModels
{
    public class CitiesViewModel : IValidatableObject 
    {
        public Dictionary<char[], string> collectedCities;
        public string CityName { get; set; }
        public string PersonName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            RulesChecker rulesChecker = new RulesChecker();
            if (string.IsNullOrEmpty(CityName))
            {
                yield return new ValidationResult("Your answer is empty");
            }
            else if (!rulesChecker.CorrectLetterSarted(CityName, Cities.StartLetter) && Cities.StartLetter != 0)
            {
                yield return new ValidationResult("Wrong Letter started");
            }
            else if (!Cities.cities.Contains(CityName.ToUpper()))
            {
                yield return new ValidationResult("City is not real");
            }
            else if(Cities.citiesThatWere.ContainsValue(CityName.ToUpper()))
            {
                yield return new ValidationResult("This city was arleady");
            }
            else if (string.IsNullOrWhiteSpace(PersonName))
            {
                yield return new ValidationResult("What is ur name?");
            }


        }
    }
}