using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Enum
{
    enum OrderStatus :int 
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED =2,
        DELIEVERED =3,
    }
}
