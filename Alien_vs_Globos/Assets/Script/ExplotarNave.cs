using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplotarNave : MonoBehaviour
{
    Animator NaveExplotando;
    public static ExplotarNave explotarNave;
    public AudioSource ControlSonido;
    public AudioClip SonidoExplosion;

    void Awake()
    {
        explotarNave = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        NaveExplotando = GetComponent<Animator>();
        //ControlSonido.PlayOneShot(SonidoExplosion);
    }

    // Update is called once per frame
    void Update()
    {

        if(Barra_de_Vida.barraVida.CantidadVida() <= 0.0f)
        {
            Explotar();
        }
    }
    public void Explotar()
    {

        NaveExplotando.SetBool("Explotar", true);
        Destroy(gameObject, 1);
        ControlSonido.PlayOneShot(SonidoExplosion);
    }
}
