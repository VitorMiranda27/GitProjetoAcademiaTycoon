using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public Scriptable [] listaSO = new Scriptable[5];
    public Scriptable infos;
    public int indexSO,indexMat;
    public Material [] material = new Material[2]; 
    public int Prest_Musc,Prest_BE,Prest_Atlet;

    public int criterio1,criterio2,criterio3;
    // Start is called before the first frame update
    void Awake()
    {
        indexSO = Random.Range(0,listaSO.Length-1);
        indexMat = Random.Range(0,1);

    }
    void Start()
    {      
          
        infos = listaSO[indexSO];

        criterio1 = infos.crit1;
        criterio2 = infos.crit2;
        criterio3 = infos.crit3;

        StartCoroutine(TrocaMaterial());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Prest_Musc = (int)Status.cont1;
        Prest_BE = (int)Status.cont2;
        Prest_Atlet = (int)Status.cont3;
    
    }

    IEnumerator TrocaMaterial()
    {
        yield return new WaitForSecondsRealtime(5);
        if( Prest_Musc >= criterio1 && Prest_BE >= criterio2 && Prest_Atlet >= criterio3)
        {
            GetComponent<Renderer>().material = material[0];
            Money.AttDinheiro(80);
            yield return new WaitForSecondsRealtime(3);
            Destroy(gameObject);
        }
        else
        {
            GetComponent<Renderer>().material = material[1];
            Money.AttDinheiro(20);
            yield return new WaitForSecondsRealtime(3);
            Destroy(gameObject);
        }
    }

}
