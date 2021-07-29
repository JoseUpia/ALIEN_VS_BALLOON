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

    public void Destruir(){
        Destroy(gameObject);
    }
    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        ColicionGlobo globo = other.collider.GetComponent<ColicionGlobo>();
        ColicionGloboAzul globoAzul = other.collider.GetComponent<ColicionGloboAzul>();

        if(globo != null) globo.Destruir();
        
        if (globoAzul != null) globoAzul.Destruir();

    }
}
