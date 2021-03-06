using FindHome_BLL.Contracts;
using FindHome_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_BLL.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
      
        public UnitOfWork(Context context)
           
        {
            _context = context;
            
            //UnitOfWork tüm repositoryleri oluşturacak.
            HousingRepository = new HousingRepository(_context);
            HousingTypeRepository = new HousingTypeRepository(_context);
            OwnerRepository = new OwnerRepository(_context);
            BuyingTypeRepository = new BuyingTypeRepository(_context);
           
        }

        public IHousingRepository HousingRepository { get; private set; }

        public IHousingTypeRepository HousingTypeRepository { get; private set; }

        public IOwnerRepository OwnerRepository { get; private set; }

        public IBuyingTypeRepository BuyingTypeRepository { get; private set; }

       
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

