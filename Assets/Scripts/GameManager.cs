﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour {

    public Player[] players;
    public Table table;
    public int PlayerTurn = 0;
    public bool turnFinished;

    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

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
        table.Scramle();


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
        //sl.Add(new Stone(0, Stone.StoneColor.Black, false));
        //sl.Add(new Stone(0, Stone.StoneColor.Black, false));



        return sl;
    }

    /// <summary>
    /// deal stones to players and start game routine
    /// </summary>
    public void StartGame()
    {
        //Deal Stones
        //15
        players[0].GiveStones(table.GetNStone(15));
        //14
        players[1].GiveStones(table.GetNStone(14));
        players[2].GiveStones(table.GetNStone(14));
        players[3].GiveStones(table.GetNStone(14));

        (players[0] as HumanPlayer).GetDeals();
        //Start Routine
        StartCoroutine(GameRoutine());

    }

    /// <summary>
    /// collect all stones to table
    /// </summary>
    public void ResetGame()
    {
        //TODO
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
        while (true)
        {
            Debug.Log("give turn to"+PlayerTurn);
            //players[PlayerTurn].TurnFinishedEvent += TurnFinish;
            players[PlayerTurn].PlayTurn();


            //wait for turn to finish
            yield return new WaitUntil(() => turnFinished);
            //players[PlayerTurn].TurnFinishedEvent -= TurnFinish;

            //check if game finished
            //TODO???
            //bool isF = LogicApi.IsFinished(players[PlayerTurn].stones);
            //TODO this
            //Debug.Log("Finished turn");
            PlayerTurn = (PlayerTurn+1)%4;
            turnFinished = false;
        }

    }

    public void TurnFinish()
    {
        turnFinished = true;
    }

}
