using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cotchay : MonoBehaviour
{
    Vector3 bandau;
    public float t;
    public int min;
    public int max;
    public GameObject gameConTroll;
    // Start is called before the first frame update
    void Start()
    {
        min = 2;
        max = 6;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-3 * Time.deltaTime, 0, 0));
        if (transform.position.x < -15f)
        {
            transform.position = new Vector3(25, Random.Range(min, max), transform.position.z);
            
        }
        
    }
   
}
