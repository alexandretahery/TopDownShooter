using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class BulletBasicController : MonoBehaviour, IProjectileController
{
    private float lifeTime = 1f;
    private float MoveSpeed = 50f;
    private Vector3 _shootDir;

    public void Setup(Vector3 positionInput)
    {
        transform.position = positionInput;
        _shootDir = (transform.rotation * Vector3.up).normalized;
    }

    public void Damage()
    {
        throw new NotImplementedException();
    }

    public void MoveProjectile()
    {
        transform.position += _shootDir * MoveSpeed * Time.deltaTime;
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        MoveProjectile();
    }


}
