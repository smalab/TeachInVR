#pragma strict

function Start () {

}

function Update () {

}
function OnCollisionEnter(obj : Collision){
if(obj.gameObject.name == "Cube1"){
print("aaaaa");
}
}