using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Collections.Generic;

public class Shop : MonoBehaviour
{
    [System.Serializable] class ShopItem
    {
        public Sprite Image;
        public int Price;
        public bool IsPurchased = false;
    }

    [SerializeField] List<ShopItem> ShopItemsList;

    GameObject ItemTemplate;
    GameObject g;
    [SerializeField]Transform ShopScrollView;
    Button buyBtn;

    private void Start()
    {
        ItemTemplate = ShopScrollView.GetChild(0).gameObject;

        int len = ShopItemsList.Count;
        for (int i = 0; i < 12; i++)
        {
            g = Instantiate(ItemTemplate, ShopScrollView);
            //g.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemsList[i].Image;
            //g.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = ShopItemsList[i].Price.ToString();
            //buyBtn = g.transform.GetChild(2).GetComponent<Button>();
            //buyBtn.interactable = ShopItemsList[i].IsPurchased;
            //buyBtn.AddEventListener(i, OnShopItemBtnClicked);
        }

        Destroy(ItemTemplate);
    }

    /*void OnShopItemBtnClicked(int itemIndex)
    {
        ShopItemsList[itemIndex].IsPurchased = true;
        ShopScrollView.GetChild(itemIndex).GetChild(2).GetComponent<Button>();
        buyBtn.interactable = false;
        buyBtn.transform.GetChild(0).GetComponent<Text>().text = "PURCHASED";
    }*/
}
