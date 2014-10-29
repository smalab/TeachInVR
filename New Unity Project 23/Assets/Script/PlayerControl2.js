#pragma strict

function OnControllerColliderHit(hit:ControllerColliderHit){
	 var obj = hit.gameObject;	 
	 Debug.Log(obj.name);           
	if (obj.name == 'RefreshArea'){ 
		Debug.Log("hit");
		Application.LoadLevel('JumpMan01');
	}
}
	