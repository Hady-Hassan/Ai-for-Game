using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using MalbersAnimations.Scriptables;

public class AnimalController : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
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
