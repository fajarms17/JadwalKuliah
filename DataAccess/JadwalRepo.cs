using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace DataAccess
{
    public class JadwalRepo
    {
        public static List<JadwalViewModel> GetBySearch(string search)
        {
            List<JadwalViewModel> result = new List<JadwalViewModel>();

            using (var db = new DataContext())
            {

                result = (from c in db.Kelas
                          join d in db.Hari
                          on c.kode_hari equals d.id
                          join e in db.MataKuliah
                          on c.kode_matkul equals e.id
                          join f in db.Dosen
                          on c.kode_dosen equals f.id
                          
                          where c.kls.Contains(search)||f.nama_dosen.Contains(search)
                          orderby d.id ascending
                          select new JadwalViewModel
                          {
                              id = c.id,
                              kelas=c.kls,
                              hari=d.nama_hari,
                              matkul=e.matkul,
                              dosen=f.nama_dosen

                          }).ToList();
            }

            return result;
        }

    }
}
