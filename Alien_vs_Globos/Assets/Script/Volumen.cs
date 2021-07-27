using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider Controlador; 
    public float ValorDeslizador;
    public Image ImagenVolumenMute;
    public Image ImagenVolumenBajo;
    public Image ImagenVolumenMedio;
    public Image ImagenVolumenMaximo;

    // Start is called before the first frame update
    void Start()
    {
        Controlador.value = PlayerPrefs.GetFloat("VolumenAudio", 0.250f);
        AudioListener.volume = Controlador.value;
        ImagenVolumen();
    }

    public void CargarDeslizador(float valor)
    {
        ValorDeslizador = valor;
        PlayerPrefs.SetFloat("VolumenAudio", ValorDeslizador);
        AudioListener.volume = Controlador.value;
        ImagenVolumen();
    }

    public void ImagenVolumen()
    {
        if(ValorDeslizador == 0)
        {
            ImagenVolumenMute.enabled = true;
            ImagenVolumenBajo.enabled = false;
            ImagenVolumenMedio.enabled = false;
            ImagenVolumenMaximo.enabled = false;
        }
        else if(ValorDeslizador > 0 & ValorDeslizador <= 0.1666)
        {
            ImagenVolumenMute.enabled = false;
            ImagenVolumenBajo.enabled = true;
            ImagenVolumenMedio.enabled = false;
            ImagenVolumenMaximo.enabled = false;
        }
        else if(ValorDeslizador > 0.1666 & ValorDeslizador <= 0.3332)
        {
            ImagenVolumenMute.enabled = false;
            ImagenVolumenBajo.enabled = false;
            ImagenVolumenMedio.enabled = true;
            ImagenVolumenMaximo.enabled = false;
        }
        else if(ValorDeslizador > 0.3332 & ValorDeslizador <=0.5)
        {
            ImagenVolumenMute.enabled = false;
            ImagenVolumenBajo.enabled = false;
            ImagenVolumenMedio.enabled = false;
            ImagenVolumenMaximo.enabled = true;
        }
    }
}
