 using UnityEngine;
 using UnityEngine.EventSystems;
 
 public class TopButton : MonoBehaviour
     , IPointerDownHandler
     , IPointerUpHandler
 {
 	private bool move = false;

 	public void Update(){
 		if(move == true){
            Camera.main.transform.Translate(0, 0, 0.2f);
 		}
 	}

     public void OnPointerDown(PointerEventData eventData) 
     {
         move = true;
     }

     public void OnPointerUp(PointerEventData eventData) 
     {
         move = false;
     }
 }