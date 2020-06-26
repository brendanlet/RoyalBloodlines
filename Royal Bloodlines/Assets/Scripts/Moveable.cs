using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : MonoBehaviour
{
    public Transform mainTransform;

    private Collider2D grabBox;

    private Vector3 grabOffset;

    private Vector3 refPointOnScreen;


    private void OnMouseDown()
    {
        refPointOnScreen = Camera.main.WorldToScreenPoint(mainTransform.position);
        grabOffset = mainTransform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, refPointOnScreen.z));

    }

    void OnMouseDrag()
    {

        Vector3 curPointOnScreen= new Vector3(Input.mousePosition.x, Input.mousePosition.y, refPointOnScreen.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curPointOnScreen) + grabOffset;
        mainTransform.position = curPosition;



    }
}
