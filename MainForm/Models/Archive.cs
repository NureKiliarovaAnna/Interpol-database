using Interpol.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

// Клас містить список усіх злочинців з даними

namespace Interpol.Models
{
    public class Archive
    {
        [JsonInclude]

        public List<Criminal> Criminals { get; set; }

        public Archive()
        {
            Criminals = new List<Criminal>();
        }

        public Archive(List<Criminal> criminals)
        {
            Criminals = criminals;
        }

        private const string FileName = "archive.json";

        public void SaveArchive()
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(FileName, jsonString);
        }

        public static Archive LoadArchive()
        {
            var jsonString = File.ReadAllText(FileName);
            return JsonSerializer.Deserialize<Archive>(jsonString);
        }
    }
}