using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    [Serializable]

    public class InfoCriminal
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
        public System.Drawing.Image Photo { get; set; }
        public List<InfoCriminal> Criminals { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}