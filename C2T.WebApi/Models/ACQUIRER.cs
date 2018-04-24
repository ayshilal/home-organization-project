using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace C2T.WebApi
{
    [Table("ACQUIRER")]
    public class ACQUIRER 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        [Column("ACQUIRER_ID")]
        public int ACQUIRER_ID { get; set; }

        [Column("NAME")]
        public string NAME { get; set; }
     
    }
}
