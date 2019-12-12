using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniControl : MonoBehaviour {

    static Animator anim;
    public float speed = 10.0f;
    public float rotationspeed = 100.0f;

	void Start () 
    {
		anim = GetComponent<Animator>();
	}
	void Update () 
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationspeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0,rotation,0);


		if(Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isjumping");
        }
        if(translation != 0)
        {
            anim.SetBool("isrunning", true);
        }
        else
        {
            anim.SetBool("isrunning", false);
        }
	}
}
