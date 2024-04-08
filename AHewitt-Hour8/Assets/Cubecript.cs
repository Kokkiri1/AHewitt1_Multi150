using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubecript : MonoBehaviour
{

    void Start()
    {
        transform.Translate(0.05f, 0f, 0f);
        transform.Rotate(0f, 0f, 1f);
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }

    void Update()
    {
        // Update your cube here!
    }
}
