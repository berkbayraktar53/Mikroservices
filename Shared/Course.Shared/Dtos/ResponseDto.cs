using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Course.Shared.Dtos
{
    public class ResponseDto<T>
    {
        public T Data { get; private set; }

        [JsonIgnore] //Bu property'nin response'nin içinde olmasına gerek yok anlamına geliyor
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSucessFul { get; private set; }
        public List<string> Errors { get; set; }

        public static ResponseDto<T> Success(T data, int statusCode)
        {
            return new ResponseDto<T> { Data = data, StatusCode = statusCode, IsSucessFul = true };
        }

        public static ResponseDto<T> Success(int statusCode)
        {
            return new ResponseDto<T> { Data = default(T), StatusCode = statusCode, IsSucessFul = true };
        }

        public static ResponseDto<T> Fail(List<string> errors, int statusCode)
        {
            return new ResponseDto<T> { Errors = errors, StatusCode = statusCode, IsSucessFul = false };
        }

        public static ResponseDto<T> Fail(string error, int statusCode)
        {
            return new ResponseDto<T> { Errors = new List<string>() { error }, StatusCode = statusCode, IsSucessFul = false };
        }
    }
}