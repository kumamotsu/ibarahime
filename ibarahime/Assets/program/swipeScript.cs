/////////////////////////////////////////
//
//
//		Unity2017.3.1f用にリテイク
//
//
/////////////////////////////////////////

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class swipeScript : MonoBehaviour {

  public float StartPos;
  public float EndPos;

  Camera mainCamera;

  void Start(){
      mainCamera = GameObject.Find("MainCamera").GetComponent<Camera> ();
  }
  void Update () {

    if (Input.GetMouseButtonDown (0)) {
            StartPos = mainCamera.ScreenToWorldPoint (Input.mousePosition).x;
        }
        if (Input.GetMouseButtonUp (0)) {
            EndPos = mainCamera.ScreenToWorldPoint (Input.mousePosition).x;
            if (StartPos > EndPos) {
                mainCamera.transform.position = new Vector3 (mainCamera.transform.position.x + 10, mainCamera.transform.position.y, -10);
            }else if (StartPos < EndPos) {
                mainCamera.transform.position = new Vector3 (mainCamera.transform.position.x - 10, mainCamera.transform.position.y, -10);
            }
            StartPos = 0;
            EndPos = 0;
        }
    }
}
