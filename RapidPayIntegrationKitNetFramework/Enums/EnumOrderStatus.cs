using System;
using System.Collections.Generic;
using System.Text;

namespace RapidPayIntegration.Enums
{
    public enum EnumOrderStatus
    {
        ORDER_CREATED = 1,
        SUBMITTED = 2,
        CHARGED = 3,
        REFUNDED = 4,
        PARTIAL_REFUNDED = 5,
        FAILED = 6,
        EDGE_DECLINED = 7

    }
}
