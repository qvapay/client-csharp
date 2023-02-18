using QvaPay.Net.Clients;
using QvaPay.Net.Exceptions;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace QvaPay.Net
{
    public static class Extensions
    {
        public static void ProcessRestResponse(this RestResponse response)
        {
            if (!response.IsSuccessStatusCode || response.ErrorException != null)
            {
                var message = $"RestClient response error StatusCode: {(int)response.StatusCode} {response.StatusCode}";
                if (response.ErrorException != null)
                {
                    message += $" ErrorException: {response.ErrorException}";
                }
                var error = JsonSerializer.Deserialize<SingleError>(response.RawBytes);
                throw new HttpApiException<SingleError>(message, response.ErrorException, error);
            }
        }

        public static void ValidateModel(this HttpApiClient client, object obj)
        {
            var validationResults = new List<ValidationResult>();
            if (!Validator.TryValidateObject(obj, new ValidationContext(obj), validationResults, true))
                throw new ValidationErrorException($"Validations not passed for {obj.GetType().Name} object", validationResults);
        }
    }
}
