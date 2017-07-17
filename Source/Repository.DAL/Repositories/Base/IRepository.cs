using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL.Repositories.Base
{
    interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> DoLogin(Func<TEntity,bool> predicate);
        TEntity Find(params object[] key);
        void AddUser(TEntity obj);
        void ChangeUserProfile(TEntity obj);
        void DeleteUser(Func<TEntity, bool> predicate);


    }
}
