using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFondoLevel2 : MonoBehaviour
{
    public Renderer Fondo;
    public float velocidadX;
    public float velocidadY;
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        Fondo.material.mainTextureOffset = Fondo.material.mainTextureOffset + new Vector2(velocidadX, velocidadY) * Time.deltaTime;
    }
}
