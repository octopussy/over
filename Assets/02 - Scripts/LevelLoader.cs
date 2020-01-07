using Model.Level;
using UnityEngine;

public class LevelLoader
{
    public Level Load(string levelName)
    {
        var levelPath = $"Assets/Resources/Levels/{levelName}.json";
        var level = Level.Load(levelPath);
        if (level == null)
        {
            Debug.LogError($"Cannot load level '{levelName}'");
        }

        return level;
    }
}