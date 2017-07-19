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
            //Add();
            Delete();
        }

        private static void Add()
        {
            using (var repUsers = new UserRepository())
            {
                //new List<User>
                //{
                //    new User { Username="Gerson", Password="teste", IsActive=true, RegisterDate=DateTime.Now, ProfileId=1  }
                //}.ForEach(repUsers.AddUser);

                User user = new User { Username = "Luks", Password = "teste", IsActive = true, RegisterDate = DateTime.Now, ProfileId = 1 };

                repUsers.AddUser(user);

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

        private static void Delete()
        {
            using (var repUsers = new UserRepository())
            {
                new List<User>
                {
                    new User { Username = "Luks Pinto Silva", Password = "teste", IsActive = true, RegisterDate = DateTime.Now, ProfileId = 1  },
                    new User { Username = "Luks Cardoso Filho", Password = "teste", IsActive = true, RegisterDate = DateTime.Now, ProfileId = 1  },
                    new User { Username = "Luks Guerra Cardoso", Password = "teste", IsActive = true, RegisterDate = DateTime.Now, ProfileId = 1  }
                }.ForEach(repUsers.AddUser);

                repUsers.SaveAll();

                foreach (var c in repUsers.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.Username, c.RegisterDate);
                }
                System.Console.ReadKey();

                //excluir varios clientes
                try
                {
                    repUsers.DeleteUser(c => c.Username.StartsWith("Luks"));
                    repUsers.SaveAll();
                    System.Console.WriteLine("Usuarios deletados com sucesso.");
                }
                catch (Exception)
                {

                    System.Console.WriteLine("Erro ao deletar vários usuários.");
                }
            }
        }
    }
}
