using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ATM : MonoBehaviour
{
    public InputField Txt_Input;
    public Text Txt_Account_Balance;

    void Start()
    {
        Txt_Input.text = "";
    }

    void Update()
    {
        Txt_Account_Balance.text = Variables.Account_Balance.ToString();
    }

    public void Deposit_Press()
    {
        if (Txt_Input.text == "" || Txt_Input.text == "0")
        {
            Variables.User_Message = "";
            return;
        }
        //
        //
        int NewValue = System.Convert.ToInt16(Txt_Input.text);
        //
        if (NewValue > Variables.Coins)
        {
            Variables.User_Message = "Please insert a value less than your current coins.";
            return;
        }
        //
        EditorApplication.Beep();
        //deposit it from player's coins
        Variables.Account_Balance = Variables.Account_Balance + NewValue;
        Variables.Coins -= NewValue;
        //
        Txt_Input.text = "";
        Variables.User_Message = "You have deposit " + NewValue.ToString() + " coins to your bank account.";
    }
    public void Withdraw_Press()
    {
        if (Txt_Input.text == "" || Txt_Input.text == "0")
        {
            Variables.User_Message = "";
            return;
        }
        //
        int NewValue = System.Convert.ToInt16(Txt_Input.text);
        //
        if (NewValue > Variables.Account_Balance)
        {
            Variables.User_Message = "Please insert a value less than your account balance.";
            return;
        }
        //
        EditorApplication.Beep();
        //withdraw it from Account Balance and add it to the player's coins
        Variables.Account_Balance = Variables.Account_Balance - NewValue;
        Variables.Coins += NewValue;
        //
        Txt_Input.text = "";
        Variables.User_Message = "You have withdraw " + NewValue.ToString() + " coins from your bank account.";

    }

}
