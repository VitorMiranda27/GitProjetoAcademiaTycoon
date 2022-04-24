using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCamera : MonoBehaviour
{
    public float contl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotx = Input.GetAxis("Vertical") * contl * Time.deltaTime;
        float rotz = Input.GetAxis("Horizontal") * contl * Time.deltaTime * (5);
        transform.Rotate(0, rotz, 0);
        transform.Translate(0, 0, rotx);
    }
}
