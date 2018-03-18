using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangePlayerControl : MonoBehaviour {

    //variables of movement
    public float moveSpeed;
    public float jumpHeight;
    private bool isAir;
    private Vector3 direction = Vector3.left;

    //components of this player
    public Rigidbody2D rb;

    //Weapons
    public GameObject arrowPrefab;

    //variables for fighting
    private float cooldown;
    private float attackRate = 0.2f;

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
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Time.deltaTime * moveSpeed, 0, 0);
            direction = Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(Time.deltaTime * moveSpeed, 0, 0);
            direction = Vector3.left;
        }
        if (isAir == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(Vector3.up * jumpHeight);
                isAir = true;
            }
        }
        if (Time.time >= cooldown)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ArrowAttack();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            isAir = false;
        }
    }

    void ArrowAttack()
    {
        GameObject aPrefab = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
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
