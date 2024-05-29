using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App
{
    public class ImageDataBase : MonoBehaviour
    {
        [SerializeField] private List<Sprite> Sprites = new List<Sprite>();
        private Dictionary<string, Sprite> spriteDic;

        public void Start()
        {
            spriteDic = new Dictionary<string, Sprite>();
            foreach (var sprite in Sprites)
            {
                spriteDic.Add(sprite.name,sprite);
            }
        }

        public Sprite GetSprite(string key)
        {
            return spriteDic.GetValueOrDefault(key);
        }
    }
}


