using System.Collections.Generic;
using Model.Build;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLevel", menuName = "Overlord/Create Level", order = 0)]
public class Level : ScriptableObject
{
    [SerializeField] private List<CellCreation> _cells;
}