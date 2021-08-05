using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambiarNivel : MonoBehaviour
{
    public GameObject PanelPresentacion;
    float TiempoDeCambio = 4f;
    int TiempoReal;
    

    // Update is called once per frame
    void Update()
    {
        SiguienteNivel();
        Ganar();
    }
    public void SiguienteNivel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1 & Puntos.PuntosGet.GetPuntos() >= 500)
        {
            TiempoDeCambio -= Time.deltaTime;
            TiempoReal = (int)TiempoDeCambio;
            AudioListener.pause = true;
            PanelPresentacion.SetActive(true);
            if(TiempoReal == 0)
            {
                SceneManager.LoadScene(2);
                
            }
        }
    }

    public void Ganar()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 & Puntos.PuntosGet.GetPuntos() >= 500)
        {
            PanelPresentacion.SetActive(true);
            AudioListener.pause = true;
        }
    }

}
