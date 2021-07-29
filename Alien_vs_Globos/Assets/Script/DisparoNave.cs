using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoNave : MonoBehaviour
{
    public Transform disparo;
    public GameObject Bala;
    public float TiempoDestruccion; 
    private float LastShoot;
    Animator NaveDisparando;

    // Start is called before the first frame update
    void Start()
    {
        NaveDisparando = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > LastShoot + TiempoDestruccion)
        {
            Instantiate(Bala, disparo.position, Quaternion.identity);
             LastShoot = Time.time;
        }        
    }
}
