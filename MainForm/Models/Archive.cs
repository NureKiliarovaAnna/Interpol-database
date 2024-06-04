using MainForm.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm.Models
{
    public class Archive
    {
        public List<InfoCriminal> Criminals { get; set; }

        public Archive()
        {
            Criminals = new List<InfoCriminal>();
        }

        private const string FileName = "archive.json";

        public void SaveArchive(List<InfoCriminal> criminals)
        {
            using (FileStream fs = new FileStream(FileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, criminals);
            }

        public List<InfoCriminal> LoadArchive()
        {
            if (File.Exists(FileName))
            {
                using (FileStream fs = new FileStream(FileName, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Criminals = (List<InfoCriminal>)formatter.Deserialize(fs);
                    return Criminals;
                }
            }
            else
            {
                return new List<InfoCriminal>();
            }
        }
    }
}