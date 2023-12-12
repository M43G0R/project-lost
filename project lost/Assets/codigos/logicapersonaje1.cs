using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicapersonaje1 : MonoBehaviour
{

    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim ;
    public CharacterController player;
    public float x, y ;
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("arma"))
        {
            print("Damage");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      player = GetComponent<CharacterController>();  
      anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x*Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        AnimControl();

    }

    public void AnimControl(){
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

    }
}
