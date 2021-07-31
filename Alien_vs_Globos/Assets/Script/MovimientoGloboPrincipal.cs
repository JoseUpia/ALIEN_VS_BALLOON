using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoGloboPrincipal : MonoBehaviour
{
    public float velocidad;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * velocidad * Time.deltaTime;
    }
    
}
