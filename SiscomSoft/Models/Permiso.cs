﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiscomSoft.Models
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        public int pkPermiso { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string sModulo { get; set; }

        public string sComentario { get; set; }

        public Boolean bStatus { get; set; }

        public ICollection<PermisoNegadoRol> PermisosNegadosRol { get; set; }

        public Permiso()
        {
            this.bStatus = true;

        }
    }
}
