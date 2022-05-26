using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MalbersAnimations.Scriptables;

public class AnimalController : MonoBehaviour
{
    GameObject player;
    public FloatReference value = new FloatReference(0);
    private GameObject slider;
    public Slider slide;
    // Start is called before the first frame update
    void Start()
    {
        slider = GameObject.FindWithTag("health ui");
        slide = slider.GetComponent<Slider>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("health = " + value.ConstantValue);
        if (this.transform.position.y < -1.0f)
        {
            Destroy(this.gameObject);
            print("destroyed");
        }


    }
    void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Water"|| collision.gameObject.tag == "Rocks")
        {
            Destroy(this.gameObject);
            print("destroyed from rock or water");

        }

    }
}
