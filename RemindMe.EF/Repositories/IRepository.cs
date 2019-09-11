using System;
using System.Collections.Generic;
using System.Text;

namespace RemindMe.EF.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);

        IEnumerable<T> Get();

        T Create(T value);

        void Update(T value);

        void Delete(int id);
    }
}
