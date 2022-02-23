using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterController : MonoBehaviour
{
    [TextArea(3, 10)]
    [SerializeField] string posterText;
    public string GetText()
    {
        return posterText;
    }
}
