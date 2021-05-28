using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InterationMove : MonoBehaviour,IPointerClickHandler
{
	public GameObject move;
	private int max=3;
    private double distanceX=12.72;
    private GameObject[] slices;
    public GameObject slice1;
    public GameObject slice2;
    public GameObject slice3;
    public GameObject slice4;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("img",0);
        slices=new GameObject[4];
        slices[0]=slice1;
        slices[1]=slice2;
        slices[2]=slice3;
        slices[3]=slice4;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    	var i=PlayerPrefs.GetInt("img");
    	if(move.CompareTag("back")){
    		if(i>0){
                i-=1;
    		}else{
                i=3;
            }
    	}else if(move.CompareTag("forward")){
    		if(i<max){
    			i+=1;	
    		}else{
                i=0;
            }
    	}
    	PlayerPrefs.SetInt("img",(i));
        moveSlices(i);
    }

    void moveSlices(int index){
    	for(int i=0;i<4;i++){
    		if(i==index){
                slices[i].SetActive(true);
            }else{
                slices[i].SetActive(false); 
            }
    	}
    }
}
