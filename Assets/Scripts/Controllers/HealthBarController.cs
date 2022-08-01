using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    [Range(0f, 1f)]
    public float health = 1f;
    private Image HealthPicture;
    // Start is called before the first frame update
    void Start()
    {
        var HealthBar = transform.Find("HealthBarImage");
        HealthPicture = HealthBar.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthPicture.fillAmount = health;
    }

    public void OnDamage(float value)
    {
        health -= value;
        if (health <= 0f)
            health = 0;
    }

    public void OnHealth(float value)
    {
        health += value;
        if (health >= 1f)
            health = 1;
    }
}
