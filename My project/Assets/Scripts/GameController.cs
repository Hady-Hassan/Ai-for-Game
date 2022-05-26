using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    float health;
    private GameObject slider;
    public Slider slide;
    // Start is called before the first frame update
   void Start()
    {
        slider = GameObject.FindWithTag("health ui");
        slide = slider.GetComponent<Slider>();
    }

    //Update is called once per frame
    void Update()
    {
        health = slide.value;
        Debug.Log("health = " + slide.value);
        if (health == 0)
        {
            Debug.Log("game over");
            SceneManager.LoadScene(0);
        }
       
    }

    public void res()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(2);
    }

    public void sta()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(2);
    }
}