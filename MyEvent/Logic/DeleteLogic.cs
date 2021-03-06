using MyEvent.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent.Logic
{
    public class DeleteLogic
    {
        DummyDatabase db;
        public DeleteLogic (DummyDatabase database)
        {
            db = database;
        }

        public void DeleteUser (string? userId)
        {
            var parseSuccess = int.TryParse(userId, out int id);
            if (parseSuccess == false)
            {
                Console.WriteLine("Du har inte angivit ett korrekt Id");
                return;
            }

            var result = db.ListOfUsers.Find(user => user.Id == id);
            
            if(result != null)
            {
               var foo = db.ListOfUsers.Remove(result);

               if (foo == true)
                {
                    Console.WriteLine("Användare med ID " + id + " är borttaget");
                }
               else
                {
                    Console.WriteLine("Något gick fel, användaren blev inte borttagen");
                }
            }
            else
            {
                Console.WriteLine("Användare med ID " + id + " finns ej");
            }
        }
    }
}
