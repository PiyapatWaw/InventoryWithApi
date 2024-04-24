namespace Networking.Data
{
    public class Response
    {
        public string Data { get; }
        public string Error { get; }
        public bool Success;

        public Response(string data,bool success = true,string error = null)
        {
            Data = data;
            Error = error;
            Success = success;
        }

    }
}
