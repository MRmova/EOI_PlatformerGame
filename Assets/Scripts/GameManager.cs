using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TextCoinUI; //El texto que esta en la interfaz para mostrar las monedas
    public int numCoins; //El nº de monedas que lleva el player

    #region Singleton
    //Creacion del singleton, es decir, la clase gamemanager solo va a tener un instancia
    public static GameManager gameManager;
    public void Awake()
    {
        gameManager = this;
    }
    #endregion

    public void AddCoinds()
    {
        numCoins++;
        TextCoinUI.text = "" + numCoins;
    }
}
