using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __Pin_Controller : __God_Object{

    public enum PinCol { Blue, Red, Gray, Green};

    public PinCol col = PinCol.Blue;

    [SerializeField]
    private GameObject[] pinObjs = new GameObject[4];

    [SerializeField]
    private GameObject highlight;

    private Vector2 initialTouchPoint = new Vector2(-1, -1);

    private bool ctrl = false;

    private bool Highlighted = false;

    private float storedRot = 0.0f;

    private void Update()
    {
        SetCol();
        highlight.active = Highlighted;
        Control();
    }

    private void SetCol()
    {
        for(int i = 0; i < pinObjs.Length; i++) 
        {
            if ((int)col == i)
                pinObjs[i].active = true;
            else
                pinObjs[i].active = false;
        }
    }

    public void UnHighlight()
    {
        Highlighted = false;
    }

    public void StartContol()
    {
        ctrl = true;
        if (Highlighted)
        {
            this.enabled = false;
        }
        else
        {
            foreach (__Pin_Controller p in FindObjectsOfType<__Pin_Controller>())
                p.UnHighlight();
            Highlighted = true;
        }
    }

    public void EndControl()
    {
        ctrl = false;
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
                transform.eulerAngles = new Vector3(0, 0, Vector3.Angle(Input.GetTouch(0).position, Input.GetTouch(1).position));
            }
        }
    }
}
