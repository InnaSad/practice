using _1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Airport airport);
        void Delete(string destination);
        Airport FindBy(string destination);
        List<Airport> GetAll();
    }
}
