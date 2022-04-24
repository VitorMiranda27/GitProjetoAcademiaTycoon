using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] person;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timeSpawn());
    }
    
    
    // Update is called once per frame
    IEnumerator timeSpawn ()
    {
        while(true)
        {
            int n = UnityEngine.Random.Range(0, person.Length);
            yield return new WaitForSecondsRealtime(12);
            Instantiate(person[n],this.transform.position,Quaternion.identity);
        
        }
    }

}
