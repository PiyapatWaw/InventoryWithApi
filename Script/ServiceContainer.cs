using Networking;
using UnityEngine;

namespace App
{

    public class ServiceContainer : MonoBehaviour
    {
        public static ServiceContainer Singleton;
        public APIService APIService;
        public bool Ready { get;private set; }

        private void Awake()
        {
            if (Singleton == null)
                Singleton = this;
            else
                Destroy(this.gameObject);
            DontDestroyOnLoad(this.gameObject);
        }

        private void Start()
        {
            APIService = new APIService("https://6627b4c3b625bf088c096825.mockapi.io/api/");
            Ready = true;
        }
    }
}
