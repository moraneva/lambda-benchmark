using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

namespace DotNetLambdaBenchmark.Tests
{
    public class FunctionTest
    {
        [Fact]
        public async void TestDynamoScanFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            var count = await function.FunctionHandler("hello world", context);

            Assert.Equal(1, count);
        }
    }
}
