using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DatabaseContext db;

        private DbSet<T> _dbSet;
        public Repository()
        {
          db = new DatabaseContext();
            _dbSet = db.Set<T>();
            
        }

        public async Task<int> Delete(T nesne)
        {
           
            _dbSet.Remove( nesne );
            return await db.SaveChangesAsync();
        }

        public async Task<T> Find(Expression<Func<T, bool>> kosul)
        {
           
            return await _dbSet.FirstAsync(kosul);
        }

        public async  Task<int> Insert(T nesne)
        {
          
            return await db.SaveChangesAsync();
        }

        public async Task<List<T>> Liste()
        {
            
            return await _dbSet.ToListAsync();
        }

        public async Task<List<T>> Liste(Expression<Func<T, bool>> kosul)
        {
            return await _dbSet.Where(kosul).ToListAsync();
        }



        public async Task<int> Update(T nesne)
        {
            return await db.SaveChangesAsync();
        }
    }
}
