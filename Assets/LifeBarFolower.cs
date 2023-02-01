using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBarFolower : MonoBehaviour
{
    [SerializeField]
    private Transform trPlayer;

    [SerializeField]
    private Vector3 Offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = trPlayer.position - Offset;
    }
}