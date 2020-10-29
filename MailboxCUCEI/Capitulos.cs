using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailboxCUCEI
{
    public class Capitulos
    {
        int ID, Number;
        string Name, Filename;

        public Capitulos(int iD, string name, int number, string filename)
        {
            ID = iD;
            Number = number;
            Name = name;
            Filename = filename;
        }
        public int GetID ()
        {
            return ID;
        }
        public int GetNumber()
        {
            return Number;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetFilename()
        {
            return Filename;
        }
    }
}
