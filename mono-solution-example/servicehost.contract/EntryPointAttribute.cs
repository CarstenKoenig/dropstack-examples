using System;

namespace servicehost.contract
{
    public enum HttpMethods { 
        Get,
        Post,
        Put,
        Delete
    }

    public enum InputSources { 
        Payload,
        Querystring,
        None
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class EntryPointAttribute : Attribute {
        public HttpMethods HttpMethod { get; }
        public string HttpRoute { get; }
        public InputSources InputSource { get; }

        public EntryPointAttribute(HttpMethods httpMethod, string httpRoute, InputSources inputSource) {
            HttpMethod = httpMethod;
            HttpRoute = httpRoute;
            InputSource = inputSource;
        }
    }
}