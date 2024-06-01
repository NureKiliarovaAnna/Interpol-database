using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Models
{
    public class Archive
    {
        public List<InfoCriminal> Criminals { get; set; }

        public Archive()
        {
            Criminals = new List<InfoCriminal>();
        }
    }
}