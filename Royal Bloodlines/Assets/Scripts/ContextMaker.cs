using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMaker : MonoBehaviour
{
    public Transform contextMenu;
    public List<Transform> menuItems;
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1) && !Input.GetMouseButton(0))
        {
            foreach(Transform child in contextMenu)
            {
                Destroy(child.gameObject);
            }

            foreach (Transform item in menuItems)
            {
                Transform _item = Instantiate(item, Vector3.zero, Quaternion.identity);
                _item.SetParent(contextMenu, false);
            }

            Vector3 contextOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            contextOrigin.z = 0;

            contextMenu.position = contextOrigin;


            contextMenu.gameObject.SetActive(true);
            
        }
    }


}
