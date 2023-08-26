using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public GameManager gm;
    public NavMeshAgent agent;

    public Vector3 spot;
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        for (int i = 0; i < gm.spots.Length; i++)
        {
            if (gm.spots[i].isBusy == false)
            {
                spot = gm.spots[i].transform.position;
                gm.spots[i].GetComponent<Spot>().isBusy = true;
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(spot);
        animator.SetBool("isMoving", true);
    }


}
