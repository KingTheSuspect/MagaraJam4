using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set;}

    private void Awake()
    {
        Instance = this;
    }
    public Sprite cips1;
    public Sprite cips2;
    public Sprite cips3;
    public Sprite kola1;
    public Sprite kola2;
}
