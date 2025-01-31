for (int i = 0; i < path.Length; i++)
{
    path[i] = new Tile[w];
    for (int i2 = 0; i2 < path[i].Length; i2++)
    {
        GameObject tileObj = tileModel;
        bool isTower = false;

        
        if (i == 0 || i == h - 1 || i2 == 0 || i2 == w - 1)
        {
            tileObj = towerModel;
            isTower = true;
        }
        else if (UnityEngine.Random.Range(0, 10) < 2) 
        {
            tileObj = towerModel;
            isTower = true;
        }

        GameObject instance = MonoBehaviour.Instantiate(tileObj, new Vector3(i2 * 2, 0, i * 2), Quaternion.identity);
        path[i][i2] = new Tile(instance, isTower); 
    }
}
