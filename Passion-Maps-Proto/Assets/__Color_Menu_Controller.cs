using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __Color_Menu_Controller : __God_Object{

    [SerializeField]
    private GameObject PassionPinObj;
	
    public void BlueSpawn()
    {
        GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
        pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);

        pin.GetComponent<__Pin_Controller>().col = __Pin_Controller.PinCol.Blue;

        this.enabled = false;
    }

    public void RedSpawn()
    {
        GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
        pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);

        pin.GetComponent<__Pin_Controller>().col = __Pin_Controller.PinCol.Red;

        this.enabled = false;
    }

    public void GraySpawn()
    {
        GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
        pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);

        pin.GetComponent<__Pin_Controller>().col = __Pin_Controller.PinCol.Gray;

        this.enabled = false;
    }

    public void GreenSpawn()
    {
        GameObject pin = Instantiate(PassionPinObj, this.transform.position, Quaternion.identity) as GameObject;
        pin.transform.SetParent(GameObject.FindGameObjectWithTag("MainCanvas").transform);

        pin.GetComponent<__Pin_Controller>().col = __Pin_Controller.PinCol.Green;

        this.enabled = false;
    }
}
