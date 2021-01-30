using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{

    public int playerSpeed;
    public int jumpPower;

    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ListenForKeyboardInputs();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }

    void ListenForKeyboardInputs()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime, 0, 0);

        if (Input.GetAxis("Horizontal") > 0)
            GetComponent<SpriteRenderer>().flipX = false;
        else if (Input.GetAxis("Horizontal") < 0)
            GetComponent<SpriteRenderer>().flipX = true;


        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && !isJumping)
            Jump();
    }

    void Jump()
    {
        isJumping = true;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPower));
    }
}
