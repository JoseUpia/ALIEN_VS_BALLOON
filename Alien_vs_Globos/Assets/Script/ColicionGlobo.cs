using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionGlobo : MonoBehaviour
{
    private Rigidbody2D Rb;
    public int Valor;
    Animator AnimacionGlobos;

    void Start()
    {
      
        AnimacionGlobos = GetComponent<Animator>();   
    }
        
    void Update()
    {

    }

    public void Destruir(){
        Puntos.PuntosGet.getPuntos(Valor);
        Barra_de_Vida.barraVida.masVida();       
        AnimacionGlobos.SetBool("Explotar", true);   
        Destroy(gameObject, 1);
        
    }
}
