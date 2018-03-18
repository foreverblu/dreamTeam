using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData: MonoBehaviour{
    public int player_exp = 0;
    public string player_name = "Player";
    public int f2p_currency = 0;//currency earned through games
    public int p2w_currency = 0;//currency purchased
    //public array owned characters
    //public array owned skins

    private int level = 1;
	// Use this for initialization
	void Start () {
        
	}

    public int[] getPlayerProgress(){
        //converts exp to level and returns player exp and level
        level = convertExpToLevel();
        int[] array = {player_exp, level};
        return array;
    }

    //converts exp to level
    private int convertExpToLevel()
    {
        //TODO: insert conversion method here
        //such as +1 level per 100 exp
        return level;
    }
}
