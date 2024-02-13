using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Main_Buttons : MonoBehaviour
{

    public Text Txt_Coins;
    public Text Txt_UserMessage;

    public Button Bt_Sleeping;
    public Text Txt_Sleeping;
    bool Is_Sleeping = false;
    //
    public GameObject Panel_ATM;
    public GameObject Panel_Shopkeepers;

    public GameObject Back_Button;

    void Awake()
    {
        // Use this for initialization
        Variables.Coins = Variables.Initialize_Coins;
        Txt_Coins.text = Variables.Coins.ToString();
        Variables.Account_Balance = Variables.Initialize_Account_Balance;
        //
        Back_Button.SetActive(false);
        //
    }

    // Update is called once per frame
    void Update()
    {
        Txt_Coins.text = Variables.Coins.ToString();
        //
        Txt_UserMessage.text = Variables.User_Message;
        //
    }
    
    public void Shopkeeper1_Press()
    {
        // 
        Panel_Shopkeepers.SetActive(true);
        //
        Panel_Shopkeepers.GetComponent<Shopkeepers>().Open_Inventory(1);
        //
        Back_Button.SetActive(true);
        //
    }

    public void Shopkeeper2_Press()
    {
        // 
        Panel_Shopkeepers.SetActive(true);
        //
        Panel_Shopkeepers.GetComponent<Shopkeepers>().Open_Inventory(2);
        //
        Back_Button.SetActive(true);
        //
    }

    public void Back_From_Shopkeepers()
    {
        Panel_Shopkeepers.SetActive(false);
        Back_Button.SetActive(false);

    }

    public void ATM_Press()
    {
        Panel_ATM.SetActive(true);
        Back_Button.SetActive(true);

    }

    public void Back_From_ATM()
    {
        Panel_ATM.SetActive(false);
        Back_Button.SetActive(false);

    }

    public void ToSleep_Press()
    {
        //
        if (Is_Sleeping)
        {
            Txt_Sleeping.text = "The bed";
            //
            //this get the Transitions of the Button as its unpressed
            Bt_Sleeping.GetComponent<Image>().color = Color.white;
            //
            Variables.User_Message = "";
            //
            float Percentage_Value = (Variables.Account_Balance * Variables.Increase_Percentage_AfterSleeping); // 0.10%
            //
            Variables.Account_Balance = Variables.Account_Balance + Percentage_Value;
            //
            EditorApplication.Beep();
            //
        }
        else
        {
            Txt_Sleeping.text = "Wake up";
            //
            //this get the Transitions of the Button as its pressed
            Bt_Sleeping.GetComponent<Image>().color = Color.yellow;
            //
            Variables.User_Message = "After wake up, Your bank account balance will increase by 10%.";
            //
        }
        //
        Is_Sleeping = !Is_Sleeping;
        //
    }


}
