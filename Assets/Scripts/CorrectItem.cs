using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectItem : MonoBehaviour
{
    public GameObject gauzePad;
    public GameObject ointment;
    public GameObject medTape;
    public GameObject myHand;
    public GameObject targetItem;
    public GameObject nextQuestion;

    bool inHands = false;
    Vector3 gauzePadStartPos;
    Quaternion gauzePadStartRot;
    Vector3 ointmentPos;
    Quaternion ointmentRot;
    Vector3 medTapePos;
    Quaternion medTapeRot;
    void Start()
    {
        gauzePadStartPos = gauzePad.transform.position;
        gauzePadStartRot = gauzePad.transform.rotation;
        ointmentPos = ointment.transform.position;
        ointmentRot = ointment.transform.rotation;
        medTapePos = medTape.transform.position;
        medTapeRot = medTape.transform.rotation;  
    }
 
    public void DragGauzePad()
    {
        if (!inHands)
        {
            gauzePad.transform.SetParent(myHand.transform);
            gauzePad.transform.localPosition = new Vector3(myHand.transform.localPosition.x, myHand.transform.localPosition.y, myHand.transform.localPosition.z + 1.5f);
            inHands = true;
        }
        else if (inHands)
        {
            gauzePad.transform.SetParent(null);
            gauzePad.transform.localPosition = gauzePadStartPos + new Vector3(0, 0.01f,0);
            gauzePad.transform.localRotation = gauzePadStartRot;
            inHands = false;
        }      
    }
    public void DragOintment()
    {
        if (!inHands)
        {
            ointment.transform.SetParent(myHand.transform);
            ointment.transform.localPosition = new Vector3(myHand.transform.localPosition.x, myHand.transform.localPosition.y, myHand.transform.localPosition.z + 1.5f);
            inHands = true;
        }
        else if (inHands)
        {
            ointment.transform.SetParent(null);
            ointment.transform.localPosition = ointmentPos;
            ointment.transform.localRotation = ointmentRot;
            inHands = false;
        }      
    }
    public void DragMedTape()
    {
        if (!inHands)
        {
            medTape.transform.SetParent(myHand.transform);
            medTape.transform.localPosition = new Vector3(myHand.transform.localPosition.x, myHand.transform.localPosition.y, myHand.transform.localPosition.z + 1.5f);
            inHands = true;
        }
        else if (inHands)
        {
            medTape.transform.SetParent(null);
            medTape.transform.localPosition = medTapePos;
            medTape.transform.localRotation = medTapeRot;
            inHands = false;
        }      
    }
}


