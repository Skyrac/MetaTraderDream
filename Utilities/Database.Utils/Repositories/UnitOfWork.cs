using Microsoft.EntityFrameworkCore;

namespace Database.Utils.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected virtual DbContext _context { get; }

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
