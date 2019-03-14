using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();

        if(ball != null) ball.Restart();
    }

}
