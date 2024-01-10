using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorsorManager : MonoBehaviour
{
    void Start()
    {
        // Unlock and show the cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
