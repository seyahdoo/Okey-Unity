using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public Player[] players;
    

    public void StartGame()
    {

    }

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
