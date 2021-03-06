﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiscomSoft.Models
{
    [Table("Preferencias")]
    public class Preferencia
    {
        [Key]
        public int pkPreferencia { get; set; }

        public string sLogotipo { get; set; }

        public string sForImpreso { get; set; }

        public string sNumSerie { get; set; }

        public string sEnvFactura { get; set; }

        public Boolean bStatus { get; set; }

        public ICollection<Sucursal> Sucursales { get; set; }

        public Preferencia()
        {
            this.bStatus = true;
        }
    }
}
