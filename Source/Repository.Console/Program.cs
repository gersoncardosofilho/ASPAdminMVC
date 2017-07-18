using Repositorio.DAL.Repositories;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
        }

        private static void Add()
        {
            using (var repUsers = new UserRepository())
            {
                new List<User>
                {
                    new User { Username="Eliane", Password="teste", IsActive=true, RegisterDate=DateTime.Now, ProfileId=1  }
                }.ForEach(repUsers.AddUser);

                repUsers.SaveAll();

                System.Console.WriteLine("Usuários salvos com sucesso!");

                System.Console.WriteLine("Usuários Cadastrados: ");
                foreach (var c in repUsers.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.IdUser, c.Username);
                }
                System.Console.ReadKey();
            }
        }
    }
}
