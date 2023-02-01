/* Complete the JavaScript functions below to complete the snowman scene. For the automated testing to work correctly, set the specified properties and call the specified functions in the order given below:

drawSnowText() should display the string "SNOW" using:

font: 80px Verdana
textAlign: center
textBaseline: top
fillStyle: blue
fillText() to display the text at coordinate (canvas.width / 2, 10)
drawSnowman() should display three white circles using:

Bottom circle: arc() centered at (150, 200) with radius 50 that begins at 0 and ends at Math.PI * 2
Middle circle: arc() centered at (150, 120) with radius 40 that begins at 0 and ends at Math.PI * 2
Top circle: arc() centered at (150, 60) with radius 25 that begins at 0 and ends at Math.PI * 2
All three circles should use fillStyle white and be displayed with the fill() function
drawSingleFlake() should display a single white snowflake in the shape of a diamond using the constant flakeSize and the following:

moveTo() with coordinate (x, y)
lineTo() with coordinate (x + flakeSize / 2, y + flakeSize / 2)
lineTo() with coordinate (x, y + flakeSize)
lineTo() with coordinate (x - flakeSize / 2, y + flakeSize / 2)
fillStyle: white
fill() to display the diamond */
// Size of a single snowflake
const flakeSize = 8;

window.addEventListener("DOMContentLoaded", function() {
   var canvas = document.querySelector("canvas");
   
   drawGround(canvas);
   drawSnowText(canvas);
   drawSnowman(canvas);  
   drawSnowflakes(canvas);   
});

function drawGround(canvas) {
   var context = canvas.getContext("2d");

   // background 
   context.fillStyle = "lightgray";
   context.fillRect(0, 0, 300, 300);

   // ground
   context.fillStyle = "brown";
   context.fillRect(0, canvas.height - 50, canvas.width, canvas.height);
}

function drawSnowflakes(canvas) {   
   for (var c = 0; c < 100; c++) {
      var x = Math.floor(Math.random() * canvas.width);
      var y = Math.floor(Math.random() * canvas.height);
      drawSingleFlake(canvas, x, y);
   }
}

// Complete the functions below

function drawSnowText(canvas) {
let context = canvas.getContext("2d");
context.font = "80px Verdana";
context.textAlign = "center"; 
context.textBaseline = "top";
context.fillStyle = "blue";
context.fillText("SNOW", canvas.width / 2 , 10);
}


function drawSnowman(canvas) { 
// Aquamarine semicircle
let context = canvas.getContext("2d");
context.beginPath();
context.arc(150, 200, 50, 0, Math.PI * 2);
context.fillStyle = "white";
context.fill();
context.closePath();

context.beginPath();
context.arc(150, 120, 40, 0, Math.PI * 2);
context.fillStyle = "white";
context.fill();
context.closePath();

context.beginPath();
context.arc(150, 60, 25, 0, Math.PI * 2);
context.fillStyle = "white";
context.fill();
context.closePath();
}

function drawSingleFlake(canvas, x, y) {
let context = canvas.getContext("2d");

//context.beginPath();
context.moveTo(x, y);
context.lineTo(x + flakeSize/2, y + flakeSize/2);
context.lineTo(x,y+flakeSize);
context.lineTo(x - flakeSize/2, y + flakeSize/2);
context.fillStyle = "white";
context.fill();
context.closePath();


}
