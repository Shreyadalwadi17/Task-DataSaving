using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public static SaveManager inst;
    public Data data = new Data();
    [SerializeField] GameObject pbtn;
    [SerializeField] Transform main;
    public Button btn;
    public static string path;


    public void Awake()
    {
        inst = this;
    }

    public void Save()
    {
        BinaryFormatter formattter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/SaveData.txt";
        FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
        formattter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save Sucess");
        return;
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/SaveData.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formattter = new BinaryFormatter();
            FileStream stream = File.Open(path, FileMode.Open);
            formattter.Deserialize(stream);
            stream.Close();
            Debug.Log("Load Sucess");
        }
        else
        {

            Debug.LogError("Save file not found.");
            return;
        }
    }

    public void AddRegistration(ARegister rdata)
    {
        data.rd.Userid = rdata.rduserid.text;
        data.rd.Pwd = rdata.rdpwd.text;
        data.rd.Name = rdata.rdname.text;
        data.rd.Mobno = rdata.rdmobno.text;


    }
    public void AddContact(AContact cdata)
    {
        Contactdata cd = new Contactdata();
        cd.CName = cdata.cdname.text;
        cd.CMobno = cdata.cdmobno.text;
        cd.CEmail = cdata.cdemail.text;
        cd.CAddress = cdata.cdaddress.text;
        data.contacts.Add(cd);
        btn = pbtn.transform.GetComponent<Button>();
        btn.GetComponentInChildren<Text>().text = cd.CName;
        Button buttongameobject = Instantiate(btn, main.transform);
    }

}
[System.Serializable]
public class Data
{
    public Registerdata rd = new Registerdata();
    public List<Contactdata> contacts = new List<Contactdata>();

}
[System.Serializable]
public class Registerdata
{
    public string Userid;
    public string Pwd;
    public string Name;
    public string Mobno;
}
[System.Serializable]
public class Contactdata
{
    public string CName;
    public string CMobno;
    public string CEmail;
    public string CAddress;
}



