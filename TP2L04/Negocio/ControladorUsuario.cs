﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public class ControladorUsuario
    {

        public ControladorUsuario()
        {
        }
        //Instancio un Adaptador de Usuario
        //Me va a devolver los datos de la BD

        private CatalogoUsuario usuarioData = new CatalogoUsuario();

        //Metodo que le pide al Adaptador que le de un usuario
        public Usuario dameUno(int id)
        {
            return usuarioData.GetOne(id);
        }
        //Metodo que le pide todos los usuarios
        public List<Usuario> dameTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = usuarioData.GetAll();
            return usuarios;
        }
        //Metodo que le pide que guarde el usuario
        public void guardarUsuario(Usuario usu)
        {
            Usuario usuario = usu;
            usuarioData.Save(usuario);
        }
        //Metodo que le pide que elimine el usuario
      
    }
}

