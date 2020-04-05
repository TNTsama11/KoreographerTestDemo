using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Animator mAnimator;
    public float speed;


    void Awake()
    {
        mAnimator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            mAnimator.SetBool("Run",true);
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        else
        {
            mAnimator.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            mAnimator.SetBool("Back", true);
            transform.Translate(Vector3.forward * -speed * Time.deltaTime);
        }
        else
        {
            mAnimator.SetBool("Back", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -2f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 2f);
        }
    }
}
