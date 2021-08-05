using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeNubes : MonoBehaviour
{
    public GameObject Nube1, Nube2, Nube3, Nube4, Nube5, Nube6;
    public float tiempoCreacion = 10f, espacioCreacion= 10f;
    public float TiempoDestruir;

    // Start is called before the first frame update
    void Start()
    {
        AudioListener.pause = false;
        InvokeRepeating("CreandoNube1", 1f, tiempoCreacion);
        InvokeRepeating("CreandoNube2", 0.0f, tiempoCreacion);
        InvokeRepeating("CreandoNube3", 1f, tiempoCreacion);
        InvokeRepeating("CreandoNube4", 3f, tiempoCreacion);
        InvokeRepeating("CreandoNube5", 6f, tiempoCreacion);
        InvokeRepeating("CreandoNube6", 1f, tiempoCreacion);
    }

    public void CreandoNube1()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(this.transform.position.x, PosicionCreacion.y);

        GameObject ObjetoNube1 = Instantiate(Nube1, PosicionCreacion, Quaternion.identity);


        Destroy(ObjetoNube1, TiempoDestruir);
    }
    public void CreandoNube2()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(this.transform.position.x, PosicionCreacion.y);

        GameObject ObjetoNube2 = Instantiate(Nube2, PosicionCreacion, Quaternion.identity);


        Destroy(ObjetoNube2, TiempoDestruir);
    }
    public void CreandoNube3()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(this.transform.position.x, PosicionCreacion.y);

        GameObject ObjetoNube3 = Instantiate(Nube3, PosicionCreacion, Quaternion.identity);


        Destroy(ObjetoNube3, TiempoDestruir);
    }
    public void CreandoNube4()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(this.transform.position.x, PosicionCreacion.y);

        GameObject ObjetoNube4 = Instantiate(Nube4, PosicionCreacion, Quaternion.identity);


        Destroy(ObjetoNube4, TiempoDestruir);
    }
    public void CreandoNube5()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(this.transform.position.x, PosicionCreacion.y);

        GameObject ObjetoNube5 = Instantiate(Nube5, PosicionCreacion, Quaternion.identity);


        Destroy(ObjetoNube5, TiempoDestruir);
    }
    public void CreandoNube6()
    {
        Vector2 PosicionCreacion = new Vector2(0, 0);
        PosicionCreacion = this.transform.position + Random.onUnitSphere * espacioCreacion;
        PosicionCreacion = new Vector2(this.transform.position.x, PosicionCreacion.y);

        GameObject ObjetoNube6 = Instantiate(Nube6, PosicionCreacion, Quaternion.identity);


        Destroy(ObjetoNube6, TiempoDestruir);
    }
}

