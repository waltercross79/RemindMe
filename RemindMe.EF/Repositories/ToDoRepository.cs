using Microsoft.EntityFrameworkCore;
using RemindMe.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RemindMe.EF.Repositories
{
    public class ToDoRepository : IRepository<ToDo>
    {
        private readonly DataContext _dbContext;

        public ToDoRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ToDo Create(ToDo value)
        {
            _dbContext.ToDos.Add(value);

            int id = _dbContext.SaveChanges();
            value.Id = id;

            return value;
        }

        public void Delete(int id)
        {
            ToDo t = _dbContext.ToDos.Where(x => x.Id == id).SingleOrDefault();

            if(t != null)
            {
                _dbContext.Remove(t);
                _dbContext.SaveChanges();
            }
        }

        public ToDo Get(int id)
        {
            var query = from t in _dbContext.ToDos where t.Id == id select t;

            return query.SingleOrDefault();
        }

        public IEnumerable<ToDo> Get()
        {
            return _dbContext.ToDos;
        }

        public void Update(ToDo value)
        {
            ToDo t = _dbContext.ToDos.Where(x => x.Id == value.Id).SingleOrDefault();

            if (t == null)
                throw new ArgumentException("ToDo item does not exist and cannot be updated.");

            t.Description = value.Description;
            _dbContext.SaveChanges();
        }
    }
}
