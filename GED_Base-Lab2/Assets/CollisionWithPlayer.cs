using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayer : MonoBehaviour
{
    public PlayerController pc;
    public GameObject bell;


    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            Debug.Log(pc.bulletspeed);
            pc.bulletspeed = 64f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
