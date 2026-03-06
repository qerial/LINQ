using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    public class ClientData
    {
        public static readonly List<Client> clients = new List<Client>()
        {
             new Client() {Id = 1, Name = "Andrus", City = "Tallinn"},
             new Client() {Id = 2, Name = "Alfred", City = "Moskva"},
             new Client() {Id = 3, Name = "Mia", City = "Tallinn"},
             new Client() {Id = 4, Name = "Leo", City = "Paris"},
             new Client() {Id = 5, Name = "Martin", City = "Tallinn" },
        };
    }
}
