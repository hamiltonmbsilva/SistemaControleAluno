using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaControleAluno.Models
{
    public class GruposDetalhes
    {
        [Key]
        public int GrouposDetalhesId { get; set; }

        public int GrupoId { get; set; }

        public int UserId { get; set; }

        public virtual Grupos Grupos { get; set; }

        public virtual Usuario Estudante { get; set; }

        public string GrupoEstudante { get { return string.Format("{0} / {1}", Grupos.Descricao, Estudante.NomeCompleto); } }

        public virtual ICollection<Notas> Notas { get; set; }

    }
}