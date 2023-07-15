using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{


    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    
    public GameObject Window1;
    public GameObject Window2;
    public GameObject Window3;
    public GameObject Window4;
    
    public void Show_Hide_Window1()
    {
        Window1.SetActive(true);
        Window2.SetActive(false);
        Window3.SetActive(false);
        Window4.SetActive(false);

    }
    public void Show_Hide_Window2()
    {
        Window1.SetActive(false);
        Window2.SetActive(true);
        Window3.SetActive(false);
        Window4.SetActive(false);

    }   
    public void Show_Hide_Window3()
    {
        Window1.SetActive(false);
        Window2.SetActive(false);
        Window3.SetActive(true);
        Window4.SetActive(false);

    }   
    public void Show_Hide_Window4()
    {
        Window1.SetActive(false);
        Window2.SetActive(false);
        Window3.SetActive(false);
        Window4.SetActive(true);

    }
    
}
