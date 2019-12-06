using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Provider;

namespace DAL_KHOHANG
{
    class ConnectDB
    {
        public static DataDataContext cnn = new DataDataContext(@"Data Source=DESKTOP-L80PNMH\SQLEXPRESS;Initial Catalog=QLKHO;Integrated Security=True");
    }
}
