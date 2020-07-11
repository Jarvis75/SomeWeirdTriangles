using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            ChangeHealth(-0.1f);
        }
        healthBar.fillAmount = health;
    }

    public void ChangeHealth(float amount)
    {
        if (health > 0)
        {
            health += amount;
        }
    }
}
