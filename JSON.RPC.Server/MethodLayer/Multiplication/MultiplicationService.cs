using System;
using System.Collections.Generic;
using System.Text;
using Models.Models;

namespace MethodLayer.Multiplication
{
    public interface IMultiplicationService
    {
        IResponse Multiply(Request request);
    }
    public class MultiplicationService : IMultiplicationService
    {
        public IResponse Multiply(Request request)
        {
            double result = 1;
            foreach (var parameter in request.Params)
            {
                result *= Convert.ToDouble(parameter);
            }

            return new ResultResponse
            {
                Id = request.Id,
                Jsonrpc = request.JsonRpc,
                Result = result
            };
        }
    }
}
