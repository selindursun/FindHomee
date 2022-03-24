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
    public class HousingTypeRepository : Repository<HousingType>, IHousingTypeRepository
    {
        public HousingTypeRepository(Context context)
           : base(context)
        {

        }
    }
    
}
