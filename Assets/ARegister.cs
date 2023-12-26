using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARegister : MonoBehaviour
{

    [SerializeField] public InputField rduserid;
    [SerializeField] public InputField rdpwd;
    [SerializeField] public InputField rdname;
    [SerializeField] public InputField rdmobno;
    public Canvas S1_ContactBook;
    public Canvas S2_Registration;

    public void Registerbtn()
    {
        SaveManager.inst.AddRegistration(this);
        S1_ContactBook.enabled = true;
        S2_Registration.enabled = false;
        Debug.Log("Registration Sucessfull");

    }


}
