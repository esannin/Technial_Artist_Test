using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
	public Button MyPlayButton;

	void Start()
	{
		Button btn_play = MyPlayButton.GetComponent<Button>();
		btn_play.onClick.AddListener(TaskOnClick);

	}

	void TaskOnClick()
	{
		
		Debug.Log(SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(1, LoadSceneMode.Additive);
		//SceneManager.UnloadSceneAsync("Unity_UI_Test");
	}

}