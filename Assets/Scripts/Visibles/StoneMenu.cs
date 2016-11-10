using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class StoneMenu : MonoBehaviour
{
    public Transform stoneMenuPanel;

    public void StoneMenuCheck()
    {
        if (stoneMenuPanel.gameObject.activeSelf)
            stoneMenuPanel.gameObject.SetActive(false);
        else if (!stoneMenuPanel.gameObject.activeSelf)
            stoneMenuPanel.gameObject.SetActive(true);
    }
    public void SortStoneNumber()
    {

    }
    public void SortStoneColor()
    {
      
    }
}