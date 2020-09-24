using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Data;

namespace TrustMeNews.Models
{
    public class ArticleRepository : IRepository<Result>
    {
        private readonly TrustMeNewsDataContext dbContext;

        public ArticleRepository(TrustMeNewsDataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Result Create(Result model)
        {
            dbContext.Articles.Add(model);
            dbContext.SaveChanges();
            return model;
        }

        public Result Delete(int id)
        {
            Result toRemove = dbContext.Articles.Find(id);

            if (toRemove != null)
            {
                dbContext.Remove(toRemove);
                dbContext.SaveChanges();
            }

            return toRemove;
        }

        public Result Get(int id)
        {
            return dbContext.Articles.Find(id);
        }

        public IEnumerable<Result> GetAll()
        {
            return dbContext.Articles;
        }

        public Result Update(Result objectChanges)
        {
            var result = dbContext.Articles.Attach(objectChanges);
            result.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

            return objectChanges;
        }
    }
}
