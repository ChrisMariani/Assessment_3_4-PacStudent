using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkMovement : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start() { }

    public float moveSpeed = 5.0f;
    public AudioSource move;


    public Animator animator;

    // Update is called once per frame
    void Update()
    {

//USER INPUT MOVEMENT
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0.0f);
        transform.position = transform.position + movement * Time.deltaTime;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

    }

    //INDEPENDENT MOVEMENT

void MovementSound() {
        move.Play();
    }


}

