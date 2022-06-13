using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private float jumpForce;

    private bool splashDown;
    private Rigidbody2D playerRb;
    private Sprite sprite;

    private void Awake()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        splashDown = false;
    }

    private void Start()
    {
        gameObject.transform.localScale = (gameObject.transform as RectTransform).localScale / sprite.rect.size * sprite.pixelsPerUnit;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && CanAddForce())
        {
            AddForce();
        } else if (Input.GetKeyUp(KeyCode.Space))
        {
            splashDown = false;
        }

        if (gameObject.transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void AddForce()
    {
        playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

    }

    private bool CanAddForce()
    {
        return IsAtSight() && splashDown;
    }

    private bool IsAtSight()
    {
        return gameObject.transform.position.y < 5;
    }

    public void SetSplashdown(bool splashDown)
    {
        this.splashDown = splashDown;
    }
}
