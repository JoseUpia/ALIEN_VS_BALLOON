using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puntos : MonoBehaviour
{
   private Text m_MyText;
   private int punto = 0;
        
    void Start()
    {
        m_MyText = GetComponent<Text>();
        //Text sets your text to say this message
        m_MyText.text = punto + "";
    }
        
    void Update()
    {
        m_MyText.text = punto + "";
    }

    public void getPuntos(int num){
        punto += num;
    }
}
