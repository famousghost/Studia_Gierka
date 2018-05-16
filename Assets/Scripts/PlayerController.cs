using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private Rigidbody2D player;

    [SerializeField]
    private Sprite playerSprite;

    [SerializeField]
    private Animator playerAnimator;

    [SerializeField]
    private float jumpForce = 6.0f;

    [SerializeField]
    private bool isRight = true;

    [SerializeField]
    private float walk;

    [SerializeField]
    private float playerSpeed = 2.0f;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        walk = Input.GetAxis("Horizontal");
        PlayAnimation();
        if (walk < 0.0f && isRight)
        {
            Flip();
        }
        if (walk > 0.0f && !isRight)
        {
            Flip();
        }
        Move();
        Jump();
    }

    private void Move()
    {
        Vector2 moveX;
        moveX = playerSpeed * walk * Vector2.right * Time.deltaTime;
        player.transform.Translate(moveX);
    }

    private void PlayAnimation()
    {
        if (player.velocity.y == 0)
        {
            playerAnimator.SetFloat("speed", Mathf.Abs(walk));
        }
    }

    private void Flip()
    {
        isRight = !isRight;
        Vector2 ninjaScale = player.transform.localScale;
        ninjaScale.x *= -1;
        player.transform.localScale = ninjaScale;

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && player.velocity.y == 0)
        {
            player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            playerAnimator.SetTrigger("IsJump");
        }
    }
}
