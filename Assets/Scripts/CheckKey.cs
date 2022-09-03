using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckKey : MonoBehaviour
{
    public BoxCollider2D box;
    public Sprite isUnlock;
    bool unlock;

    //public int buttonID = 1;
    private Item thisItem;
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        UnlockDoor();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameManager.canUnlock == true)
            {
                unlock = true;
            }
            Debug.Log(unlock);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameManager.canUnlock != true)
            {
                unlock = false;
            }
        }
    }
    private Item GetThisItem()
    {
        for (int i = 0; i < GameManager.instance.items.Count; i++)
        {
            if(unlock)
            {
                thisItem = GameManager.instance.items[i]; // Get Item
            }

        }
        return thisItem;
    }
    void UnlockDoor()
    {
        if (unlock == true)
        {
            box.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().sprite = isUnlock;
            GameManager.instance.RemoveItem(GetThisItem()); // return item, And remove it
        }
    }
}
