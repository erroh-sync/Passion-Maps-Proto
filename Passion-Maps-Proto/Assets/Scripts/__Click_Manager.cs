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
        /*
        GameObject pin = Instantiate(PassionPinObj, new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0), Quaternion.identity) as GameObject;
        pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);
        */

        __Color_Menu_Controller m = Menu.GetComponent<__Color_Menu_Controller>();

        if (m.enabled)
            m.enabled = false;
        else
        {
            m.enabled = true;
            Menu.transform.position = Input.mousePosition;
        }
    }
}
