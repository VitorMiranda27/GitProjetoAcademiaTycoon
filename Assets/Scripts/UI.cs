using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI HUD;
    public Image i1,i2,i3;
    // Start is called before the first frame update
    public void Barra1( float qtde)
    {
        
        i1.fillAmount = (qtde/10);
    }
    public void Barra2( float qtde)
    {
        
        i2.fillAmount = (qtde/10);
    }
    public void Barra3( float qtde)
    {
        
        i3.fillAmount = (qtde/10);
    }
    void Start()
    {
        
        HUD = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
