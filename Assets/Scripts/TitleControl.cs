using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleControl : MonoBehaviour
{
    public Button NormalButton;
    public Button VRButton;

    // Use this for initialization
    void Start ()
    {
        NormalButton.onClick.AddListener(OnNormalButtonClick);
        VRButton.onClick.AddListener(OnVRButtonClick);
    }
	
	private void OnNormalButtonClick()
    {
        // ....
        SceneManager.LoadScene("MainScene");
    }

    private void OnVRButtonClick()
    {
        // ....
        SceneManager.LoadScene("MainScene");
    }
}
