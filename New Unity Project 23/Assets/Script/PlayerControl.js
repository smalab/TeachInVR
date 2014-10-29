#pragma strict
private var itemFlg = false;
private var clearFlg = false;

function OnControllerColliderHit(hit : ControllerColliderHit){
var obj = hit.gameObject;

var player = hit.controller.gameObject;

Debug.Log(obj.name);
if(obj.name == "RefreshArea"){
Application.LoadLevel("JumpMan01");
}

if(obj.name == "FirePlug" && itemFlg == true){
			var objWater = GameObject.Find ("Water Fountain");
			var compPartRend = objWater.GetComponent(ParticleRenderer);
			compPartRend.enabled = false;
			clearFlg = true;

	}
if(obj.name == "Item"){
itemFlg = true;
Destroy(obj);
var objWrench = player.Find("wrench");
var compMeshRend = objWrench.GetComponent(MeshRenderer);
compMeshRend.enabled = true;
}

if(obj.name == "Start" && clearFlg == true){
Application.LoadLevel("JumpMan_clear");
}
}