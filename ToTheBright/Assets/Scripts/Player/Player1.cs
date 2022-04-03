using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    public float jump;
    public float horizontal;

    public Transform feetPos;
    public float checkRadious;
    public LayerMask ground;

    public bool jumpdet = true;
    public bool IsRight = true;


    public float jumpAmount = 35;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;


    public Rigidbody2D rb;
    public Animator anim; 



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        feetPos = gameObject.GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        BlendTree();

        horizontal = Input.GetAxisRaw("Horizontal");
        jump = Input.GetAxisRaw("Jump");

        

        if (Input.GetKeyDown(/*GameManager.instance.keybinds.dictionary["Jump"]*/ KeyCode.Space) && jumpdet==true)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);            
            jumpdet = false;
        }

        jumpdet = Physics2D.Raycast(feetPos.position,Vector2.down,checkRadious,ground);
    }
    
    private void FixedUpdate()
    {
        Move();
        anim.SetBool("Grounded", jumpdet);        
    }

    //Move X
    public void Move()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    //Jump Detect
   // private void OnTriggerEnter2D(Collider2D collision)
   // {
   //     if (collision.gameObject.tag == "Ground")
   //     {
   //         jumpdet = true;

   //     }
   // }

    //BlendTree
    public void BlendTree()
    {
        //Debug.Log(GameManager.instance +"111");
        //Debug.Log(GameManager.instance.keybinds + "112");
        //Debug.Log(GameManager.instance.keybinds.dictionary + "1113");
        //Debug.Log(GameManager.instance.keybinds.dictionary["MoveLeft"] + "1113");
        if (Input.GetKey(/*GameManager.instance.keybinds.dictionary["MoveRight"]*/ KeyCode.D))
        {
            anim.SetInteger("Move", 1);
            anim.SetFloat("WalkBT", 0);
            anim.SetFloat("JumpBT", 0);
            IsRight = true;
        }

        else if (Input.GetKey(/*GameManager.instance.dictionary["MoveLeft"] */KeyCode.A))
        {
            anim.SetInteger("Move", 1);
            anim.SetFloat("WalkBT", 2);
            anim.SetFloat("JumpBT", 2);
            IsRight = false;
        }

        else
        {
            anim.SetInteger("Move", 0);
            if (IsRight==true)
            {
                anim.SetFloat("IdleBT", 0);
            }
            else
            {
                anim.SetFloat("IdleBT", 2);
            }
        }
    }


}
