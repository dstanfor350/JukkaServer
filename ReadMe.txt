                JukkaServer Solution and Project

The JukkaServer solution is the first attempt at a http listener.
This solution has been superseded by the JukkaServerV2 solution.

https://stackoverflow.com/questions/7004616/how-to-use-httplistener-to-receive-http-post-which-contain-xml

.NET: Create a basic HttpListener web service
http://www.gabescode.com/dotnet/2018/11/01/basic-HttpListener-web-service.html

Usage:
!! IMPORTANT !!
Visual Studio must be "Run as Administrator".  If run from the command line,
the command line window must "Run as Administrator".

The project is intended to be an attempt to simulate the Jukka Machine to Cloud APIs by
creating class models and methods of the Machine to Cloud APIs.

The JukkaServer project acts as a http listener and processes http request.
It listens on http://localhost:4333 for http request.
The port can be changed in the JukkaServer program.cs prefix variable located in 
the RunServer method.

Postman is used as the client.  
Postman can be downloaded from https://www.postman.com/downloads/

Postman URLs:
The Postman URLs "Jukka Machone.postman_collection.json" can be found in the Solution's 
folder ""Solution Items." This collection can be imported into Postman by using
the "File" -> "Import" menu item.

These http request are described in the Jukka Machine to Cloud API document.
Each should return a response as described in the Response Example for each API.

Login:
    http://localhost:4333/prod/api/account/login
    No actual authentication validation is actually performed.
    The payload is provided in the Postman request.
    A response body is returned as the API describes.
    The HTTP Response Code should be 200 : Success.

Order Status:
    http://localhost:4333/api/order/status
    The payload is provided in the Postman request.
    The response body is N/A
    The HTTP Response Code should be 200 : Success.

Order Item Status:
    http://localhost:4333/api/orderitem/status
    The payload is provided in the Postman request.
    The response body is N/A
    The HTTP Response Code should be 200 : Success.

Payment:
    http://localhost:4333/api/payment
    The payload is provided in the Postman request.
    The response body is N/A
    The HTTP Response Code should be 200 : Success.

Machine Status:
    http://localhost:4333/api/machine/status
    The payload is provided in the Postman request.
    The response body is N/A
    The HTTP Response Code should be 200 : Success

The Postman LoginOAuth and JukkaServerLoginOAuth are NOT supported in this version 
of the JukkaServer solution.

