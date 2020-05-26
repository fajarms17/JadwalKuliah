using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    [Table("Dosen")]
    public class Dosen:BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required, StringLength(30)]
        public string nama_dosen { get; set; }

        public long kode_hari { get; set; }
        public long kode_matkul { get; set; }
        public long kode_kls { get; set; }

    }
}
