using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionGloboAzul : MonoBehaviour
{
    private Rigidbody2D Rb;
    Animator AnimacionGlobos;

    // Start is called before the first frame update
    void Start()
    {
        AnimacionGlobos = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destruir(){
        AnimacionGlobos.SetBool("Explotar", true);  
        Destroy(gameObject, 1);
    }
}
