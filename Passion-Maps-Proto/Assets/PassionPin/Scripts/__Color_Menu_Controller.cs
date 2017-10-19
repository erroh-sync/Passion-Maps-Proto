using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __Color_Menu_Controller : __God_Object{

    [SerializeField]
    private GameObject PassionPinObj;
	
    public void BlueSpawn()
    {
        if (enabled)
        {
            GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
            pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);

            pin.GetComponent<__Pin_Controller>().col = __Pin_Controller.PinCol.Blue;

            this.enabled = false;
        }
    }

    public void RedSpawn()
    {
        if (enabled)
        {
            GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
            pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);

            pin.GetComponent<__Pin_Controller>().col = __Pin_Controller.PinCol.Red;

            this.enabled = false;
        }
    }

    public void GraySpawn()
    {
        if (enabled)
        {
            GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
            pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);

            pin.GetComponent<__Pin_Controller>().col = __Pin_Controller.PinCol.Gray;

            this.enabled = false;
        }
    }

    public void GreenSpawn()
    {
        if (enabled)
        {
            GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
            pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);

            pin.GetComponent<__Pin_Controller>().col = __Pin_Controller.PinCol.Green;

            this.enabled = false;
        }
    }
}
