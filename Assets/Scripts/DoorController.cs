using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator DoorOpen;

    private void Start()
    {
        DoorOpen = gameObject.GetComponent<Animator>();
        GameEvents.current.onDoorwayTriggerEnter += OnDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit += OnDoorwayClose;
    }

    private void OnDoorwayOpen()
    {
        DoorOpen.SetBool("DoorOpen", true);
    }
    private void OnDoorwayClose()
    {
        DoorOpen.SetBool("DoorOpen", false);
    }
}
