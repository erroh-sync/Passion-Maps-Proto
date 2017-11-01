using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __Color_Menu_Controller : __God_Object{

    [SerializeField]
    private GameObject PassionPinObj;

    private void InstantiatePin(__Pin_Controller.PinCol col)
    {
        GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
        pin.transform.SetParent(GameObject.FindGameObjectWithTag("PinParent").transform);

        pin.GetComponent<__Pin_Controller>().col = col;

        this.enabled = false;
    }
	
    public void BlueSpawn()
    {
        if (enabled)
        {
            InstantiatePin(__Pin_Controller.PinCol.Blue);
        }
    }

    public void RedSpawn()
    {
        if (enabled)
        {
            InstantiatePin(__Pin_Controller.PinCol.Red);
        }
    }

    public void GraySpawn()
    {
        if (enabled)
        {
            InstantiatePin(__Pin_Controller.PinCol.Gray);
        }
    }

    public void GreenSpawn()
    {
        if (enabled)
        {
            InstantiatePin(__Pin_Controller.PinCol.Green);
        }
    }
}
