using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnloadScene : MonoBehaviour
{
	public Button UnloadButton;

	void Start()
	{
		Button btn_unload = UnloadButton.GetComponent<Button>();
		btn_unload.onClick.AddListener(OnClick);

	}

	void OnClick()
	{

		//Debug.Log(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(1, LoadSceneMode.Single);
		//SceneManager.UnloadSceneAsync("Landing_Scene");
		//AsyncOperation op = SceneManager.LoadSceneAsync(1);
	}
}
