using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    public Transform target;
    private int i = 0;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(2, 6);
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Cont" + i).transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
