using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{

    public float moveSpeed;
    public Vector3 sunrise;
    public Transform sunset;

    Rigidbody rb;

    public float floatStrength = 0.5f; // How high the object bobs
    public float floatSpeed = 1.0f;    // How fast the object bobs
    public float tiltAmount = 5.0f;    // Degrees of gentle rotation
    public float tiltSpeed = 0.5f;     // Speed of the rotation

  

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sunrise = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {  
        // 1. Vertical Bobbing
        // Mathf.Sin returns -1 to 1, creating a smooth up-and-down cycle
        float newY = sunrise.y + (Mathf.Sin(Time.time * floatSpeed) * floatStrength);
        Vector3 targetPos = new Vector3(transform.position.x, newY, transform.position.z);
        
        rb.MovePosition(targetPos);

        // 2. Gentle Tilting
        // Oscillate rotation on the Z axis for a weightless feel
        float tiltZ = Mathf.Sin(Time.time * tiltSpeed) * tiltAmount;
        Quaternion targetRot = Quaternion.Euler(0, 180, tiltZ);
        
        rb.MoveRotation(targetRot);
        rb.AddTorque(new Vector3(0, moveSpeed, 0) , ForceMode.Force);
    }

   
    //redo script with one for idle animation *sagh*
}
