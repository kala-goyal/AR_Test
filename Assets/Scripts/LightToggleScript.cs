using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class LightToggleScript : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vButtonObj;
    public GameObject myGraphic;

    private bool _onOff = false;

	void Start () {
        vButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        SetState();
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        _onOff = !_onOff;
        SetState();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) { }

    void SetState()
    {
        myGraphic.SetActive(_onOff);
        CreatureManagerScript.ChangeLightState(_onOff);
    }
}
