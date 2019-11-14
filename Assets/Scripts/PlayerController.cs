using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  // private variables
  private float speed = 5.0f;
  private float turnSpeed = 25.0f;
  private float horizontalInput;
  private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // Player inputs 
     horizontalInput = Input.GetAxis("Horizontal");
     forwardInput = Input.GetAxis("Vertical");
      // Make the truck go forward
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
      // make the truck go left and right
      transform.Rotate(Vector3.right, horizontalInput);
     // make the truck appear to turn 
      transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

}
