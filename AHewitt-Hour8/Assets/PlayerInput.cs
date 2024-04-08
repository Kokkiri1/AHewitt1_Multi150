using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    float mxVal;
    float myVal;

    void Start()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if (hVal != 0)
        {
            print("Horizontal movement selected: " + hVal);
            if (vVal != 0)
            {
                print("Vertical movement selected: " + vVal);
            }
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            print("The 'M' key is pressed down");
            if (Input.GetKeyDown(KeyCode.O))
            {
                print("The 'o' key was pressed");
            }
        }

        if (mxVal != 0)
            print("Mouse X movement selected: " + mxVal);
        if (myVal != 0)
            print("Mouse Y movement selected: " + myVal);
    }
}
