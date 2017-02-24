namespace HttpServerApplication
{
    using System.Collections.Generic;
    using CustomHttpServer;
    using CustomHttpServer.Models;

    public class Startup
    {
        public static void Main()
        {
            var server = new HttpServer(8081, new List<Route>());
            server.Listen();
        }
    }
}
