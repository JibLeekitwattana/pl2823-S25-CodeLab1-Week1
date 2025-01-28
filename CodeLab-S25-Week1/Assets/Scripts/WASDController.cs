using UnityEngine;

public class WASDController : MonoBehaviour
{
    public KeyCode keyUp = KeyCode.W;
    public KeyCode keyDown = KeyCode.S;
    public KeyCode keyLeft = KeyCode.A;
    public KeyCode keyRight = KeyCode.D;

    public Rigidbody rb;

    public float moveForce = 2f;

    Vector3 testVec;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("START!!!");

        //rb = null;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update...");

        if (Input.GetKey(keyUp))
        {
            //rb.AddForce(testVec * moveForce);
            rb.AddForce(Vector3.up * moveForce);
        }

        if (Input.GetKey(keyDown))
        {
            rb.AddForce(Vector3.down * moveForce);
        }

        if (Input.GetKey(keyLeft))
        {
            rb.AddForce(Vector3.left * moveForce);
        }

        if (Input.GetKey(keyRight))
        {
            rb.AddForce(Vector3.right * moveForce);
        }
    }
}
