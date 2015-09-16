using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandle;
using DataHandle.Models;

namespace DataHandleExample
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                IAppContext dataContext = new AppContext("MyConnectionString");

                var userService  = new UserService(dataContext);

                UserViewModel vModel = new UserViewModel();

                IList<User> users = new List<User>();

                for (
                    int ii = 0; ii < 9; ii++)
                {
                    users.Add(

                        userService.Create(
                            new UserViewModel
                            {
                                Id = ii,
                                GroupId = 1,
                                Username = string.Format("User#{0}", ii),
                                Password = (ii * 1000).ToString(),
                                
                            }
                            , true
                        )
                    );

                }


                foreach (var user in users)
                {
                    Console.WriteLine("{1}'s password is {2} and has {0} as Id", user.Id, user.Username, user.Password);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}, {1}", ex.Message, ex.InnerException.InnerException);
            }

            Console.Write("Press any key to close...");
            Console.Read();
        }
    }
}
