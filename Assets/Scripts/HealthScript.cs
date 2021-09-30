using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public int MaxHealth = 100;
    public int CurrentHealth;

    public HealthBar health;

    public int AdioSource;

    //A range of audio sources
    public AudioSource hurt1;
    public AudioSource hurt2;
    public AudioSource hurt3;
    public AudioSource heal;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        health.SetMaxHealth(MaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(CurrentHealth == 0)
            {
                Debug.Log("Game over Cheif");
            }
            else
            {//This plays random audio depending on the number generated
                TakeDamage(5);
                if (AdioSource == 1)
                {
                    hurt1.Play();
                }
                else
                {
                    if (AdioSource == 2)
                    {
                        hurt2.Play();
                    }
                    else
                    {
                        hurt3.Play();
                    }
                }
            }            
           
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(CurrentHealth == 100)
            {
                Debug.Log("You're Fully Healed");
            }
            else
            {
                Heal(5);
                heal.Play();
            }
            
        }

    }

    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        health.SetHealth(CurrentHealth);
        RandomNum();
    }

    void Heal(int heal)
    {
        CurrentHealth += heal;
        health.SetHealth(CurrentHealth);
    }

    void RandomNum()
    {
        AdioSource = Random.Range(1, 4);
    }
}
