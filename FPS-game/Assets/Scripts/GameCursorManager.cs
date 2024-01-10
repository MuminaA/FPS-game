using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCursorManager : MonoBehaviour
{
    void Start()
    {
        // Unlock and show the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
