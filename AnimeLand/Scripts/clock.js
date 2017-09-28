setInterval(function(){NtTime();},1000);
 function startTime()
 {
 var tm=new Date();

document.getElementById("hos").innerHTML=checkTime(tm.getHours());
document.getElementById("mis").innerHTML=checkTime(tm.getMinutes());
document.getElementById("ses").innerHTML=checkTime(tm.getSeconds());
shake_(ses);
 }

function NtTime()
{
var tm_ = new Date();
var hours = checkTime(tm_.getHours());
var minutes = checkTime(tm_.getMinutes());
var seconds = checkTime(tm_.getSeconds());	
if (document.getElementById('ses').innerHTML != (seconds) ){
     shake_(ses);     
 }
if (document.getElementById('hos').innerHTML != (hours)){
     shake(hos);     
  }
if (document.getElementById('mis').innerHTML != (minutes)){
     shake(mis);     
  }

document.getElementById("hos").innerHTML=hours;
document.getElementById("mis").innerHTML=minutes;
document.getElementById("ses").innerHTML=seconds;
}
function shake(t) {	
  t.classList.add("shake_cl");
  setTimeout(function() {
  t.classList.remove("shake_cl");
  },2000)
}
function shake_(t){
  t.classList.add("shake_s");
  setTimeout(function() {
  t.classList.remove("shake_s");
  },900)
}
 function checkTime(i)
 {
 if (i<10)
 {
 i="0" + i;
 }
 return i;
 }