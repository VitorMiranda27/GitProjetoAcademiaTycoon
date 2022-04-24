using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Status : MonoBehaviour
{
    GameObject[] game,game1,game2;
    public static float cont1, cont2, cont3, cont_Total;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        game = GameObject.FindGameObjectsWithTag("tipo1");
        cont1 = game.Length;
         
        game1 = GameObject.FindGameObjectsWithTag("tipo2");
        cont2 = game1.Length;
        
        game2 = GameObject.FindGameObjectsWithTag("tipo3");
        cont3 = game2.Length;


        UI.HUD.Barra1(cont1); 
        UI.HUD.Barra2(cont2);
        UI.HUD.Barra3(cont3);
    }
}
