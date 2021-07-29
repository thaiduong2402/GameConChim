using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    
    GameObject obj;
    public bool isEnd;
    public AudioClip over;
    private AudioSource auSource;
    int score;
    public Text txtScore;
    public GameObject panel;
    public Text text;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        auSource = obj.GetComponent<AudioSource>();
        obj = gameObject;
        isEnd = false;
        int score = 0;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }


    
    
    public void getScore()
    {
        score++;
        txtScore.text = "Score : " + score.ToString();
    }
    public void endGame()
    {
        Debug.Log("end");

        Time.timeScale = 0;
        panel.SetActive(true);
        text.text = "Your Score : \n" + score.ToString();
    }

    public void reStart()
    {
        startGame();
    }
    public void startGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        Debug.Log("da retart");
    }

}
