using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag1 : MonoBehaviour
{
   void OnMouseDrag()
    {
        Vector2 pos = Input.mousePosition;
        Vector3 objpos = Camera.main.ScreenToViewportPoint(new Vector3(pos.x, pos.y, 1f));
        transform.position = objpos;

    }
}
