using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopkeepers : MonoBehaviour
{
    public Text Txt_label;
    public GameObject Panel_Products;
    GameObject Prefab_Item;

    public GameObject Panel_Inventory_Player;
    GameObject Prefab_Item_Player;

    void Awake()
    {
        // Use this for initialization
        //to load our Prefabs
        Prefab_Item = (GameObject)Resources.Load("Prefabs/Prefab_Item", typeof(GameObject));
        //
        Prefab_Item_Player = (GameObject)Resources.Load("Prefabs/Prefab_Item_Player", typeof(GameObject));
        //to add a few items to the product array, for example
        Add_Initially_Items();
        //

    }

    public void Add_Initially_Items()
    {
        //to add a few items to the product array, for example
        //10 items for per shopkeeper
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Couch";
        Variables.Product.Price_By_Coins = 50;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Shelving";
        Variables.Product.Price_By_Coins = 60;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Bookcases";
        Variables.Product.Price_By_Coins = 100;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Table";
        Variables.Product.Price_By_Coins = 80;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Desk";
        Variables.Product.Price_By_Coins = 95;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "chair";
        Variables.Product.Price_By_Coins = 60;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Buffet";
        Variables.Product.Price_By_Coins = 90;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Bed";
        Variables.Product.Price_By_Coins = 150;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Cabinet";
        Variables.Product.Price_By_Coins = 200;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 1;
        Variables.Product.Title = "Dressing table";
        Variables.Product.Price_By_Coins = 130;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        //
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "TV";
        Variables.Product.Price_By_Coins = 200;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "Stereo equipment";
        Variables.Product.Price_By_Coins = 100;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "laptop";
        Variables.Product.Price_By_Coins = 300;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "Refrigerator";
        Variables.Product.Price_By_Coins = 190;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "Freezer";
        Variables.Product.Price_By_Coins = 10;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "Stove";
        Variables.Product.Price_By_Coins = 140;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "Microwave";
        Variables.Product.Price_By_Coins = 60;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "Dishwasher";
        Variables.Product.Price_By_Coins = 50;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "Toaster";
        Variables.Product.Price_By_Coins = 10;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);
        //
        Variables.Product.Shopkeeper_N = 2;
        Variables.Product.Title = "Water heater";
        Variables.Product.Price_By_Coins = 20;
        Variables.Product.Index = Variables.Products_List.Count;
        Variables.Products_List.Add(Variables.Product);

    }

    public void Open_Inventory(int Shop_N) //open the inventory by the shopkeeper number
    {
        Variables.Shopkeeper_N = Shop_N;
         //
        if (Shop_N ==1)
        {
            Txt_label.text = "The shopkeeper's inventory (one)";
            View_products(Shop_N);
        }
        else if (Shop_N == 2)
        {
            Txt_label.text = "The shopkeeper's inventory (two)";
            View_products(Shop_N);
        }
        //
        View_Items_player();
        //
        Variables.User_Message = "";
        //
    }

    public void View_products(int Shop_N)
    {
        //destroy all the old products from the products panel
        Transform panelTransform = Panel_Products.transform;
        foreach (Transform child in panelTransform)
        {
            Destroy(child.gameObject);
        }
        //
        // to sure that the Prefab_Item object not null!
        if (Prefab_Item != null)
        {
            for (int i = 0; i < Variables.Products_List.Count ; i++)
            {
                if ( Variables.Products_List[i].Shopkeeper_N == Shop_N)
                {
                    //to instantiate this product in the products panel
                    GameObject New_product = (GameObject)Instantiate(Prefab_Item);
                    New_product.transform.SetParent(Panel_Products.transform, false);
                    //pre product in list have the Prefab_Control script to control it
                    //add the new product info to Prefab_Control
                    New_product.GetComponent<Prefab_Control>().Item_Index = Variables.Products_List[i].Index;
                    New_product.GetComponent<Prefab_Control>().Title = Variables.Products_List[i].Title;
                    New_product.GetComponent<Prefab_Control>().Price = Variables.Products_List[i].Price_By_Coins;
                    //
                    New_product.GetComponent<Prefab_Control>().Fill_Prefab();
                    //
                }

            }
        }
    }

    public void View_Items_player()
    {
        //destroy all the old items from the player's panel
        Transform panelTransform = Panel_Inventory_Player.transform;
        foreach (Transform child in panelTransform)
        {
            Destroy(child.gameObject);
        }
        //
        // to sure that the Prefab_Item_Player object not null!
        if (Prefab_Item_Player != null)
        {
            for (int i = 0; i < Variables.Items_Player_List.Count; i++)
            {
                //to instantiate this item in the player's panel
                GameObject New_Item = (GameObject)Instantiate(Prefab_Item_Player);
                New_Item.transform.SetParent(Panel_Inventory_Player.transform, false);
                //pre item in list have the Prefab_Control script to control it
                //add the new item info to Prefab_Control
                New_Item.GetComponent<Prefab_Control>().Item_Index = Variables.Items_Player_List[i].Index;
                New_Item.GetComponent<Prefab_Control>().Title = Variables.Items_Player_List[i].Title;
                New_Item.GetComponent<Prefab_Control>().Price = Variables.Items_Player_List[i].Price_By_Coins;
                //
                New_Item.GetComponent<Prefab_Control>().Fill_Prefab();
                //

            }
        }
    }


    public void Add_Product()
    {
        int indx = Variables.Products_List.Count -1;
        //
        GameObject New_product = (GameObject)Instantiate(Prefab_Item);
        New_product.transform.SetParent(Panel_Products.transform, false);
        //add the new product info to Prefab_Control
        New_product.GetComponent<Prefab_Control>().Item_Index = Variables.Products_List[indx].Index;
        New_product.GetComponent<Prefab_Control>().Title = Variables.Products_List[indx].Title;
        New_product.GetComponent<Prefab_Control>().Price = Variables.Products_List[indx].Price_By_Coins;
        //
        New_product.GetComponent<Prefab_Control>().Fill_Prefab();
        //
    }

    public void Add_Item_player()
    {
        int indx = Variables.Items_Player_List.Count - 1;
        //
        GameObject New_Item = (GameObject)Instantiate(Prefab_Item_Player);
        New_Item.transform.SetParent(Panel_Inventory_Player.transform, false);
        //add the new item info to Prefab_Control
        New_Item.GetComponent<Prefab_Control>().Item_Index = Variables.Items_Player_List[indx].Index;
        New_Item.GetComponent<Prefab_Control>().Title = Variables.Items_Player_List[indx].Title;
        New_Item.GetComponent<Prefab_Control>().Price = Variables.Items_Player_List[indx].Price_By_Coins;
        //
        New_Item.GetComponent<Prefab_Control>().Fill_Prefab();
        //
    }
}


