/* a function to great the user
 this function shows 2 alerts */
"use strict";

let message = 'Hello';
let age = 25;
let user = 'Mostafa';

const COLOR_RED = "#F00";
const COLOR_GREEN = "#0F0";
const COLOR_BLUE = "#00F";
const COLOR_ORANGE = "#FF7F00";



function salem3laUser() {
    //alert("Ezayak ya User ?");
    //alert(" 3amel eeh ?");
    alert(message);
    COLOR_BLUE = "#FFF";
}

function salemTany() {    
    alert(
        //message + ' يا '
        //+ user + ' سنك  '
        //+ age + ' سنة '
        `${message} ${user} your age is : ${age}`
        );    
}