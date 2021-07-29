using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class chimbay : MonoBehaviour
{   int power;
    GameObject obj;
    public AudioClip sly;
    public AudioClip over;
    private AudioSource auSource;
    public GameObject controller;
    bool isReStart;
    bool isStart;
    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        obj = gameObject;
        auSource = obj.GetComponent<AudioSource>();
        auSource.clip = sly;
        isReStart = true;
        isStart = true;
        /*ani = obj.GetComponent<Animator>();
        ani.SetFloat("flyPower", 0);
        ani.SetBool("isDead" , false);*/
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)&&isReStart==true || Input.GetKeyDown("space")&& isReStart==true)
        {
            if(isStart == true)
            {
                Time.timeScale = 1;
            }
            auSource.Play();
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 20));
            
            if(isReStart == false)
            {
                controller.GetComponent<Game>().reStart();
            }
        }
        //ani.SetFloat("flyPower", obj.GetComponent<Rigidbody2D>().velocity.y);


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        endGame();
        
    }    
    void endGame()
    {
        //ani.SetBool("isDead", true);
        auSource.clip = over;
        auSource.Play();
        controller.GetComponent<Game>().endGame();
        isReStart = false;
        isStart = false;
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        controller.GetComponent<Game>().getScore();
    }


}
