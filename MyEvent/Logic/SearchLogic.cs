using MyEvent.Db;
using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent.Logic
{
    public class SearchLogic
    {
        DummyDatabase db;
        public SearchLogic(DummyDatabase database)
        {
            db = database;
        }

        public void GetUser (string? searchValue)
        {
            var result = db.ListOfUsers.Find(user => user.Email == searchValue);
            if (result == null)
            {
                Console.WriteLine(searchValue + " finns ej");
            }
            else
            {
                Console.WriteLine(
                    result.FirstName + "\n" +
                    result.LastName + "\n" +
                    result.Email + "\n" +
                    result.Requests
                    );
            }
        }
        
    public void GetUsers()
        {
            Console.WriteLine("Lista på alla deltagare:");
            foreach (var user in db.ListOfUsers)
            {
                Console.WriteLine(
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
