using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MovimientoNave : MonoBehaviour
{
    public float velocidad = 10f;
    //public Renderer rend;
    public SpriteRenderer Ondas;
    public Color ColorOndasSubiendo = Color.white;
    public Color ColorOndasBajando = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocidad * Time.deltaTime;
            Ondas = GetComponent<SpriteRenderer>();
            Ondas.color = ColorOndasSubiendo;
            //rend.material.color = ColorOndasSubiendo;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocidad * Time.deltaTime;
            Ondas = GetComponent<SpriteRenderer>();
            Ondas.color = ColorOndasBajando;
            //rend.material.color = ColorOndasBajando;
        }
    }
}
