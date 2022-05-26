using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    Animator Animator;
    public GameObject[] targets;
    float speed;
    public float accuracy = 3;
    int index = 0;
    public float timer = 20;
    public int score = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        Animator = this.GetComponent<Animator>();
        targets = GameObject.FindGameObjectsWithTag("Npc");
        Animator.SetBool("Movement",true);
        Animator.SetBool("Grounded", true);
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        targets = GameObject.FindGameObjectsWithTag("Npc");
        agent.SetDestination(targets[index].transform.position);
        if (Vector3.Distance(this.transform.position, targets[index].transform.position) <= accuracy)
        {
            Destroy(targets[index]);
            score++;
            timer = 20;

        }

        if(timer <=0)
        {
            ++index;
            timer = 20;
        }


        speed = agent.velocity.magnitude;
        if(speed> 0.1)
        {
            Animator.SetFloat("Vertical", 3);
        }           
    }
  
}
