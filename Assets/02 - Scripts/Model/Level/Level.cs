using System;
using System.IO;
using UnityEngine;

namespace Model.Level
{
    public class Level
    {
        private Level()
        {
        }

        public static Level Load(string path)
        {
            using (var reader = new StreamReader(path))
            {
                var data = reader.ReadToEnd();
                var lvl = JsonUtility.FromJson<Level>(data);
                Debug.LogError(data);
                Debug.LogError(lvl);
                return lvl;
            }
        }
    }
}