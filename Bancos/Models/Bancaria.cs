using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bancos.Models
{
    [Table("Bancaria", Schema = "public")]
    public class Bancaria
    {
        [Key]
        public string Oid { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
    }
}