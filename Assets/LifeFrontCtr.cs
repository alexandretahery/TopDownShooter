using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeFrontCtr : MonoBehaviour
{

    /// <summary>
    /// References the image that represents the player's life.
    /// </summary>
    [SerializeField]
    private Image LifeFill;

    /// <summary>
    /// Function that allows to update the player front
    /// </summary>
    /// <param name="updateValue">Positive or negative value</param>
    public void UpdateValueLifeFill(float updateValue)
    {
        LifeFill.fillAmount += updateValue;
    }

}
