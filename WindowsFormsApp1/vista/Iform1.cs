﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.vista
{
    public interface Iform1

    {
        //campos 
        string UsuarioNombre { get; set; }
        string Usuarioid { get; set; }
        int UsuarioEdad {get; set ;}
        string UsuarioDiscapacidad {get; set;}
        string BuscarUsuario{get; set; }
        int PagoUsuario { get; set; }

        string  IdObetnidoDataGrid { get; set; }


        event EventHandler EventoBuscar;
        event EventHandler EventoSelecionarUsuario;
        void EstablecerListaDatagrid(BindingSource lista);
        void EstablecerListaLecturaDatagrid(BindingSource lista);
        void Show();
       


    }
}