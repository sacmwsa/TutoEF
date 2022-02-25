using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoEF.DataAccessLayer.Entity
{
    [Table("Personnes")]
    public class Personne
    {
        [Key]
        public int PersonneId { get; set; }

        [MaxLength(55)]
        public string Firstnamee { get; set; }
        public string Lastname { get; set; }
        [EmailAddress, Required]
        public string Email { get; set; }


    }
}
