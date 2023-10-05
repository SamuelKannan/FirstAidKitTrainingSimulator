using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject correctItem;
    public GameObject wrongItem1;
    public GameObject wrongItem2;
    public GameObject targetItem;
    public GameObject myHand;
    public GameObject nextQuestion;
    public GameObject correctText;

    bool inHands = false;
    bool inPlace = false;
    Vector3 correctItemStartPos;
    Quaternion correctItemStartRot;
    Vector3 wrongItem1StartPos;
    Quaternion wrongItem1StartRot;

    Vector3 wrongItem2StartPos;
    Quaternion wrongItem2StartRot;
    void Start()
    {
        correctItemStartPos = correctItem.transform.position;
        correctItemStartRot = correctItem.transform.rotation;
        wrongItem1StartPos = wrongItem1.transform.position;
        wrongItem1StartRot = wrongItem1.transform.rotation;
        wrongItem2StartPos = wrongItem2.transform.position;
        wrongItem2StartRot = wrongItem2.transform.rotation;

    }
    // Update is called once per frame
    public void DragCorrectItem()
    {
        if (!inHands)
        {
            correctItem.transform.SetParent(myHand.transform);
            correctItem.transform.localPosition = new Vector3(myHand.transform.localPosition.x, myHand.transform.localPosition.y, myHand.transform.localPosition.z + 1.5f);
            inHands = true;
        }
        else if (inHands)
        {
            correctItem.transform.SetParent(null);
            correctItem.transform.localPosition = targetItem.transform.position + new Vector3(0, 0.01f,0);
            correctItem.transform.localRotation = targetItem.transform.rotation;
            nextQuestion.gameObject.SetActive(true);
            correctText.gameObject.SetActive(true);
            inHands = false;
        }
    }

    public void DragWrongItem1()
    {
        if (!inHands)
        {
            wrongItem1.transform.SetParent(myHand.transform);
            wrongItem1.transform.localPosition = new Vector3(myHand.transform.localPosition.x, myHand.transform.localPosition.y, myHand.transform.localPosition.z + 1.5f);
            inHands = true;
        }
        else if (inHands)
        {
            wrongItem1.transform.SetParent(null);
            wrongItem1.transform.localPosition = wrongItem1StartPos;
            wrongItem1.transform.localRotation = wrongItem1StartRot;
            inHands = false;
        }
    }

    public void DragWrongItem2()
    {
        if (!inHands)
        {
            wrongItem2.transform.SetParent(myHand.transform);
            wrongItem2.transform.localPosition = new Vector3(myHand.transform.localPosition.x, myHand.transform.localPosition.y, myHand.transform.localPosition.z + 1.5f);
            inHands = true;
        }
        else if (inHands)
        {
            wrongItem2.transform.SetParent(null);
            wrongItem2.transform.localPosition = wrongItem2StartPos;
            wrongItem2.transform.localRotation = wrongItem2StartRot;
            inHands = false;
        }
    }

    public void DragOintmentOrMedTape()
    {
        if (!inHands)
        {
            correctItem.transform.SetParent(myHand.transform);
            correctItem.transform.localPosition = new Vector3(myHand.transform.localPosition.x, myHand.transform.localPosition.y, myHand.transform.localPosition.z + 1.5f);
            inHands = true;
        }
        else if (inHands)
        {
            correctItem.transform.SetParent(null);
            correctItem.transform.localPosition = correctItemStartPos;
            correctItem.transform.localRotation = correctItemStartRot;
            nextQuestion.gameObject.SetActive(true);
            correctText.gameObject.SetActive(true);
            inHands = false;
        }
    }

}
