using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private float dir = 0;
    private float speed = 5f;

    //public Animator anim;
    //public AudioSource som;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*GameObject boxRight   = GameObject.FindGameObjectWithTag("right");
       // GameObject boxRight2  = GameObject.FindGameObjectWithTag("Right2");
        GameObject boxUp      = GameObject.FindGameObjectWithTag("up");
        //GameObject boxLeft    = GameObject.FindGameObjectWithTag("Left");

        

        if(Vector3.Distance(transform.position,boxRight.transform.position) < 3f ) {
          // || Vector3.Distance(transform.position,boxRight2.transform.position) < 3f );{
            dir = 90;
        }

        if(Vector3.Distance(transform.position, boxUp.transform.position) < 3f);{
            dir = 0;
        }

      //  if(Vector3.Distance(transform.position,boxLeft.transform.position) < 3f);{
        //    dir = -90;
        //}*/

        GameObject boxRight    = GameObject.FindGameObjectWithTag("right");
        GameObject boxRight2   = GameObject.FindGameObjectWithTag("right2");

        GameObject boxUp       = GameObject.FindGameObjectWithTag("up");
        GameObject boxUp2      = GameObject.FindGameObjectWithTag("up2");
        GameObject boxUp3      = GameObject.FindGameObjectWithTag("up3");

        GameObject boxLeft     = GameObject.FindGameObjectWithTag("left");
        GameObject boxLeft2    = GameObject.FindGameObjectWithTag("left2");

        if(Vector3.Distance(transform.position,boxRight.transform.position) < 3f 
        || Vector3.Distance(transform.position,boxRight2.transform.position) < 3f ) {

            dir = 90;
        }
        if(Vector3.Distance(transform.position,boxLeft.transform.position) < 3f 
        || Vector3.Distance(transform.position,boxLeft2.transform.position) < 3f ) {

            dir = -90;
        }
        if(Vector3.Distance(transform.position, boxUp.transform.position) < 3f
        || Vector3.Distance(transform.position,boxUp2.transform.position) < 3f 
        || Vector3.Distance(transform.position,boxUp3.transform.position) < 3f ){

            dir = 0;
        }
       

        bool move = false;
        Rigidbody rb = GetComponent<Rigidbody>();
        if(dir == 0){
            
            dir = 0;
            if(rb.velocity.magnitude < 10f){
            rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
            }

            move = true;
        }

      
         if(dir == 90){

            dir = 90;
            if(rb.velocity.magnitude < 5f){
            rb.AddForce(Vector3.right * speed, ForceMode.Impulse);
            }

            move = true;
        }

        if(dir == -90){

            dir = -90;
            if(rb.velocity.magnitude < 5f){
            rb.AddForce(Vector3.left * speed, ForceMode.Impulse);
            }

            move = true;
        }

       

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,dir,0),Time.deltaTime * 1.5f);

    }
}