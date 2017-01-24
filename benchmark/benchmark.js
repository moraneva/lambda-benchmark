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

apiBenchmark.compare(services, routes, { minSamples: 100 }, (err, results) => {

    apiBenchmark.getHtml(results, (error, html) => {

        fs.writeFile("results1.html", html, (err) => {
            console.log('Written to file');
        });
        // now save it yourself to a file and enjoy 
    });
});

services = {
	server1: "https://v03codwpc3.execute-api.us-east-2.amazonaws.com/"
};

routes = {
	route1:{
		method: 'get',
		route: 'Prod'
	}
}

apiBenchmark.compare(services, routes, { minSamples: 100 }, (err, results) => {

    apiBenchmark.getHtml(results, (error, html) => {

        fs.writeFile("results2.html", html, (err) => {
            console.log('Written to file');
        });
        // now save it yourself to a file and enjoy 
    });
});
