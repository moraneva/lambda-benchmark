var AWS = require('aws-sdk');

AWS.config.update({
    region: 'us-east-2'
});

var docClient = new AWS.DynamoDB.DocumentClient();

var table = "Test";

for (var i = 1; i < 5000; i++) {
    var params = {
        TableName: table,
        Item: {
            "Id": i + "",
            "blank": 100
        }
    };

    docClient.put(params, function(err, data) {
        if (err) {
            console.error("Unable to add item. Error JSON:", JSON.stringify(err, null, 2));
        } else {
            console.log("Added item:", JSON.stringify(data, null, 2));
        }
    });
}