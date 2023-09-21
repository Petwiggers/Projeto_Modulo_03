
using M3P_BackEnd_Squad1.Exceptions;

namespace M3P_BackEnd_Squad1.Middlewares
{
    public class ErrorsMiddleware
    {
        private readonly RequestDelegate _next;
        public ErrorsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await TratamentoExcecao(context, ex);
            }
        }

        public async Task TratamentoExcecao(HttpContext context, Exception ex)
        {
            int status;
            string message = ex.Message;

            switch (ex)
            {
                case (NotFoundException):
                    {
                        status = StatusCodes.Status404NotFound;
                        break;
                    }
                case (BadRequestException):
                    {
                        status = StatusCodes.Status400BadRequest;
                        break;
                    }
                case (ConflictException):
                    {
                        status = StatusCodes.Status409Conflict;
                        break;
                    }
                case (ArgumentException):
                    {
                        status = StatusCodes.Status406NotAcceptable;
                        break;
                    }

                default:
                    {
                        status = StatusCodes.Status500InternalServerError;
                        message = "An error occurred, try again later !";
                        break;
                    }


            }
            context.Response.StatusCode = status;
            await context.Response.WriteAsync(message);
        }
    }
}
