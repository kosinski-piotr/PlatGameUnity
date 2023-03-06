using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerController : MonoBehaviour

{
    public float heroSpeed;
    public float jumpForce;
    public Transform Ground;
    public LayerMask layerstotest;
    Animator anim;
    Rigidbody2D rgdBody;
    bool dirtoRight = true;
    public Transform startPoint;


    private bool ontheGround;
    public float radious = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        rgdBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Contact"))
        {
            rgdBody.velocity = Vector2.zero;
            return;
        }
        ontheGround = Physics2D.OverlapCircle(Ground.position, radious, layerstotest); //tworzy okrąg wokół bohatera i sprawdza czy nie koliduje z coliderem

        float horizontalMove = Input.GetAxis("Horizontal");
        rgdBody.velocity = new Vector2(horizontalMove * heroSpeed, rgdBody.velocity.y);
        
        if(Input.GetKeyDown(KeyCode.Space) && ontheGround)
        {
            rgdBody.AddForce(new Vector2 (0f, jumpForce));
            anim.SetTrigger("jump");
        }

        anim.SetFloat("speed",Mathf.Abs( horizontalMove));

        if (horizontalMove < 0 && dirtoRight)
            Flip();
        if (horizontalMove > 0 && !dirtoRight)
            Flip();
        if (GameObject.Find("Text").GetComponent<Text>().text == "0")
        {
            toMenu();
        }
    }

    void Flip()
    {

        dirtoRight = !dirtoRight;
        Vector3 heroScale = gameObject.transform.localScale;
        heroScale.x *= -1;
        gameObject.transform.localScale = heroScale;
    } 

    public void RestartHero()
    {

        gameObject.transform.position = startPoint.position;

    }

    static void toMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }
}

