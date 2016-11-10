using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class LogicApi
{

    public static AiAction AIPlay(List<Stone> AiStones,Stone PlayerStone)
    {
        //Should't say new Stone() !?
        //TODO: Write this stuff
        //TODO: This

        return null;
    }

    public class AiAction
    {

        public AiAction(Stone ToGive, PlayAction Action)
        {
            this.ToGive = ToGive;
            this.Action = Action;
        }

        public Stone ToGive;
        public PlayAction Action;

        public enum PlayAction
        {
            GetFromPile,
            GetFromPlayer
        }
        
    }

}

