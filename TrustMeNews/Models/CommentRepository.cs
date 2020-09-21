using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrustMeNews.Data;

namespace TrustMeNews.Models
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly TrustMeNewsDataContext dbContext;

        public CommentRepository(TrustMeNewsDataContext dbContext)
        {
            dbContext = dbContext;
        }

        public Comment Create(Comment model)
        {
            dbContext.Comments.Add(model);
            dbContext.SaveChanges();
            return model;
        }

        public Comment Delete(int id)
        {
            Comment toRemove = dbContext.Comments.Find(id);

            if (toRemove != null)
            {
                dbContext.Remove(toRemove);
                dbContext.SaveChanges();
            }

            return toRemove;
        }

        public Comment Get(int id)
        {
            return dbContext.Comments.Find(id);
        }

        public IEnumerable<Comment> GetAll()
        {
            return dbContext.Comments;
        }

        public Comment Update(Comment objectChanges)
        {
            var comment = dbContext.Comments.Attach(objectChanges);
            comment.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

            return objectChanges;
        }
    }
}
