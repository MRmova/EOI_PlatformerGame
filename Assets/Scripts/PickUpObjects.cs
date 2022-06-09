using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{
    PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = GetComponentInParent<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Si se tocan");
        if (collision.CompareTag("Coin"))
        {
            //Ejecutamos la funcion del gamemanager porque el player acaba de coger una moneda
            //y destruimos la moneda
            GameManager.gameManager.AddCoinds();
            Destroy(collision.gameObject);
            Debug.Log("+1 a las monedas");
        }
        else if (collision.CompareTag("Heart"))
        {
            playerHealth.AddHeart();
            Destroy(collision.gameObject);
            Debug.Log("Alto corazon");
        }
    }
}
