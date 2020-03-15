using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script that spawns any object to specific position. In this case only used for the yellow coin
public class ObjectSpawner : MonoBehaviour
{
    public GameObject ObjectoToSpawn;
    public void SpawnObject()
    {
        var Position = new Vector3(0.0f, 1.24f, 1.63f);
        Instantiate(ObjectoToSpawn, Position, Quaternion.identity);

    }

}
