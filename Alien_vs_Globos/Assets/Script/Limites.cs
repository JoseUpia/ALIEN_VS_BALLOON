using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    private Transform theTransform;
    public Vector2 H_rango = Vector2.zero;
    public Vector2 V_rango = Vector2.zero;
    
    void LateUpdate()
    {
        theTransform.position = new Vector3(
            Mathf.Clamp(transform.position.x, V_rango.x, V_rango.y),
            Mathf.Clamp(transform.position.y, H_rango.x, H_rango.y),
            transform.position.z
        );
    }

    // Start is called before the first frame update
    void Start()
    {
        theTransform = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
