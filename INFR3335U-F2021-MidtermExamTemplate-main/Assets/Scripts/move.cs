using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
    private float dirX, dirZ;
    private bool grounded;
    public Vector3 jump;

    void Start()
    {
        speed = 3f;
        rb = GetComponent<Rigidbody>();
        //jump = new Vector3(0f, 5f, 0f);

    }

    private void OnCollisionEnter(Collision collision)
    {
       /* if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

        if(collision.gameObject.tag == "End")
        {
            SceneManager.LoadScene("Win");
        }*/

    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * speed;
        dirZ = Input.GetAxis("Vertical") * speed;

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jump, ForceMode.Impulse);
        }*/

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, 0f, dirZ);
    }
}
