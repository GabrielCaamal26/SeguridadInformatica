using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("users")]
    public class Users
    {
        [Key]           
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Ap_paterno { get; set; }
    }
}
