using Center.Production.EntityFrameworkCore;

namespace Center.Production.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly ProductionDbContext _context;

        public InitialHostDbBuilder(ProductionDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
