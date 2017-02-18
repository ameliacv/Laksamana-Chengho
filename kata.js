#pragma strict

var letterPause = 0.2;
var mytext : String;


function Start () {
	mytext = "Laksamana Chengho Adalah Salah Satu \n Tokoh Islam yang Sangat berperan Penting \n Dalam kemajuan Islam di Nusantara"+
	"\n Beliau adalah seorang Penjelajah laut yang Sangat terkenal \n\n Temukan Harta Karun Untuk Memulai Permainan \n Temukan Kotak Pertanyaan Pada Masing2 Level";
	TypeText();

}

function TypeText () {
	for (var letter in mytext.ToCharArray()){
		guiText.text += letter;
		
		yield WaitForSeconds(letterPause);
	}
	guiText.enabled=false;
}