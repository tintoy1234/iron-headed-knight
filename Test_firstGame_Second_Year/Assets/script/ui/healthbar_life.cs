using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar_life : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public GameObject canvasobject;

    public healthbar_move healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Degat_Collider"))
        {
            takedamage(1);
        }
    }
    void Update()
    {
        if (currentHealth <= 0)
        {
            canvasobject.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
        }
    }

    void takedamage(int damage)
    {
        currentHealth -= damage;
        healthbar.Sethealth(currentHealth);
    }
}
