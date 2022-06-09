using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [Header ("Distancias")]
    public float distanceX;
    //Como de lejos esta el fondo, valores mas bajos, se mueve mas lento, parece mas lejos
    public float smmothingX;

    Transform cam;
    Vector3 previusCamPos;

    private void Awake()
    {
        cam = Camera.main.transform;
        previusCamPos = cam.position;
    }

    private void Update()
    {
        if (distanceX !=0)
        {
            float parrallaxX = (previusCamPos.x - cam.position.x) * distanceX;
            //Calcular la posicion a la que quiero mover el fondo
            Vector3 backGroundTargetPosX = new Vector3(transform.position.x + parrallaxX,
                transform.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, backGroundTargetPosX, smmothingX * Time.deltaTime);
            previusCamPos = cam.position;
        }
    }
}
