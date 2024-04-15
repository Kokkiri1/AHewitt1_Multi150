using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCounter : MonoBehaviour
{
    private int colliderCount = 0;

    void OnTriggerEnter(Collider other)
    {
        colliderCount++;
    }

    void OnTriggerExit(Collider other)
    {
        colliderCount--;
    }

    public int GetColliderCount()
    {
        return colliderCount;
    }
}
