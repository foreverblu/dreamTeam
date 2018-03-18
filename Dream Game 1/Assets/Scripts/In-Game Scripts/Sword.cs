using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    //damage of the sword
    public float damageValue = 20.0f;

    //game objects in the game
    public GameObject GM;
    public GameObject MeleePlayer;


    // Use this for initialization
    void Start()
    {
        GM = GameObject.Find("GameManager");
        MeleePlayer = GameObject.Find("MeleePlayer");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = MeleePlayer.transform.position + MeleePlayer.GetComponent<MeleePlayerControl>().getDirection();
    }

    void FixedUpdate()
    {
        Destroy(gameObject, 1.0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name != "MeleePlayer")
        {
            GM.SendMessage(other.gameObject.name + "Damaged", damageValue);
        }
    }
}