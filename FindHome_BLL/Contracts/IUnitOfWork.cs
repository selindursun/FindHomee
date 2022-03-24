using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_BLL.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        IBuyingTypeRepository BuyingTypeRepository { get; }
        IHousingTypeRepository HousingTypeRepository { get; }
        IHousingRepository HousingRepository { get; }      
        IOwnerRepository OwnerRepository { get; }
    }
}
