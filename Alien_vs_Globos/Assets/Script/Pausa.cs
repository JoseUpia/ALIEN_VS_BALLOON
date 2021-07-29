using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    bool pausa = false;

    public void pausarJuego()
    {
        Time.timeScale = 0;
    }
    public void reanudarJuego()
    {
        Time.timeScale = 1;
    }
}
