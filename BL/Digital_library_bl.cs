using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BL
{
    public class Digital_library_bl
    {
            Digital_library_dal  library_dal = new Digital_library_dal();
            public bool setinformation(Digital_library_entity information)
            {

                return library_dal.Set_information(information);

            }
            public bool checkinformation(Digital_library_entity information)
            {

                return library_dal.check_information(information);

            }

    }
}
