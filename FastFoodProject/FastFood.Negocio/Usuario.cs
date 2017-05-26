using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Negocio
{
    public class Usuario
    {

        public int id_usuario;
        public string usuario1;
        public string password;
        public string titular;
        public string rut;
        public int tipoUsuario;

        public Usuario()
        {
            this.Init();
        }
        private void Init()
        {
            this.id_usuario = 0;
            usuario1 = string.Empty;
            password = string.Empty;
            titular = string.Empty;
            rut = string.Empty;
            tipoUsuario = 0;

        }

        //Metodos CRUD
        public bool Read()
        {
            try
            {
                DALC.Usuario user = CommonBC.ModeloFastFood.Usuario.First(userx => userx.id_usuario == id_usuario);
                id_usuario = user.id_usuario;
                usuario1 = user.usuario1;
                password = user.password;
                rut = user.rut;
                tipoUsuario = user.tipoUsuario;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create()
        {
            try
            {
                DALC.Usuario user = new DALC.Usuario();
                user.id_usuario = id_usuario;
                user.usuario1 = usuario1;
                user.password = password;
                user.rut = rut;
                user.titular = titular;
                user.tipoUsuario = tipoUsuario;

                CommonBC.ModeloFastFood.Usuario.Add(user);
                CommonBC.ModeloFastFood.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                DALC.Usuario user = CommonBC.ModeloFastFood.Usuario.First(x => x.id_usuario == id_usuario);
                user.id_usuario = id_usuario;
                user.usuario1 = usuario1;
                user.password = password;
                user.rut = rut;
                user.titular = titular;
                user.tipoUsuario = tipoUsuario;

                CommonBC.ModeloFastFood.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                DALC.Usuario user = CommonBC.ModeloFastFood.Usuario.First(p => p.id_usuario == id_usuario);

                CommonBC.ModeloFastFood.Usuario.Remove(user);
                CommonBC.ModeloFastFood.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

      
    }
}

