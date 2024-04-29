using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    // Variable declaration for Prefab object
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the origial prefab
        // whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to 
        if (Input.GetKeyDown(KeyCode.B))
        {
            Transform prefabPosition = GameObject.Find("Prefab Position").transform;
            Instantiate(prefab, prefabPosition.position, prefabPosition.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform spawnObject = GameObject.Find("Spawn Object").transform;
            Instantiate(prefab, spawnObject.position, spawnObject.rotation);
        }
    }
}


