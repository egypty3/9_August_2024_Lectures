let timerId;

function clockStart() {
   timerId =  setInterval(update, 1000);
}

function clockStop() {
    clearInterval(timerId);

    document.querySelector('.hour').innerHTML = 'hh';
    document.querySelector('.min').innerHTML = 'mm';
    document.querySelector('.sec').innerHTML = 'ss';
    document.querySelector('.am-pm').innerHTML = 'am/pm';
}

function update() {
    let clock = document.getElementById('clock');
    let date = new Date();
    let hours = date.getHours();

    let am_pm = (hours > 12) ? 'pm' : 'am';

    if (am_pm == 'pm') {
        hours =  hours -12;
    }

    if (hours < 10) {
        hours = '0' + hours;
    }



    //document.querySelector('.hour').innerHTML = hours;
    clock.children[0].innerHTML = hours;

    let minutes = date.getMinutes();
    if (minutes < 10) {
        minutes = '0' + minutes;
    }
    //document.querySelector('.min').innerHTML = minutes;
    clock.children[1].innerHTML = minutes;

    let seconds = date.getSeconds();
    if (seconds < 10) {
        seconds = '0' + seconds;
    }
    //document.querySelector('.sec').innerHTML = seconds;
    clock.children[2].innerHTML = seconds;

    clock.children[3].innerHTML = am_pm;

    //document.querySelector("#clock input[type='button']").value =
    //    "Ezayak ya Hamza";
    //console.log(hours);
}