using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Models
{
    public class Airport
    {
        public string destination { get; set; }
        public int flight { get; set; }
        public string time { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"---> Пункт назначения - {destination}")
                .AppendLine($"\tРейс - {flight}")
                .AppendLine($"\tВремя отправления - {time}")
                .ToString();
        }
    }
}
