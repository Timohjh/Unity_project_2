using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inherits from PlayerScript
public class BigBall : PlayerScript
{
    // Start is called before the first frame update
    void Start()
    {
        // set scale, speed and color
        player.transform.localScale = new Vector3(1.8f,1.8f,1.8f);
        Speed = 235f;
    }

    // practising overriding
    public override void ChangeColor()
    {
        playerMat.color = Color.blue;
        Debug.Log("change");
    }
}
