using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel ("Gameplay");
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
