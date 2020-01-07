using UnityEngine;

public class WorldTester : MonoBehaviour
{
    private World _world;

    [SerializeField] private Level _level;

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
}