using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    public Canvas S1_ContactBook;
    public Canvas S2_Registration;
    public Canvas S3_CreateNewCont;
    public Canvas S4_ViewDetail;
    public Canvas S5_UserName;

    void Start()
    {

        S1_ContactBook.enabled = true;
        S2_Registration.enabled = false;
        S3_CreateNewCont.enabled = false;
        S4_ViewDetail.enabled = false;
        S5_UserName.enabled = false;
    }

    public void OnRegbtn()
    {
        S2_Registration.enabled = true;
        S1_ContactBook.enabled = false;

    }
    public void Onsave()
    {
        S5_UserName.enabled = true;
        S3_CreateNewCont.enabled = false;
    }
    public void OnAddContact()
    {
        S3_CreateNewCont.enabled = true;
        S5_UserName.enabled = false;
    }
    public void OnClosebtn()
    {
        S1_ContactBook.enabled = true;
        S2_Registration.enabled = false;
        S3_CreateNewCont.enabled = false;
        S4_ViewDetail.enabled = false;
        S5_UserName.enabled = false;
    }
    public void OnViewContact()
    {
        S4_ViewDetail.enabled = true;
        S5_UserName.enabled = false;
    }
    public void OnViewSave()
    {
        S5_UserName.enabled = true;
        S4_ViewDetail.enabled = false;
    }
    public void OnCloseViewDetailsbtn()
    {
        S1_ContactBook.enabled = false;
        S2_Registration.enabled = false;
        S3_CreateNewCont.enabled = false;
        S4_ViewDetail.enabled = false;
        S5_UserName.enabled = true;
    }
}





