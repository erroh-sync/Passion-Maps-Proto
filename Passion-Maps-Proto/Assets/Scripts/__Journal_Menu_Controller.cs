using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class __Journal_Menu_Controller : __God_Object{
    
    public __Pin_Controller SelectedPassionPin;

    public __God_Object AddEntryPage;
    public InputField HeaderEntry;
    public InputField ContentEntry;

    public __God_Object ViewEntryPage;

    public GameObject ListParent;
    public List<GameObject> ListObjects = new List<GameObject>();
    public GameObject ListPrefab;

    public void CloseMenu()
    {
        this.enabled = false;
    }

    protected override void OnEnable()
    {
        base.OnEnable();

        foreach (GameObject g in ListObjects)
        {
            Destroy(g);
        }

        RepopulateList();
    }

    public void OpenAddEntryPage()
    {
        AddEntryPage.enabled = true;
    }

    public void CloseAddEntryPage()
    {
        HeaderEntry.text = "";
        ContentEntry.text = "";

        AddEntryPage.enabled = false;
    }

    public void OpenViewEntryPage()
    {
        ViewEntryPage.enabled = true;
    }

    public void CloseViewEntryPage()
    {
        ViewEntryPage.enabled = false;
    }

    public void RepopulateList()
    {
        foreach(GameObject g in ListObjects)
        {
            Destroy(g);
        }

        ListObjects.Clear();

        for(int i = 0; i < SelectedPassionPin.JournalEntries.Count; i++)
        {
            GameObject lo = Instantiate(ListPrefab, ListParent.transform);
            lo.transform.position += new Vector3(0, -(70 * i), 0);
            lo.GetComponent<__Journal_Entry>().data = SelectedPassionPin.JournalEntries[i];
            ListObjects.Add(lo);
        }
    }

    public void AddEntry()
    {
        __Pin_Journal_Data newDat;

        newDat.Heading = HeaderEntry.text;
        newDat.Content = ContentEntry.text;

        SelectedPassionPin.JournalEntries.Add(newDat);

        RepopulateList();

        CloseAddEntryPage();
    }
}
