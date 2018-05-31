using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour {

    //public void OnClickStartButton(string msg)
    public void OnClickStartButton(RectTransform rt)
    {
        Debug.Log("Scale X: " + rt.localScale.x.ToString());
    }
}
