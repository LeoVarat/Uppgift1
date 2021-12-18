using MyEvent.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent.Logic
{
    public class ExportLogic
    {
        DummyDatabase db;
        public ExportLogic(DummyDatabase database)
        {
            db = database;
        }

        public void ExportUsers(string? path)
        {

            if (string.IsNullOrWhiteSpace(path))
            {
                path = "listOfUsers.txt";
            }
            else
            {
                path = path + "\\listOfUsers.txt";
            }

            using (var writer = new StreamWriter(path))
            {
                foreach (var user in db.ListOfUsers)
                {
                    writer.WriteLine(
                    user.Id + "\n" +
                    user.FirstName + "\n" +
                    user.LastName + "\n" +
                    user.Email + "\n" +
                    user.Requests + "\n"
                    );
                }
            }
        }
    }
}
