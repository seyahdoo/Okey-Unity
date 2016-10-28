using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour {

    public Player[] players;
    public Table table;
    
    void Start()
    {
        InitGame();
        ResetGame();
        StartGame();
    }

    public void InitGame()
    {
        List<Stone> stones = CreateAllStones();
        table.GiveStone(stones);



    }

    private List<Stone> CreateAllStones()
    {
        List<Stone> sl = new List<Stone>();

        for (int sayi = 1; sayi < 14; sayi++)
        {
            for (int renk = 0; renk < 4; renk++)
            {

                sl.Add(new Stone(sayi, Stone.IntToStoneColor(renk), false));
                sl.Add(new Stone(sayi, Stone.IntToStoneColor(renk), false));
                
            }
        }

        //2 joker
        sl.Add(new Stone(0, Stone.StoneColor.Black, false));
        sl.Add(new Stone(0, Stone.StoneColor.Black, false));



        return sl;
    }

    /// <summary>
    /// deal stones to players and start game routine
    /// </summary>
    public void StartGame()
    {

    }

    /// <summary>
    /// collect all stones to table
    /// </summary>
    public void ResetGame()
    {

    }

    public void PauseGame()
    {

    }

    public void UnPauseGame()
    {

    }
    
    void GiveTurn(Player p)
    {
        //p.StartTurn();
    }

    private IEnumerator GameRoutine()
    {


        yield return null;
    }


}
