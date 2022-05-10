using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public float health = 50f;

    public Animator anim;


    public int maxHealth = 100;
    public int currentHealth;


    //
    public HealthBar healthBar;
    //

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        //
        healthBar.SetMaxHealth(maxHealth);
        //
    }
    public void TakeDamage(int amount)

    {

        currentHealth -= amount;
        anim.SetTrigger("gethit");
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0f)
        {
            Die();
        }
        

    }
    void Die()
    {
        Destroy(gameObject);
        anim.SetBool("Die", true);
    }
}
