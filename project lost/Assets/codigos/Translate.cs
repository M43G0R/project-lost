using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Translate : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    public float speed = 1f;

    public void Walk()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        anim.SetInteger("walk", 1);
    }
    void Update()
    { 
        //while (true)
        //{
            //Invoke("Walk", 5f);
            //Walk();
            //anim.SetInteger("walk", 0);
        //}
    }
}
