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
        public DataDataContext cnn = new DataDataContext(@"Data Source=DESKTOP-D5CHB5F;Initial Catalog=QLKHO;Integrated Security=True");
        public static DataDataContext cnn2 = new DataDataContext(@"Data Source=DESKTOP-D5CHB5F;Initial Catalog=QLKHO;Integrated Security=True");
        public static DataDataContext cnn3 = new DataDataContext(@"Data Source=DESKTOP-D5CHB5F;Initial Catalog=QLKHO;Integrated Security=True");

    }
}
