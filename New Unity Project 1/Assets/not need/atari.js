#pragma strict

function Start () {

}

function Update () {

}
function OnCollisionEnter(obj : Collision){
if(obj.gameObject.name == "Cube1"){
print("aaaaa");
}
if(obj.gameObject.name == "sapporo_yuka"){
print("sapporo");
}
}