using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDACNTT_QUANLYKHO
{
    public class ConnectString
    {
        public static DataDemoDataContext data = new DataDemoDataContext("Data Source=DESKTOP-D5CHB5F;Initial Catalog=QLKHO;Integrated Security=True");
    }
}
