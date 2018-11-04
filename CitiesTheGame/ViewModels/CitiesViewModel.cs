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
        public Dictionary<char[], string> CollectedCities;
        public string CityName { get; set; }
        public string PersonName { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            RulesChecker rulesChecker = new RulesChecker(CityName,PersonName);
            return rulesChecker.ValidateAll();
        }
    }
}