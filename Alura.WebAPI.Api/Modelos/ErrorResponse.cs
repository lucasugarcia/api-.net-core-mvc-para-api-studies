using System;

namespace Alura.WebAPI.Api.Modelos
{
    public class ErrorResponse
    {
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
        public ErrorResponse InnerError { get; set; }

        internal static ErrorResponse From(Exception ex)
        {
            if(ex == null)
                return null;

            return new ErrorResponse
            {
                Codigo = ex.HResult,
                Mensagem = ex.Message,
                InnerError = ErrorResponse.From(ex.InnerException)
            };
        }
    }
}
