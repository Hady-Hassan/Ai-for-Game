using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -1.0f)
        {
            Destroy(this.gameObject);
            print("destroyed");
        }
        if (Vector3.Distance(this.transform.position, player.transform.position) <= 2)
        {
            Destroy(this.gameObject);
            print("a point for the lion");
            

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
