using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class __Journal_Entry : MonoBehaviour {

    public __Pin_Journal_Data data;

    public Text title;
    public Text content;

    // Update is called once per frame
    void Update () {
        title.text = data.Heading;
        content.text = data.Content;
    }
}
