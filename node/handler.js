'use strict';

var AWS = require('aws-sdk');

AWS.config.update({
    region: 'us-east-2'
});

var docClient = new AWS.DynamoDB.DocumentClient();

module.exports.hello = (event, context, callback) => {

    var params = {
        TableName: "Test"
    };

    docClient.scan(params).promise().then((data) => {

        callback(null, { message: 'Go Serverless v1.0! Your function executed successfully!', event });
    }, (err) => {
        console.error(err);
    });

    // Use this code if you don't use the http event with the LAMBDA-PROXY integration
    // callback(null, { message: 'Go Serverless v1.0! Your function executed successfully!', event });
};