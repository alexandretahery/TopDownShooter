using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class HealthModel
{
    private float health;
    private EnumStatus enumStatus;

    /// <summary>
    /// Property Set or Get in percentage Health
    /// </summary>
    public float Health { get { return (float)health; } set { health = value; } }

    /// <summary>
    /// Property Set or Get EnumStatus
    /// </summary>
    public EnumStatus EnumStatus { get { return enumStatus; } set { enumStatus = value; } }
    /// <summary>
    /// CTOR for health system
    /// </summary>
    /// <param name="health">Give health into range between 0 to 100</param>
    /// <param name="enumStatus">Give health status</param>
    public HealthModel(float health, EnumStatus enumStatus)
    {
        if (health < 0)
        this.health = 0;
        else if (health >= 1)
            this.health = 1;
        this.enumStatus = EnumStatus.Normal;
    }
}
