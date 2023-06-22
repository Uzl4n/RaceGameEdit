using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float dir = 0;
    private float speed = 0.5f;

    public Animator anim;
    public AudioSource som;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool move = false;
        Rigidbody rb = GetComponent<Rigidbody>();
        if(Input.GetKey("up")){
            dir = 0;
            if(rb.velocity.magnitude < 5f){
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
            }

            move = true;
        }

        if(Input.GetKey("down")){
            dir = 0;
            if(rb.velocity.magnitude < 5f){
            rb.AddForce(-Vector3.forward * speed, ForceMode.Impulse);
            }

            move = true;
        }

         if(Input.GetKey("right")){
            dir = 90;
            if(rb.velocity.magnitude < 5f){
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
            }

            move = true;
        }

        if(Input.GetKey("left")){
            dir = -90;
            if(rb.velocity.magnitude < 5f){
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
            }

            move = true;
        }

        if(move){
            anim.Play("rodaAnimation");
            anim.speed = 2f;
            if(som.isPlaying == false){
                som.Play();
            }
        }

        if(rb.velocity.sqrMagnitude <= 0.1f){
            anim.Rebind();
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,dir,0),Time.deltaTime * 1.5f);

    }
}
