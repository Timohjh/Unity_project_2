using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE SmallBall and BigBall scripts inherit from this script
public class PlayerScript : MonoBehaviour
{
    //ENCAPSULATION
    protected float m_speed;
    public float Speed 
    {
        get {return m_speed;}
        set {m_speed = value;}
    }
    protected const float turning = 45f;
    protected float horiInput;
    protected float vertInput;
    protected Rigidbody rb;
    public GameObject focal;
    protected GameObject player;
    protected Material playerMat;
    private bool initMove = true;

    private void Awake()
    {
        focal = GameObject.Find("Focal");
        player = GameObject.FindGameObjectWithTag("Player");
        playerMat = player.GetComponent<MeshRenderer>().material;
        rb = player.GetComponent<Rigidbody>();
        ChangeColor();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horiInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");

        if (vertInput != 0 && initMove)
        {
            GameObject.Find("Gameplay").GetComponent<Gameplay>().started = true;
            initMove = false;
        }
        //ABSTRACTION
        MovePlayer();
    }
    void MovePlayer()
    {
        rb.AddForce(focal.transform.forward * vertInput * Speed);
        rb.AddForce(focal.transform.right * horiInput * Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Respawn"))
        {
            GameObject.Find("Gameplay").GetComponent<Gameplay>().RestartScene();
        }
    }
    //POLYMORPHISM
    public virtual void ChangeColor()
    {
        playerMat.color = Color.white;
    }
}
