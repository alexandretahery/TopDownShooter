using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public interface IProjectileController
{
    void Setup(Vector3 positionInput);
    void MoveProjectile();
    float Damage();
}
