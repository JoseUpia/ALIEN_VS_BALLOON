using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarScenes : MonoBehaviour
{
    public string NombreEscena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  CambiarEscenario()
    {
        SceneManager.LoadScene(NombreEscena);
    }

    public void SalidDelJuego()
    {
        Application.Quit();
    }
}

