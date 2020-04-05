using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public class MyAi : MonoBehaviour
{
    public int hp;
    private NavMeshAgent ag;
    private GameObject target;
    
    void Awake()
    {
        
    }

    void Start()
    {
        ag = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        ag.SetDestination(target.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            this.GetComponent<Renderer>().material.DOColor(Color.red, 0.2f).OnComplete(()=> { this.GetComponent<Renderer>().material.color = Color.white; });
            hp--;
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
