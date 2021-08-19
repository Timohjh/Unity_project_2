using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBall : PlayerScript
{
    
    // Start is called before the first frame update
    void Start()
    {

        player.transform.localScale = new Vector3(1f, 1f, 1f);
        Speed = 210f;
    }

    public override void ChangeColor()
    {
        playerMat.color = Color.red;
    }
}
