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

    /// <summary>
    /// When Some projectile hit something call this for apply damage
    /// </summary>
    /// <returns>return Damage of the projectil</returns>
    public float Damage()
    {
        Debug.Log("HIT");
        return -DamagePoint;
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
