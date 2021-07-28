using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsApi.ResponseModels.CommandResponseModels
{
    public class MakeOrderResponseModel
    {
        public bool IsSucces { get; set; }
        public Guid OrderId { get; set; }
    }
}
