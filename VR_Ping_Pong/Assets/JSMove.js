

var positionXOrigin;
var positionYOrigin;
var positionZOrigin;
var positionX;
var positionY;
var positionZ;

function Start () {
    positionXOrigin = transform.position.x;
    positionYOrigin = transform.position.y;
    positionZOrigin = transform.position.z;

}

var movedownY = 0.0;
var sensitivityY = 0.25;
var movedownX = 0.0;
var maxDifference = 10;

function Update() {
    movedownX += Input.GetAxis("Mouse X") * sensitivityY;
    movedownY += Input.GetAxis("Mouse Y") * sensitivityY;
    
    //positionX = Math.abs(transform.position.x);
    //positionY = Math.abs(transform.position.y);
    //positionZ = Math.abs(transform.position.z);

    //if(positionX < (parseInt(positionXOrigin) + maxDifference)){
        if (Input.GetAxis("Mouse X") > 0){
            transform.Translate(Vector3.right * movedownX);
        }
        if (Input.GetAxis("Mouse X") < 0){
            transform.Translate(Vector3.right * movedownX);
        }
    //}

   // if(positionY < (parseInt(positionYOrigin) + maxDifference)){

        if (Input.GetAxis("Mouse Y") > 0){
            transform.Translate(Vector3.up * movedownY);
        }
        if (Input.GetAxis("Mouse Y") < 0){
            transform.Translate(Vector3.up * movedownY);
        }
   // }
    movedownY = 0.0;
    movedownX = 0.0;
}