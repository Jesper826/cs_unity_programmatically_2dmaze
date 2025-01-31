using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public GameObject obj;
    public Player(GameObject obj)
    {
        this.obj = obj;
    }

    bool CanMoveTo(Vector3 newPos, Tile[][] path)
    {
        for (int i = 0; i < path.Length; i++)
        {
            for (int i2 = 0; i2 < path[i].Length; i2++)
            {
                Tile currentTile = path[i][i2]; 

              
                if (currentTile.isTower && currentTile.tileObject.transform.position == newPos)
                {
                    return false; 
                }
            }
        }
        return true;
    }

    public void Move(Vector3 newPos, Tile[][] path)
    {
        Debug.Log("======move");
        if (CanMoveTo(newPos, path))
        {
            Debug.Log("======CanMoveTo");
            obj.transform.position = newPos; 
        }
    }

    public void DoMove(Tile[][] path)
    {
        Vector3 newPos = obj.transform.position;

      
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            newPos.z += 2; 
            obj.transform.rotation = Quaternion.Euler(0, 0, 0); 
        }
        else if (Input.GetKeyDown(KeyCode.S)) 
        {
            newPos.z -= 2; 
            obj.transform.rotation = Quaternion.Euler(0, 180, 0); 
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            newPos.x -= 2; 
            obj.transform.rotation = Quaternion.Euler(0, 270, 0); 
        }
        else if (Input.GetKeyDown(KeyCode.D)) 
        {
            newPos.x += 2;
            obj.transform.rotation = Quaternion.Euler(0, 90, 0); 
        }

        Move(newPos, path);
    }
}
