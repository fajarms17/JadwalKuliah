using System;
using System.Diagnostics;
using System.Linq;
using DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jadwal.UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Trace.WriteLine("---Start--");
            using (var db = new DataContext())
            {
                var ListKelas = db.Kelas.ToList();
            }
            Trace.WriteLine("--End--");
        }
    }
}
