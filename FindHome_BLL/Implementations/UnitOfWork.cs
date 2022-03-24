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

        public HousingRepository HousingRepository { get; private set; }

        public HousingTypeRepository HousingTypeRepository { get; private set; }

        public OwnerRepository OwnerRepository { get; private set; }

        public BuyingTypeRepository BuyingTypeRepository { get; private set; }

        IBuyingTypeRepository IUnitOfWork.BuyingTypeRepository => throw new NotImplementedException();

        IHousingTypeRepository IUnitOfWork.HousingTypeRepository => throw new NotImplementedException();

        IHousingRepository IUnitOfWork.HousingRepository => throw new NotImplementedException();

        IOwnerRepository IUnitOfWork.OwnerRepository => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

