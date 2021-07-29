using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoNave : MonoBehaviour
{
    public Transform disparo;
    public GameObject Bala;

    private float LastShoot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > LastShoot + 0.75f)
        {
            Instantiate(Bala, disparo.position, Quaternion.identity);
             LastShoot = Time.time;
        }        
    }
}
