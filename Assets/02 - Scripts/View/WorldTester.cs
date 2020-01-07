using Model;
using UnityEngine;
using Zenject;

namespace View
{
    [ExecuteInEditMode]
    public class WorldTester : MonoBehaviour
    {
        private World _world;

        [Inject] private LevelLoader _levelLoader;

        [SerializeField] private string _levelPath;

        private void Start()
        {
            var worldView = GetComponent<WorldView>();
            if (worldView == null)
            {
                Debug.LogError("Cannot find WorldView component.");
                return;
            }

            _world = worldView.GetWorld();
        }
        
        public void Reload()
        {
            if (_levelPath.Length > 0)
            {
                CreateWorld(_levelPath);
            }
        }

        private void CreateWorld(string levelName)
        {
            _world = World.Create(_levelLoader.Load(levelName));
        }
    }
}