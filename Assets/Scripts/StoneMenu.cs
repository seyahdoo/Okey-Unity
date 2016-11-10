using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class StoneMenu : MonoBehaviour
{
    public Button ButtonMenu;
    public Transform PauseMenu;
    public Text MessageText;
    [SerializeField]
    List<GameObject> stonePlaces;
    List<GameObject> stonePlacesHasChildren = new List<GameObject>();
    public void CallScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StoneMenuCheckMessage()
    {
        MessageText.text = "0";
    }

    public void StoneMenuCheck(Transform MenuName)
    {
        if (MenuName.gameObject.activeSelf)
        {
            MenuName.gameObject.SetActive(false);
            if (MenuName.name == "OrderPanel")
                ButtonMenu.gameObject.SetActive(true);
        }
        else if (!MenuName.gameObject.activeSelf)
        {
            MenuName.gameObject.SetActive(true);
            if (MenuName.name == "OrderPanel")
                ButtonMenu.gameObject.SetActive(false);
        }
    }

    public void StonePlacesHasChild()
    {
        stonePlacesHasChildren.Clear();
        foreach (var item in stonePlaces)
        {
            if (item.transform.childCount == 1)
            {
                stonePlacesHasChildren.Add(item.transform.GetChild(0).gameObject);
            }
        }
    }

    public void SortStoneNumber()
    {
        StonePlacesHasChild();
        var result = stonePlacesHasChildren.OrderBy(x => x.GetComponent<StoneRenderer>().stone.Number).ToList();
        var sonuc = result.OrderByDescending(q => int.Parse(q.GetComponent<Image>().sprite.name.Split('-')[2])).ToList();
        var query = sonuc.GroupBy(a => a.GetComponent<StoneRenderer>().stone.Number).SelectMany(ab => ab.Skip(1).Take(1)).ToList();
        DetachStonePlacesChild();
        int[] duplicatedNumbers = new int[query.Count];
        for (int i = 0; i < query.Count; i++)
        {
            duplicatedNumbers[i] = query[i].GetComponent<StoneRenderer>().stone.Number;
        }
        PlaceStoneAfterOrder(sonuc, 0, duplicatedNumbers);
    }

    public void SortStoneTwinNumber()
    {
        StonePlacesHasChild();
        var cift = stonePlacesHasChildren.OrderBy(q => q.GetComponent<StoneRenderer>().stone.Number).ToList();
        var sirala = cift.OrderBy(q => q.GetComponent<StoneRenderer>().stone.Color).ToList();
        DetachStonePlacesChild();
        PlaceStoneAfterOrder(sirala, 0);
    }

    void DetachStonePlacesChild()
    {
        for (int i = 0; i < stonePlaces.Count; i++)
        {
            stonePlaces[i].transform.DetachChildren();
        }
    }

    public void SortStoneColor()
    {
        StonePlacesHasChild();
        var blackList = stonePlacesHasChildren.Where(x => x.GetComponent<StoneRenderer>().stone.Color == Stone.StoneColor.Black).OrderBy(x => x.GetComponent<StoneRenderer>().stone.Number).ToList();
        var blueList = stonePlacesHasChildren.Where(x => x.GetComponent<StoneRenderer>().stone.Color == Stone.StoneColor.Blue).OrderBy(x => x.GetComponent<StoneRenderer>().stone.Number).ToList();
        var greenList = stonePlacesHasChildren.Where(x => x.GetComponent<StoneRenderer>().stone.Color == Stone.StoneColor.Green).OrderBy(x => x.GetComponent<StoneRenderer>().stone.Number).ToList();
        var redList = stonePlacesHasChildren.Where(x => x.GetComponent<StoneRenderer>().stone.Color == Stone.StoneColor.Red).OrderBy(x => x.GetComponent<StoneRenderer>().stone.Number).ToList();
        DetachStonePlacesChild();
        PlaceStoneAfterOrder(blackList, 0);
        int stoneIndex = blackList.Count + 1;
        if (blackList.Count == 0)
            stoneIndex = 0;
        PlaceStoneAfterOrder(blueList, stoneIndex);
        if (blueList.Count == 0)
            stoneIndex = blackList.Count + 1;
        else
            stoneIndex += blueList.Count + 1;
        PlaceStoneAfterOrder(greenList, stoneIndex);
        if (greenList.Count == 0)
            stoneIndex = blackList.Count + blueList.Count + 2;
        else
            stoneIndex += greenList.Count + 1;
        PlaceStoneAfterOrder(redList, stoneIndex);
    }

    void PlaceStoneAfterOrder(List<GameObject> list, int start)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].transform.SetParent(stonePlaces[start].transform);
            start++;
        }
    }

    void PlaceStoneAfterOrder(List<GameObject> list, int start, int[] separate)
    {
        List<GameObject> nonDuplicated = new List<GameObject>();
        for (int i = 0; i < separate.Length; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                if (separate[i] == list[j].GetComponent<StoneRenderer>().stone.Number)
                {
                    list[j].transform.SetParent(stonePlaces[start].transform);
                    start++;
                    nonDuplicated.Add(list[j]);
                }
            }
            start++;
        }
        var kalan = list.Except(nonDuplicated).ToList();
        for (int j = 0; j < kalan.Count; j++)
        {
            kalan[j].transform.SetParent(stonePlaces[start].transform);
            start++;
        }
    }
}