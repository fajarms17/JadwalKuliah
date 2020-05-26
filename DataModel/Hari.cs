using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [Table("Hari")]
    public class Hari:BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required, StringLength(10)]
        public string nama_hari { get; set; }

    }
}
