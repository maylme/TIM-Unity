 using UnityEngine;
 using UnityEngine.EventSystems;
 
 public class LeftButton : MonoBehaviour
     , IPointerDownHandler
     , IPointerUpHandler
 {
 	private bool rotate = false;

 	public void Update(){
 		if(rotate == true){
            Camera.main.transform.Rotate(Vector3.up, -5);
 		}
 	}

     public void OnPointerDown(PointerEventData eventData) 
     {
         rotate = true;
     }

     public void OnPointerUp(PointerEventData eventData) 
     {
         rotate = false;
     }
 }