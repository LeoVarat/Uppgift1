using MyEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent.Db
{
    public class DummyDatabase
    {
        List<User> listOfUsers = new List<User>() {

            new User( )
            {
                Id = 1,
                FirstName = "Urban",
                LastName = "Karlsson",
                Email = "urban.k@telia.se",
                Requests = "None"
            },

            new User
            {
                Id = 2,
                FirstName = "Obi-Wan",
                LastName = "Kenobi",
                Email = "not.anakin@gmail.com",
                Requests = "Glutenallergi"
            },

            new User
            {
                Id = 3,
                FirstName = "Jar-Jar",
                LastName = "Bings",
                Email = "jarjar@hotmail.com",
                Requests = "Alkoholfritt"
            }
        };

    }
}
