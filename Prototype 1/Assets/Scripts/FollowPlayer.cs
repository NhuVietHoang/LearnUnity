using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Vector3 offset = new Vector3();

    // Bắt đầu được gọi trước khi cập nhật khung hình đầu tiên
    void Start()
    { }

    // Cập nhật được gọi một lần trên mỗi khung hình
    void Update()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}
