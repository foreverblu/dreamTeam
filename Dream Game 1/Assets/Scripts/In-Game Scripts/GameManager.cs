using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Players in game
    public GameObject player1;
    public GameObject player2;

    //Health of two players
    public float HP1 = 100;
    public float HP2 = 100;

    // Use this for initialization
    void Start()
    {
        player1 = GameObject.Find("MeleePlayer");
        player2 = GameObject.Find("RangePlayer");
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Damage dealt to player 1
    void MeleePlayerDamaged(float damage)
    {
        if (HP1 > 0)
        {
            HP1 -= damage;
            Debug.Log("Damaged, left hp:" + HP1);
        }
        if(HP1 <= 0)
        {
            player1.SendMessage("Respawn");
            HP1 = 100;
        }
    }

    //Damage dealt to player 2
    void RangePlayerDamaged(float damage)
    {
        if (HP2 > 0)
        {
            HP2 -= damage;
            Debug.Log("Damaged, left hp:" + HP2);
        }
        if (HP2 <= 0)
        {
            player2.SendMessage("Respawn");
            HP2 = 100;
        }
    }
}
