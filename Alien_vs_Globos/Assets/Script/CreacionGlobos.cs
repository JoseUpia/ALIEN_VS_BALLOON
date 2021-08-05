using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreacionGlobos : MonoBehaviour
{
    public GameObject GloboRojo, GloboVerde, GloboAzul, GloboAmarillo;
    public float Destruir;
    public float tiempoCreacion, espacioCreacion;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreandoGloboRojo", 0.9f, tiempoCreacion);
        InvokeRepeating("CreandoGloboVerde", 0.5f, tiempoCreacion);
        InvokeRepeating("CreandoGloboAzul", 3.0f, tiempoCreacion);
        InvokeRepeating("CreandoGloboAmarillo", 1.0f, tiempoCreacion);
    }

    public void CreandoGloboRojo()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(PosicionCreacion.x, this.transform.position.y);

        GameObject CreacionGloboRojo = Instantiate(GloboRojo, PosicionCreacion, Quaternion.identity);

        Destroy(CreacionGloboRojo, Destruir);
    }
    public void CreandoGloboVerde()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(PosicionCreacion.x, this.transform.position.y);

        GameObject CreacionGloboVerede = Instantiate(GloboVerde, PosicionCreacion, Quaternion.identity);

        Destroy(CreacionGloboVerede, Destruir);

    }
    public void CreandoGloboAzul()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(PosicionCreacion.x, this.transform.position.y);

        GameObject CreacionGloboAzul = Instantiate(GloboAzul, PosicionCreacion, Quaternion.identity);

        Destroy(CreacionGloboAzul, Destruir);
    }
    public void CreandoGloboAmarillo()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(PosicionCreacion.x, this.transform.position.y);

        GameObject CreacionGloboAmarillo = Instantiate(GloboAmarillo, PosicionCreacion, Quaternion.identity);

        Destroy(CreacionGloboAmarillo, Destruir);
    }
}
