using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionGlobo : MonoBehaviour
{
    private Rigidbody2D Rb;
    public int Valor;
    Animator AnimacionGlobos;
    public AudioSource ControlSonido;

    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        AnimacionGlobos = GetComponent<Animator>();   
        ControlSonido = GetComponent<AudioSource>();
    }
        
    void Update()
    {

    }

    public void Destruir(){
        //Rb.bodyType = RigidbodyType2D.Static;
        Puntos.PuntosGet.SetPuntos(Valor);
        Barra_de_Vida.barraVida.masVida();       
        AnimacionGlobos.SetBool("Explotar", true);            
        Destroy(gameObject, 1);
        ControlSonido.Play();
    }
}
