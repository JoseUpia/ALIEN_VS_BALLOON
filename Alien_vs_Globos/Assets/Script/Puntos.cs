using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
   
    private Text m_MyText;
    public int punto = 0;
    public static Puntos PuntosGet;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        PuntosGet = this;
    }
        
    void Start()
    {
        m_MyText = GetComponent<Text>();
        //Text sets your text to say this message
        m_MyText.text = punto + "";
    }
        
    void Update()
    {
        if(m_MyText != null){
            m_MyText.text = punto.ToString();
        }
    }

    public void SetPuntos(int num){
        punto += num;
    }

    public int GetPuntos(){
        return punto;
    }


}
