using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AirFlight2.Dto.Dtos
{
    public class ResponceDto<T>
    {

        public T Data { get; set; }

        public string Error { get; set; }

        public List<string> Errors { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public static ResponceDto<T> Success(int statusCode, T data)
        {
            return new ResponceDto<T> { Data = data, StatusCode = statusCode };
        }

        public static ResponceDto<T> Success(int statusCode)
        {
            return new ResponceDto<T> { StatusCode = statusCode };
        }

        public static ResponceDto<T> Fail(int statusCode, string error)
        {
            return new ResponceDto<T> { StatusCode = statusCode, Error = error };

        }

        public static ResponceDto<T> Fail(int statusCode, List<string> errors)
        {
            return new ResponceDto<T> { StatusCode = statusCode, Errors = errors };

        }
    }
}
