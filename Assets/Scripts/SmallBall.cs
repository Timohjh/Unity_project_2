using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inherits from PlayerScript
public class SmallBall : PlayerScript
{
    
    void Start()
    {
        // set scale, speed and color
        player.transform.localScale = new Vector3(1f, 1f, 1f);
        Speed = 210f;
    }
    // practising overriding
    public override void ChangeColor()
    {
        playerMat.color = Color.red;
    }
}
