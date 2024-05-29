using Cysharp.Threading.Tasks;
using Networking.Data;
using UnityEngine.Networking;

namespace Networking
{
    public class Networking
    {
        private string baseUrl;

        public Networking(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }


        public async UniTask<Response> GetRequest(Request request)
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get(baseUrl + request.Path))
            {
                var response = await webRequest.SendWebRequest();

                if(response.result == UnityWebRequest.Result.Success)
                {
                    string json = response.downloadHandler.text;
                    return new Response(json);
                }

                return new Response(response.downloadHandler.text,false ,response.error);
            }

        }
    }
}
