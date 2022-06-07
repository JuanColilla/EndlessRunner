using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    bool isAtSight;
    bool splashDown = true;
    Rigidbody2D playerRb;
    [SerializeField] float jumpForce;
     
    private void Awake()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && isAtSight && splashDown)
        {
            playerRb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            splashDown = false;
        }
    }

    private void OnBecameInvisible()
    {
        isAtSight = false;
    }

    private void OnBecameVisible()
    {
        isAtSight = true;
    }

    public void SetSplashdown(bool splashDown)
    {
        this.splashDown = splashDown;
    }
    
}
