using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using MethodLayer.Multiplication;
using Models.Exceptions;
using Models.Models;
using Newtonsoft.Json;

namespace MethodLayer
{
    public interface IMethodOrchestrator
    {
        IResponse Invoke(object request);
    }
    public class MethodOrchestrator : IMethodOrchestrator
    {
        private readonly IMultiplicationService _multiplicationService;
        private readonly IMultiplicationRequestValidator _multiplicationRequestValidator;

        public MethodOrchestrator(IMultiplicationService multiplicationService,
            IMultiplicationRequestValidator multiplicationRequestValidator)
        {
            _multiplicationService = multiplicationService;
            _multiplicationRequestValidator = multiplicationRequestValidator;
        }
        public IResponse Invoke(object request)
        {
            Request requestModel;
            try
            {
                var jsonText = ((JsonElement) request).GetRawText();
                requestModel = JsonConvert.DeserializeObject<Request>(jsonText);
            }
            catch
            {
                return new ErrorResponse
                {
                    Jsonrpc = "2.0",
                    Error = new Error
                    {
                        Code = -32700,
                        Message = "Could not parse the request."
                    },
                    Id = null
                };
            }

            try
            {
                switch (requestModel.Method)
                {
                    case Methods.Multiply:
                        _multiplicationRequestValidator.Validate(requestModel);
                        return _multiplicationService.Multiply(requestModel);

                    default:
                        return new ErrorResponse
                        {
                            Jsonrpc = "2.0",
                            Error = new Error
                            {
                                Code = -32601,
                                Message = "Method not found."
                            },
                            Id = requestModel.Id
                        };
                }
            }
            catch (InvalidParamsException)
            {
                return new ErrorResponse
                {
                    Jsonrpc = "2.0",
                    Error = new Error
                    {
                        Code = -32602,
                        Message = "Invalid params."
                    },
                    Id = requestModel.Id
                };
            }
            catch (InvalidRequestException)
            {
                return new ErrorResponse
                {
                    Jsonrpc = "2.0",
                    Error = new Error
                    {
                        Code = -32600,
                        Message = "Invalid request."
                    },
                    Id = requestModel.Id
                };
            }
        }
    }
}
