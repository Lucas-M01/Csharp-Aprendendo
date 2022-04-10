using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFEnumeracao.Entities.Enums
{
    enum OrderStatus : int
    {
        Peding_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
