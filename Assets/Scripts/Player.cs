using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private string playerName;

    public float moveRange;
    public float pushRange;

    public float moveSpeed;


    [SerializeField]
    private float crouchSpeed;
    private float applySpeed;
    [SerializeField]
    private float jumpForce;

    // ���� ����
    private bool isWalk = false;
    public bool isRun = false;
    private bool isCrouch = false;
    private bool isGround = true;

    // ������ üũ ����
    private Vector3 lastPos;

}
