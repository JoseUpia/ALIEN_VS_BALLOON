using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float Velocidad;
    public float TiempoDestruir;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector2(-Velocidad, 0);
        Destroy(gameObject, TiempoDestruir);
    }
}
