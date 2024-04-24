using App.Data;
using App.Utility;
using Cysharp.Threading.Tasks;
using Networking.Data;

namespace Networking
{

    public class APIService
    {
        private Networking client;

        public APIService(string baseUrl)
        {
            client = new Networking(baseUrl);
        }

        public async UniTask<InventoryData> GetInventoryAsync()
        {
            var response = await client.GetRequest(new GetInventoryRequest());
            string json = response.Data;
            return InventoryDataExtensions.DeSerialize(json);
        }
    }
}
