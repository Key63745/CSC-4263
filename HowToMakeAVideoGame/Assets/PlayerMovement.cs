
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Reference to player rigid body
    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    //Use fixed update when you are manipulating physics
    void FixedUpdate()
    {
        //Add a foward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if(Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

       if(Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
