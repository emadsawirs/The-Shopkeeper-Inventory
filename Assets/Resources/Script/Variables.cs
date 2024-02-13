using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Variables
{

    [System.Serializable]
    public struct Products
    {
        public int Shopkeeper_N;
        public int Index;
        public string Title;
        public int Price_By_Coins;
    }
    public static Products Product;
    public static List<Products> Products_List = new List<Products>();
    public static List<Products> Items_Player_List = new List<Products>();

    //
    public const int Initialize_Coins = 1000;
    public const int Initialize_Account_Balance = 3000;
    //
    public static float Coins = 0;
    public static float Account_Balance = 0;
    //
    public static float Increase_Percentage_AfterSleeping = 0.10f;
    //
    public static string User_Message = "";
    //
    public static int Shopkeeper_N;


}
