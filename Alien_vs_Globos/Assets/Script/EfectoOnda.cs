using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoOnda : MonoBehaviour
{
    private Rigidbody2D Rb;

    public float _Velocidad;
    public float _TiempoDestruir;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector2(0,-_Velocidad);
        Destroy(gameObject, _TiempoDestruir);
    }
}
