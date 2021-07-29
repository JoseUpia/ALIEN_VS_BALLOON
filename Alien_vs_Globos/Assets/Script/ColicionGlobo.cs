using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColicionGlobo : MonoBehaviour
{
    private Rigidbody2D Rb;
    public int Valor;

    void Start()
    {
      
    }
        
    void Update()
    {

    }

    public void Destruir(){
        Puntos.PuntosGet.getPuntos(Valor);
        Barra_de_Vida.barraVida.masVida();
        Destroy(gameObject);        
    }
}
