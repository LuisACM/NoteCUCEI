using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailboxCUCEI
{
    public class Usuario
    {
        int codigo;
        string Nombre;
        string F_Nacimiento;
        string Pass;
        string Correo;
        string Fo_Perfil;

        public Usuario(int codigo, string nombre, string f_Nacimiento, string pass, string correo, string fo_Perfil)
        {
            this.codigo = codigo;
            Nombre = nombre;
            F_Nacimiento = f_Nacimiento;
            Pass = pass;
            Correo = correo;
            Fo_Perfil = fo_Perfil;
        }
        public int GetID ()
        {
            return codigo;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetF_Nacimiento()
        {
            return F_Nacimiento;
        }
        public string GetPass()
        {
            return Pass;
        }
        public string GetCorreo()
        {
            return Correo;
        }
        public string GetFo_Perfil()
        {
            return Fo_Perfil;
        }
    }
    
}
