using System.Collections;
using System.Collections.Generic;
using Model.Build;
using UnityEngine;

public class World
{
    private World(List<CellCreation> cells)
    {
        
    }

    public static World Create(List<CellCreation> cells)
    {
        return new World(cells);
    }
}
