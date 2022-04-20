using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  
    //public GameObject[] characters;
    //public Transform playerStartPosition;
    public string menuScene = "PlayerSelect";
    private string selectedCharacterName = "SelectedCharacter";
    //int selectedCharater;
    //public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //selectedCharater = PlayerPrefs.GetInt(selectedCharacterName, 0);
        //playerObject = Instantiate(characters[selectedCharater], playerStartPosition.position,characters[selectedCharater].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void SelectCharacter()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(menuScene);
    }
}
