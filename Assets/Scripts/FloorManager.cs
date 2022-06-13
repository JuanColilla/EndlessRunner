using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : MonoBehaviour
{
    int childs = 0;

    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
    }

    void Update()
    {
        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
            
        }

        if (gameObject.transform.position.x < 0 && childs == 0)
        {
            GameObject.Find("PlatformOrigin").GetComponent<PlatformOrigin>().CreateNewPlatform();
            childs++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find(collision.gameObject.name).GetComponent<PlayerManager>().SetSplashdown(true);
    }
    
}
