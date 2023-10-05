using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public class SUVFactory : ICarFactory
    {
        public IAudi CreateAudi()
        {
            return new AudiSUV();
        }

        public IBMW CreateBMW()
        {
            return new BMWSUV();
        }

        public ITesla CreateTesla()
        {
            return new TeslaSUV();
        }
    }
}
