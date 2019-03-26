using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpawnInsectScript : MonoBehaviour, IVirtualButtonEventHandler {

    public TrackableBehaviour theTrackable;
    public GameObject vButtonObj2;
    public GameObject prefabMoth;
    public GameObject prefabGnat;

    void Start () {
        vButtonObj2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Insect newbug;

        if (Random.value > 0.5f)
        {
            newbug = new Moth();                        // create new instance of flying insect
            newbug.SpawnSelf(prefabMoth, theTrackable); // spawn prefab so we can see this new bug
        }
        else
        {
            newbug = new Gnat();                        // create new instance of flying insect
            newbug.SpawnSelf(prefabGnat, theTrackable); // spawn prefab so we can see this new bug
        }

        CreatureManagerScript.AddCreature(newbug);            // creature manager keeps track of all bugs
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) { }
}
