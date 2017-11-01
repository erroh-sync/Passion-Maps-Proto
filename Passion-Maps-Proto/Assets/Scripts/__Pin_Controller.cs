using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct __Pin_Journal_Data
{
    public string Heading;
    public string Content;
};

public class __Pin_Controller : __God_Object{

    public enum PinCol { Blue, Red, Gray, Green};

    public PinCol col = PinCol.Blue;

    [SerializeField]
    private GameObject[] pinObjs = new GameObject[4];

    [SerializeField]
    private GameObject RotationPoint;

    [SerializeField]
    private GameObject Menu;

    [SerializeField]
    private float MenuOpenThreshold = 0.2f;

    public List<__Pin_Journal_Data> JournalEntries = new List<__Pin_Journal_Data>();

    private Vector2 initialTouchPoint = new Vector2(-1, -1);

    private bool ctrl = false;

    private float storedRot = 0.0f;

    private float ctrlTimer = 0.0f;

    private void Update()
    {
        SetCol();
        Control();
    }

    private void SetCol()
    {
        for(int i = 0; i < pinObjs.Length; i++) 
        {
            if ((int)col == i)
                pinObjs[i].SetActive(true);
            else
                pinObjs[i].SetActive(false);
        }
    }

    public void CloseMenu()
    {
        Menu.GetComponent<__Pin_Menu_Controller>().enabled = false;
    }

    public void StartContol()
    {
        ctrl = true;
        ctrlTimer = 0.0f;
        GameObject.FindGameObjectWithTag("SpawnMenu").GetComponent<__Color_Menu_Controller>().enabled = false;
    }

    public void EndControl()
    {
        ctrl = false;
        if(ctrlTimer < MenuOpenThreshold)
        {
            foreach (__Pin_Controller p in FindObjectsOfType<__Pin_Controller>())
            {
                p.CloseMenu();
            }
            Menu.GetComponent<__Pin_Menu_Controller>().enabled = true;
        }
    }

    public void Control()
    {
        if (ctrl)
        {
            if (Input.touchCount == 1)
            {
                transform.position = new Vector3(transform.position.x + Input.GetTouch(0).deltaPosition.x, transform.position.y + Input.GetTouch(0).deltaPosition.y, 0);
            }
            else if (Input.touchCount == 2)
            {
                RotationPoint.transform.eulerAngles = new Vector3(0, 0, Vector3.Angle(Input.GetTouch(0).position, Input.GetTouch(1).position) * 2);
            }
        }
    }

    public void KillMe()
    {
        Destroy(this.gameObject);
    }
}
