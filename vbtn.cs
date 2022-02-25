using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtn : MonoBehaviour
{
    bool initial = true;
    public GameObject primaryText;
    public GameObject review;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(Toggle);
        primaryText.SetActive(initial);
        review.SetActive(!initial);
    }

    // Update is called once per frame
    public void Toggle(VirtualButtonBehaviour vb)
    {
        initial = !initial;
        primaryText.SetActive(initial);
        review.SetActive(!initial);
    }
}
