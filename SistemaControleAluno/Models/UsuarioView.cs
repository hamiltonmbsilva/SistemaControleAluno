﻿using System.Web;

namespace SistemaControleAluno.Models
{
    public class UsuarioView
    { 
        public Usuario Usuario { get; set; }

        public HttpPostedFileBase Foto { get; set; }
    }
}