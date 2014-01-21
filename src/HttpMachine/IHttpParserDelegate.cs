using System;
using System.Threading.Tasks;

namespace HttpMachine
{
    public interface IHttpParserDelegate
    {
        Task OnMessageBegin(HttpParser parser);
        Task OnMethod(HttpParser parser, string method);
        Task OnRequestUri(HttpParser parser, string requestUri);
        Task OnPath(HttpParser parser, string path);
        Task OnFragment(HttpParser parser, string fragment);
        Task OnQueryString(HttpParser parser, string queryString);
        Task OnHeaderName(HttpParser parser, string name);
        Task OnHeaderValue(HttpParser parser, string value);
        Task OnHeadersEnd(HttpParser parser);
        Task OnBody(HttpParser parser, ArraySegment<byte> data);
        Task OnMessageEnd(HttpParser parser);
		Task OnError(HttpParser parser, int position, byte data);
    }
}
