using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __Pin_Menu_Controller : __God_Object
{
    [SerializeField]
    private __Pin_Controller OwningPin;

    public void Func01()
    {
        if (enabled)
        {
            this.enabled = false;
        }
    }

    public void Func02()
    {
        if (enabled)
        {
            this.enabled = false;
        }
    }

    public void Func03() // Opens the Journal
    {
        if (enabled)
        {
            // Enable the menu and set our owning pin to it's active pin
            __Journal_Menu_Controller m = FindObjectOfType<__Journal_Menu_Controller>();

            if (m.enabled)
                m.enabled = false;
            else
            {
                m.SelectedPassionPin = OwningPin;
                m.enabled = true;
            }

            this.enabled = false;
        }
    }

    public void Func04()
    {
        if (enabled)
        {
            this.enabled = false;
        }
    }
}
