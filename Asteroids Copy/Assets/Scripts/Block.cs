using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static GameManager;

public class Block : MonoBehaviour
{
    public Vector2 Pos => transform.position;
    public int Value;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private TextMeshPro _text;
    public void Init(BlockType type)
    {
        Value = type.Value;
        _renderer.color = type.Color;
        _text.text = type.Value.ToString();
    }

   
}