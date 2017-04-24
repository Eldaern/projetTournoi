using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projetTournoi
{
    class dataTor
    {
        connection connTor= new connection();

        public TorDBDataSet torDS;

        public void updTor()
        {
            torDS = connTor.UpDataSet();
        }
    }
}
