using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface DragDropHandler : IEventSystemHandler
{
    void HandleGazeTriggerStart();
    void HandleGazeTriggerEnd();

}
