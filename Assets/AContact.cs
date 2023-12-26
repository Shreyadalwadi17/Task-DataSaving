using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AContact : MonoBehaviour
{
    [SerializeField] public InputField cdname;
    [SerializeField] public InputField cdmobno;
    [SerializeField] public InputField cdemail;
    [SerializeField] public InputField cdaddress;


    public void Contactbtn()
    {
        SaveManager.inst.AddContact(this);
        Debug.Log("Save your new data sucessfully");

    }

}
