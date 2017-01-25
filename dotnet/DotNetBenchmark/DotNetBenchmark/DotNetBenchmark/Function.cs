using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Amazon;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace DotNetBenchmark
{
    public class Functions
    {
        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public Functions()
        {
        }


        /// <summary>
        /// A Lambda function to respond to HTTP Get methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The list of blogs</returns>
        public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
        {
            return  new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "Hello",
                Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
            };
        }
    }
}
