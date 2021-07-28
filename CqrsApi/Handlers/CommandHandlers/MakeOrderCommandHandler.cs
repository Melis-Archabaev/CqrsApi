using CqrsApi.Interfaces.ICommandHandlers;
using CqrsApi.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsApi.Handlers.CommandHandlers
{
    public class MakeOrderCommandHandler : IMakeOrderCommandHandler
    {
        public MakeOrderResponseModel MakeOrder(MakeOrderResponseModel requestModel)
        {
            var result = new MakeOrderResponseModel
            {
                IsSucces = true,
                OrderId = new Guid("9245fe4a-d402-451c-b9ed-9c1a04247482")
            };
            //Your business logic here
            return result;
        }
    }
}
