using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon;
using Amazon.Lambda.Serialization;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace DotNetLambdaBenchmark
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<int> FunctionHandler(string input, ILambdaContext context)
        {
            AmazonDynamoDBClient dbClient = new AmazonDynamoDBClient(RegionEndpoint.USEast2);
            var request = new ScanRequest
            {
                TableName = "Test"
            };
            var response = await dbClient.ScanAsync(request);

            return response.Count;
        }
    }
}
