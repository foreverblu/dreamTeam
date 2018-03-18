using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleePlayerControl : MonoBehaviour
{
    //variables of movement
    public float moveSpeed;
    public float jumpHeight;
    private bool isAir;
    private Vector3 direction = Vector3.right;

    //components of this player
    public Rigidbody2D rb;

    //Weapons
    public GameObject swordPrefab;

    //variables for fighting
    private float cooldown;
    private float attackRate = 1.5f;

    // Use this for initialization
    void Start()
    {
        moveSpeed = 5;
        jumpHeight = 400;
        rb = GetComponent<Rigidbody2D>();
        isAir = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(Time.deltaTime * moveSpeed, 0, 0);
            direction = Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(Time.deltaTime * moveSpeed, 0, 0);
            direction = Vector3.left;
        }
        if (isAir == false)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(Vector3.up * jumpHeight);
                isAir = true;
            }
        }
        if(Time.time >= cooldown)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SwordAttack();
            }
        }
 
    }
    


    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Ground")
        {
            isAir = false;
        }
    }

    void SwordAttack()
    {
        GameObject sPrefab = Instantiate(swordPrefab, transform.position, Quaternion.identity);
        cooldown = Time.time + attackRate;
    }

    public Vector3 getDirection()
    {
        return direction;
    }

    public void Respawn()
    {
        transform.position = new Vector3(0, 20, 0);
    }
}