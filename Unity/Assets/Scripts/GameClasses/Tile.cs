using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Tile
{
    
    public GameObject tileObject;
    public bool isTower;

    
    public Tile(GameObject tileObject, bool isTower) 
    {
        this.tileObject = tileObject;
        this.isTower = isTower; 
    }
}

