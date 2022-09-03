using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarHandler : MonoBehaviour
{
    public GameObject[] stars;
    public GameObject[] passOrFail;
    //public int starCollect;
    [SerializeField] private int bloodCount; // number of available
    [SerializeField] private ItemState blood;

    void Update()
    {
        CountItemIndex();
        if(HealthState.gameOver)
        {
            PlayerGameOver();
        }
        else
        {
            CountStars();
        }
    }
    void CountItemIndex()
    {
        bloodCount = blood.itemBlood;
    }
    void CountStars()
    {
        // The quantity of blood when a player gets it

        if (bloodCount == 1)
        {
            // one star
            stars[0].SetActive(true);
            passOrFail[0].SetActive(true);
            passOrFail[1].SetActive(false);
        }
        else if (bloodCount == 2)
        {
            // two star
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            passOrFail[0].SetActive(true);
            passOrFail[1].SetActive(false);
        }
        else if (bloodCount == 3)
        {
            // three star
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
            passOrFail[0].SetActive(true);
            passOrFail[1].SetActive(false);
        }
        else if ((bloodCount == 0))
        {
            passOrFail[0].SetActive(false);
            passOrFail[1].SetActive(true);
        }

    }
    void PlayerGameOver()
    {
        stars[0].SetActive(false);
        stars[1].SetActive(false);
        stars[2].SetActive(false);
        passOrFail[0].SetActive(false);
        passOrFail[1].SetActive(true);
    }


}
