/*
 * Tlacaelel iCPAC
 * 2021
 * tlacaelel.icpac@gmail.com
 * https://github.com/icpac/Bancos
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bancos.Models
{
    [Table("MovimientoB", Schema = "public")]
    public class Movimiento
    {
        [Key]
        public string Oid { get; set; }
        public decimal Monto { get; set; }
        public string Notas { get; set; }
    }
}