using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
  
      class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(201133465, "Parjo", 3500000);
            Karyawan karyawan2 = new Karyawan(201156987, "Sujono", 4000000);

            Karyawan.Show(karyawan1, karyawan2);
            Karyawan.NaikGaji(karyawan1, karyawan2);
            Karyawan.Show(karyawan1, karyawan2);
        }
    }
}
