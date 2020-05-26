using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [Table("Kelas")]
    public class Kelas:BaseTable
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required, StringLength(5)]
        public string kls { get; set; }

        public long kode_hari { get; set; }
        public long kode_matkul { get; set; }
        public long kode_dosen { get; set; }


    }
}
