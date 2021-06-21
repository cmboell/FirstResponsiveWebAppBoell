using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//page that updates data and applies business rules, validates data
namespace FirstResponsiveWebAppBoell.Models
{
    public class DetermineAgeModel
    {
        //attributes
        [Required(ErrorMessage = "Please enter your name.")] // makes name a required field, error message if name isnt entered
        public String Name { get; set; }
        [Required(ErrorMessage = "Please enter your birth year.")] //makes birth year a required field, error message if birth year isnt entered
        [Range(1800, 2021, ErrorMessage = "Enter a birth year between 1800 and 2021.")]/* gives birth year a set range, error
                                                                                        * message if entered birth year is out of range*/
        public int? BirthYear { get; set; }

        //method for determining what age will be in 2021
        public  int? AgeThisYear()
        {
            //variables within the method
            const int CURRENT_YEAR = 2021;
            const int MIN_YEAR = 1800;
            int? AgeFor2021;

            if (BirthYear < MIN_YEAR || BirthYear > CURRENT_YEAR)
            { AgeFor2021 = 0; 
            }
            else
            {
                AgeFor2021 = CURRENT_YEAR - BirthYear;
            }
            return AgeFor2021; //returns value
        }
  
    }
}