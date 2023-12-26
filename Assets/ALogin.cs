using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ALogin : MonoBehaviour
{
    [SerializeField] public InputField lduserid;
    [SerializeField] public InputField ldpwd;
    public Canvas S1_ContactBook;
    public Canvas S5_UserName;

    public void Loginbtn()
    {
        if ((lduserid.text == SaveManager.inst.data.rd.Userid) && (ldpwd.text == SaveManager.inst.data.rd.Pwd))
        {
            S1_ContactBook.enabled = false;
            S5_UserName.enabled = true;
            Debug.Log("login sucess");

        }
        else
        {
            Debug.Log("Invalidb Username and Password");
        }
    }
}
