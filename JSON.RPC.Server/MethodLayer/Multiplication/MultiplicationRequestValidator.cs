using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Exceptions;
using Models.Models;

namespace MethodLayer.Multiplication
{
    public interface IMultiplicationRequestValidator
    {
        void Validate(Request request);
    }
    public class MultiplicationRequestValidator : IMultiplicationRequestValidator
    {
        public void Validate(Request request)
        {
            if (request.Id <= 0)
                throw new InvalidRequestException();
            try
            {
                foreach (var parameter in request.Params)
                {
                    var value = Convert.ToDouble(parameter);
                }
            }
            catch (Exception e)
            {
                throw new InvalidParamsException(e.Message);
            }
        }
    }
}
