using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRevolve : MonoBehaviour
{
    [SerializeField] GameObject earth;

    float speed = 1f;
    float radius = 5f;

    Vector3 centre;
    float angle;
    
    void Start()
    {
        centre = earth.transform.position;
    }

    void Update()
    {
        angle += speed * Time.deltaTime;
        var offset = new Vector3(Mathf.Sin(angle), Mathf.Tan(0), Mathf.Cos(angle)) * radius;
        transform.position = centre + offset;
    }
}
