using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float speed = 500f;
    protected const float turning = 45f;
    protected float horiInput;
    protected float vertInput;
    protected Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horiInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * speed * vertInput);
        gameObject.transform.Rotate(Vector3.up, Time.deltaTime * turning * horiInput);
    }
}
