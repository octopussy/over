using Model;
using UnityEngine;

namespace View
{
    public class WorldView : MonoBehaviour
    {
        private World _world;

        public World GetWorld() => _world;
    }
}