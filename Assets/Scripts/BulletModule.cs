using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModule : MonoBehaviour
{
  
    public float speed;

    

    private void FixedUpdate()
    {   // 화면의 맨 끝 y 좌표 + 이미지 크기
        if (transform.localPosition.y > 1f + 0.05f)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            transform.Translate(0, speed, 0);
        }
    }

}
