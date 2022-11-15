
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float maxSpeed = 1.5f; 
    float rotation = 0.0f; 
    float camRotation = 0.0f; 
    GameObject cam; 
    Rigidbody myRigidbody; 
    public float jumpForce = 500.0f;

    bool isOnGround;
    public GameObject groundChecker; 
    public LayerMask groundLayer; 

    float rotationSpeed = 2.0f; 
    float camRotationSpeed = 1.5f; 
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.5f, groundLayer); 

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        { 
            myRigidbody.AddForce(transform.up * jumpForce); 
        }   
        Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed; 
        myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z); 


        //transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed); 
      transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed); 

      rotation = rotation + Input.GetAxis("Mouse X")  * rotationSpeed; 
      transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

      camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed; 
      camRotation = Mathf.Clamp(camRotation, -40.0f, 40.0f); 
      cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f)); 
    }
}
