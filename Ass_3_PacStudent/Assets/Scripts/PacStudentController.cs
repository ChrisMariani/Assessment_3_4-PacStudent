using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public GameObject currNode;
    public float moveSpeed = 5.0f;

    public AudioSource move;
    public KeyCode lastinput;
    public KeyCode currentInput;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0.0f);
     transform.position = transform.position + movement * Time.deltaTime;
       

    if (Input.GetKey("w")){
      print("W Pressed");
      animator.SetFloat("Horizontal", movement.x);
      lastinput = currentInput;
      currentInput = KeyCode.W;
     }

    else if (Input.GetKey("s")) {
      print("S Pressed");
      animator.SetFloat("Horizontal", movement.x);
      lastinput = currentInput;
      currentInput = KeyCode.S;
        }

    else if (Input.GetKey("a")){
     print("A Pressed");
     animator.SetFloat("Vertical", movement.y);
     lastinput = currentInput;
     currentInput = KeyCode.A;
        }

    else if (Input.GetKey("d")){
     print("D Pressed");
     animator.SetFloat("Vertical", movement.y);
     lastinput = currentInput;
     currentInput = KeyCode.D;
        }

    }
}
