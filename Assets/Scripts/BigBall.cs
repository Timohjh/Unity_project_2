using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBall : PlayerScript
{
    // Start is called before the first frame update
    void Start()
    {
        
        player.transform.localScale = new Vector3(1.8f,1.8f,1.8f);
        Speed = 235f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void ChangeColor()
    {
        playerMat.color = Color.blue;
        Debug.Log("change");
    }
}
