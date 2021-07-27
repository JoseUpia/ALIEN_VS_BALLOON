using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNube : MonoBehaviour
{
    public float velocidad = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * velocidad * Time.deltaTime;
    }
}
