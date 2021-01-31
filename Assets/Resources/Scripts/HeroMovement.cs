using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{

    public int playerSpeed;
    public int jumpPower;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        ListenForKeyboardInputs();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("isJumping", false);
    }

    void ListenForKeyboardInputs()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime, 0, 0);

        if (Input.GetAxis("Horizontal") > 0)
            GetComponent<SpriteRenderer>().flipX = false;
        else if (Input.GetAxis("Horizontal") < 0)
            GetComponent<SpriteRenderer>().flipX = true;

        animator.SetBool("isRunning", Input.GetAxis("Horizontal") != 0);
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && !animator.GetBool("isJumping"))
            Jump();
    }

    void Jump()
    {
        animator.SetBool("isJumping", true);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPower));
        StartCoroutine(checkIfCouldJump());
    }

    private IEnumerator checkIfCouldJump()
    {
        yield return new WaitForSeconds(0.1f);

        if(GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            // hero is standing still, probably stuck between something.
            animator.SetBool("isJumping", false);
        }
    }
}
