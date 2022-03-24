using FindHome_BLL.Contracts;
using FindHome_DAL;
using FindHome_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_BLL.Implementations
{

    public class OwnerRepository : Repository<Owner>, IOwnerRepository
    {
        public OwnerRepository(Context context)
           : base(context)
        {

        }
    }
}
