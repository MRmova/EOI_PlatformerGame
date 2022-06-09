using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;//3 corazones
    public int currentHealth;
    public bool death;
    public bool damaged;

    public GameObject[] heartsUI;
    Animator anim;

    private void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("AttackEnemy"))
        {
            TakeDamage();
        }
    }
    public void TakeDamage()
    {
        if (currentHealth <= 0) return;
        //desactivo el corazón correspondiente
        heartsUI[currentHealth - 1].SetActive(false);

        damaged = true;
        //el enemigo nos quita 1 de vida
        currentHealth--;
        //HeartsUI();

        if (currentHealth <= 0) Death();
        else anim.SetTrigger("Hit");
    }

    public void DamagedToFalse()
    {
        damaged = false;
    }
    void Death()
    {
        death = true;
        anim.SetTrigger("Death");
        Destroy(gameObject,2);
    }

    public void AddHeart()
    {
        //si la salud actual es igual a la salud maxima, me salgo de la funcion ya que no puedo añadir más corazones
        if (currentHealth >= maxHealth) return;
        
        currentHealth++; //sumamos 1 de vida
        heartsUI[currentHealth].SetActive(true); //activamos el corazon correspondiente
                                              
    }

    /*
    void HeartsUI()
    {
        if (currentHealth == maxHealth) return;

        float x = currentHealth / maxHealth;
        float y = heartsUI.Length * x;

        float dec = y % 1;
        float num = (int)y;
        /*
        for (int i = 0; i < num; i++)
        {
            heartsUI[i].SetActive(true);
            if (i == num)
                heartsUI[i];
        }
       
    }*/
}
