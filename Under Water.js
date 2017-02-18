#pragma strict
var waterLevel : float;
private var isUnderWater : boolean;
private var normalColor : Color;
private var UnderWaterColor : Color;
function Start () {
	normalColor = new Color (0.5f,0.5f,0.5f,0.5f);
	UnderWaterColor = new Color (0.22f,0.65f,0.77f,0.5f);
}

function Update () {
	if ((transform.position.y < waterLevel) != isUnderWater){
	isUnderWater = transform.position.y < waterLevel;
	if(isUnderWater) 
		SetUnderWater();
	if(!isUnderWater) SetNormal();
	}
}
function SetNormal(){
RenderSettings.fogColor = normalColor;
RenderSettings.fogDensity = 0.002f;
}

function SetUnderWater(){
RenderSettings.fogColor = UnderWaterColor;
RenderSettings.fogDensity = 0.03f;
}