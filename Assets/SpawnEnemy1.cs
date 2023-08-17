using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy1 : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObj", 10 , 10);
    }

    Vector2 GetSpawnPoint()
    {
        float x = Random.Range(-55f,55f);
        float y = Random.Range(-55f, 55f);

        return new Vector2(x,y);
    }


    void SpawnObj()
    {
        Instantiate(objectToSpawn, GetSpawnPoint(), Quaternion.identity);
    }
}
