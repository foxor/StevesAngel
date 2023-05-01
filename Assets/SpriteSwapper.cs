using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwapper : MonoBehaviour
{
    public float interval;
    public SpriteRenderer r;
    public Sprite[] sprites;
    protected float residual;
    protected int index;
    public void Update() {
        residual -= Time.deltaTime;
        if (residual <= 0f) {
            residual += interval;

            index = (index + 1) % sprites.Length;
            r.sprite = sprites[index];
        }
    }
}
