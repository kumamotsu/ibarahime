using UnityEngine;
 using System.Collections;
 using UnityEngine.SceneManagement;

public class changeScreen : MonoBehaviour {

public void SelectStage0()
 {
 SceneManager.LoadScene("projects/main");
 }

public void SelectStage1()
 {
 SceneManager.LoadScene("projects/sub00");
 }

public void SelectStage2()
 {
 SceneManager.LoadScene("projects/sub01");
 }

public void SelectStage3()
 {
 SceneManager.LoadScene("projects/sub02");
 }

public void SelectStage4()
 {
 SceneManager.LoadScene("projects/sub03");
 }

}
