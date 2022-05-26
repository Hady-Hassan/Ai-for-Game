using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] NPCs;
    public GameObject[] loaded;
    public float timer = 20;
    

    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        loaded = GameObject.FindGameObjectsWithTag("Npc");

        if (timer <= 0 || loaded.Length==0)
        {
            timer = 20;
            spawn();
            
        }
    }



    void spawn()
    {
        for(int i =0;  i < 6;++i)
        {
            int z = Random.Range(-18, 75);
            int x = Random.Range(-9, 85);
            int y = Random.Range(2, 3);
            Vector3 pos = new Vector3(x, y, z);
            int index = Random.Range(0, 4);
            GameObject npc = NPCs[index];
            npc.transform.position = pos;
            Instantiate(npc,this.transform);
        }
    }

}
