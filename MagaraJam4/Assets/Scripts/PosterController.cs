using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterController : MonoBehaviour
{
    [SerializeField] string posterText;
    public string GetText()
    {
        return posterText;
    }
}
