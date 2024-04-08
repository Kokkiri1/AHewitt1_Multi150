using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // TakeDamageFromFireball()
    public void TakeDamageFromFireball()
    {
        int x = 10;
        print("Player health: " + x);
    }

    // TakeDamageFromFireball(int damage)
    public void TakeDamageFromFireball(int damage)
    {
        int y = damage;
        print("Player health: " + y);
    }

    // TakeDamageFromFireball(int baseDamage, int multiplier)
    public void TakeDamageFromFireball(int baseDamage, int multiplier)
    {
        int z = baseDamage + baseDamage * multiplier;
        print("Player health: " + z);
    }
}
