using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailboxCUCEI
{
    public class Historias
    {
        int ID, ID_User, Follows, Favs, Views;
        string Name, Cover, Gender, Summary, Raiting, Status, Usuario;
        public string GetName ()
        {
            return Name;
        }
        public string GetGender()
        {
            return Gender;
        }
        public string GetSummary()
        {
            return Summary;
        }
        public string GetRaiting()
        {
            return Raiting;
        }
        public string GetStatus()
        {
            return Status;
        }
        public string GetCover()
        {
            return Cover;
        }

        public Historias(string name,int iD,string summary, string gender, string cover, string raiting, string status,int iD_User, int follows, int favs, int views, string User)
        {
            Cover = cover;
            ID = iD;
            ID_User = iD_User;
            Follows = follows;
            Favs = favs;
            Views = views;
            Name = name;
            Gender = gender;
            Summary = summary;
            Raiting = raiting;
            Status = status;
            Usuario = User;
        }
        public int GetID ()
        {
            return ID;
        }
        public string GetNameUser ()
        {
            return Usuario;
        }
        public int GetID_User()
        {
            return ID_User;
        }
        public int GetFollows()
        {
            return Follows;
        }
        public int GetViews()
        {
            return Views;
        }
        public int GetFavs()
        {
            return Favs;
        }

    }
}
