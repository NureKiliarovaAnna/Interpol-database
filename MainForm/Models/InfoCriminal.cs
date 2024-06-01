using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    public class InfoCriminal
    {
        public string Name { get; set; }
        public string Прізвище { get; set; }
        public string Кличка { get; set; }
        public string Стать { get; set; } // "жіноча", "чоловіча"
        public DateTime Дата_народження { get; set; }
        public string Місце_народження { get; set; }
        public string Останнє_місце_проживання { get; set; }
        public string Громадянство { get; set; }
        public int Зріст { get; set; }
        public string Колір_волосся { get; set; }
        public string Колір_очей { get; set; }
        public string Особливі_прикмети { get; set; }
        public string Тип_повідомлення { get; set; }
        public string Тип_злочину { get; set; }
        public DateTime Дата_скоєння_злочину { get; set; }
        public string Місце_скоєння_злочину { get; set; }
        public string Судове_рішення { get; set; }
        public bool Злочинні_угруповання { get; set; }
        public List<InfoCriminal> Спільники { get; set; }

        public InfoCriminal()
        {
            Спільники = new List<InfoCriminal>();
        }

        public override string ToString()
        {
            return $"{Name} {Прізвище} ({Кличка})";
        }
    }
}