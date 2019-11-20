using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthShader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float val = Mathf.PingPong(Time.time, 0.8f);
        GetComponent<Renderer>().material.SetFloat("_TexValue", val);
    }
}
