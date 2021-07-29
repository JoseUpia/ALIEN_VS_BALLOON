using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Barra_de_Vida : MonoBehaviour
{
    public Scrollbar Barradevida;
    float vida = 1f;
    public float daño;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Barradevida.size = vida;
        vida -= daño;
        if (vida <=0)
        {
            Destroy(this.gameObject);
        }
    }
}
