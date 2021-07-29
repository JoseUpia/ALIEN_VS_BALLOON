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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Barradevida.size = vida;
        vida -= dano;
        if (vida > 1) vida = 1;
        if (vida <=0)
        {
            Destroy(this.gameObject);
            GameOver.SetActive(true);
        }
    }

    public void masVida(){
        vida += AumentarVida;
    }
}
