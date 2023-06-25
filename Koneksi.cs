using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace uji_nafa
{
    class Koneksi
    {
        public static MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;UID=root;PWD=;Database=db_lsp");
    }
}
