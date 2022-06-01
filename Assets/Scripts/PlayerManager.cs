using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }
}
