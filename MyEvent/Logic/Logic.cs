using MyEvent.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent.Logic
{
    public class Logic
    {
        public Logic()
        {
            Db = new DummyDatabase();
            SearchLogic = new SearchLogic(Db);
        }

        private DummyDatabase Db { get; set; }
        public SearchLogic SearchLogic { get; set; }
    }
}
