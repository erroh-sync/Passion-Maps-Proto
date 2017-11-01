using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __Click_Manager : MonoBehaviour {

    [SerializeField]
    private GameObject PassionPinObj;

    [SerializeField]
    private GameObject Menu;

    public void OnClick()
    {
        __Color_Menu_Controller m = Menu.GetComponent<__Color_Menu_Controller>();

        if (m.enabled)
            m.enabled = false;
        else
        {
            m.enabled = true;
            Menu.transform.position = Input.mousePosition;
        }

        foreach(__Pin_Controller p in FindObjectsOfType<__Pin_Controller>())
        {
            p.CloseMenu();
        }
    }
}
