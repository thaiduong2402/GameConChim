using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bantroimay : MonoBehaviour
{
    Vector3 bandau;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        t = -16.5f;
        bandau = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-3 * Time.deltaTime, 0, 0));
        if(transform.position.x < t)
        {
            transform.position = bandau;
        }
    }
}
