using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsApi.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel
    {
        public Guid OrderId { get; set; }
    }
}
