using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeNubes : MonoBehaviour
{
    public GameObject Nubes;
    public float tiempoCreacion = 7f, espacioCreacion = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creando", 0.0f, tiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Creando()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(this.transform.position.x, PosicionCreacion.y);

        GameObject Nube = Instantiate(Nubes, PosicionCreacion, Quaternion.identity);


        Destroy(Nube, 20f);
    }
}

