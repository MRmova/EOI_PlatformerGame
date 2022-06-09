using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float forceAmount;
    public float torqueAmount;
    public int direction;

    Rigidbody2D rd2D;

    void Awake()
    {
        rd2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

        //Ramdon.value devuelve un valor entre 0 y 1
        if (Random.value < 0.5f) direction = 1;
        else direction = -1;

        //le añadimos fuerda de direccion hacia arriba y los lados
        rd2D.AddForce(Vector3.up * forceAmount);
        rd2D.AddForce(Vector3.right * forceAmount / 4 * direction);

        //Le añadimos fuerza de giro
        rd2D.AddTorque(torqueAmount);
    }

}
