using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindMoveMent : MonoBehaviour
{
    [SerializeField] private RawImage _img2;
    [SerializeField] private float _x, _y;
    void Update()
    {
        _img2.uvRect = new Rect(_img2.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img2.uvRect.size);
    }
}
