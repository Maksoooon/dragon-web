using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPicker : MonoBehaviour
{
    public int goToLevel;
    
    public void LEVEL()
    {
        SceneManager.LoadScene( goToLevel);
    }
}
