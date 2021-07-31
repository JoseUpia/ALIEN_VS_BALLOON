using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Barra_de_Vida : MonoBehaviour
{
    public Scrollbar Barradevida;
    float vida = 1f;
    public float AumentarVida; 
    public float dano;
    public GameObject GameOver;

    public static Barra_de_Vida barraVida;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        barraVida = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        Barradevida.size = vida;
        vida -= dano;
        if (Time.timeScale == 0)
        {
            vida += dano;
        }
        else if (vida > 1) 
        {
            vida = 1;
        }
        else if (vida <=0)
        {
            GameOver.SetActive(true);
            //Time.timeScale = 0;
        }
    }

    public void masVida(){
        vida += AumentarVida;
    }
    public float CantidadVida()
    {
        return vida;
    }
}
