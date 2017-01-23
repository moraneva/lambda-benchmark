var apiBenchmark = require('api-benchmark');
var fs = require('fs');

var services = {
    server1: "https://jdbt7fk7u1.execute-api.us-east-2.amazonaws.com/dev/"
};

var routes = {
    route1: {
        method: 'get',
        route: 'test'
    }
};

apiBenchmark.measure(services, routes, { minSamples: 100 }, (err, results) => {

    apiBenchmark.getHtml(results, (error, html) => {

        fs.writeFile("results.html", html, (err) => {
            console.log('Written to file');
        });
        // now save it yourself to a file and enjoy 
    });
});