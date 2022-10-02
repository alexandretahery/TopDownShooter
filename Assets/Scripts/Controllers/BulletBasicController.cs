using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class BulletBasicController : MonoBehaviour, IProjectileController
{
    public float DamagePoint;

    [SerializeField]
    private float lifeTime;
    [SerializeField]
    private float moveSpeed;
    private Vector3 _shootDir;

    public void Setup(Vector3 positionInput)
    {
        transform.position = positionInput;
        _shootDir = (transform.rotation * Vector3.up).normalized;
    }

    public void Damage()
    {
        Debug.Log("HIT");
    }

    public void MoveProjectile()
    {
        transform.position += _shootDir * moveSpeed * Time.deltaTime;
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damage();
        Destroy(gameObject);
    }


    private void FixedUpdate()
    {
        MoveProjectile();
    }

}
