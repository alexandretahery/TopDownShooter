using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Bonus hit something");
    }
}
