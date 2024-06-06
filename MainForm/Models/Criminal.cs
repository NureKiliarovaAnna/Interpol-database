using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// Клас містить поля з даними про злочинця

namespace Interpol.Models
{
    [Serializable]

    public class Criminal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string LastResidence { get; set; }
        public string Citizenship { get; set; }
        public int Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string SpecialFeatures { get; set; }
        public string CrimeType { get; set; }
        public DateTime CrimeDate { get; set; }
        public string CrimePlace { get; set; }
        public string CourtDecision { get; set; }
        public string PhotoPath { get; set; }
        public List<Criminal> Criminals { get; set; }

        public Criminal()
        {
        }

        [JsonConstructor]
        public Criminal(string firstName, string lastName, string nickname,
            string gender, DateTime birthDate, string birthPlace, string 
            lastResidence, string citizenship, int height, string hairColor, 
            string eyeColor, string specialFeatures, string crimeType, 
            DateTime crimeDate, string crimePlace, string courtDecision, 
            string photoPath, List<Criminal> criminals)
        {
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickname;
            Gender = gender;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
            LastResidence = lastResidence;
            Citizenship = citizenship;
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            SpecialFeatures = specialFeatures;
            CrimeType = crimeType;
            CrimeDate = crimeDate;
            CrimePlace = crimePlace;
            CourtDecision = courtDecision;
            PhotoPath = photoPath;
            Criminals = criminals;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {CrimeDate.ToShortDateString()}";
        }
    }
}