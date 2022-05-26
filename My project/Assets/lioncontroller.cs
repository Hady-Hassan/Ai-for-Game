using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lioncontroller : MonoBehaviour
{
    public GameObject[] targets;
    public int lionScore = 0;
    public float health = 100;
    private GameObject slider;
    public Slider slide;
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Npc");
        slider = GameObject.FindWithTag("health ui");
        slide = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slide.value = health/100;
        health -= Time.deltaTime*2 ;

        targets = GameObject.FindGameObjectsWithTag("Npc");
        for(int i = 0; i<targets.Length;++i)
        {
            if (Vector3.Distance(this.transform.position, targets[i].transform.position) <= 2)
            {
                Destroy(targets[i].gameObject);
                print("a point for the lion");
                health = 100;
                lionScore++;
               
            }
        }
        
    }
}
