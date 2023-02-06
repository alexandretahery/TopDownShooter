using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBarFolower : MonoBehaviour
{
    [SerializeField]
    private Transform trPlayer;

    [SerializeField]
    private Vector3 Offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = trPlayer.position - Offset;
    }
}
