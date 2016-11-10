using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class LogicApi
{
    /// <summary>
    /// This cant be logical and wont be used!
    /// </summary>
    public static AiAction AIPlay(List<Stone> AiStones,Stone PlayerStone,Stone TablePeek)
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

