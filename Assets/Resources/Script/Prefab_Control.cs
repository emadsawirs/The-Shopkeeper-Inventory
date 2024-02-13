using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Prefab_Control : MonoBehaviour
{
   //
    public Image Icon;
    public Text Txt_Title;
    public Text Txt_Price;
    //
    public int Item_Index;
    public string Title;
    public int Price;
    //
    public void Fill_Prefab()
     {
        //Item_Index :  it's the item index when added it to products list
        Txt_Title.text = Title;
        Txt_Price.text = Price.ToString() + " coins";
        //
    }

    public void Buy_Button_Press()
    {
        for (int i = 0; i < Variables.Products_List.Count; i++)
        {
            if (Variables.Products_List[i].Index == Item_Index)
            {
                if (Variables.Coins < Variables.Products_List[i].Price_By_Coins)
                {
                    Variables.User_Message = "You don't have enouph coins to buy this Product.";
                    return;
                }
                else
                {
                    //to pay with coins
                    Variables.Coins -= Variables.Products_List[i].Price_By_Coins;
                }
                //
                Variables.Product.Shopkeeper_N = Variables.Products_List[i].Shopkeeper_N;
                Variables.Product.Title = Variables.Products_List[i].Title;
                Variables.Product.Price_By_Coins = Variables.Products_List[i].Price_By_Coins;
                // to get the last index in the array 
                Variables.Product.Index = Variables.Items_Player_List.Count;
                //to add this product to the player's list
                Variables.Items_Player_List.Add(Variables.Product);
                //find the shopkeeper's file script and call a procedure inside it
                Shopkeepers shopkeeper = GameObject.Find("Panel_Shopkeepers").GetComponent<Shopkeepers>();
                //to add this product button to the player's panel
                shopkeeper.Add_Item_player();
                //
                //to remove this product from the list of products
                Variables.Products_List.RemoveAt(i);
                 Destroy(this.gameObject);
                //
                EditorApplication.Beep();
                Variables.User_Message = "";
                //
            }

        }
        //
    }

    public void Sell_Button_Press()
    {
        //
        for (int i = 0; i < Variables.Items_Player_List.Count; i++)
        {
            if (Variables.Items_Player_List[i].Index == Item_Index)
            {
                //to retrieve coins
                Variables.Coins += Variables.Items_Player_List[i].Price_By_Coins;
                //
                Variables.Product.Shopkeeper_N = Variables.Shopkeeper_N;//current shopkeeper nember
                Variables.Product.Title = Variables.Items_Player_List[i].Title;
                Variables.Product.Price_By_Coins = Variables.Items_Player_List[i].Price_By_Coins;
                // to get the last index in the array 
                Variables.Product.Index = Variables.Products_List.Count;
                //to add this product to the product list
                Variables.Products_List.Add(Variables.Product);
                //
                //find the shopkeeper's file script and call a procedure inside it
                Shopkeepers shopkeeper = GameObject.Find("Panel_Shopkeepers").GetComponent<Shopkeepers>();
                //to add this product button to the product panel
                shopkeeper.Add_Product();
                //
                //to remove this item from player's list
                Variables.Items_Player_List.RemoveAt(i);
                Destroy(this.gameObject);
                //
                EditorApplication.Beep();
                Variables.User_Message = "";
                //
            }
        }
        //
    }

}
