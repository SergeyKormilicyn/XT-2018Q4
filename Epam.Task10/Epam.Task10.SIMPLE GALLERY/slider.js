var repeat;
function init(){
    sec = 5;
    repeat = setInterval(tick, 1000);
}

function tick(){
    if(sec === 1){
        changePage('next');
    }
    sec--;
    document.getElementById("timer").childNodes[0].nodeValue = sec;
}

function setPause(mode){
    if(mode == 'stop'){
        clearInterval(repeat);
    }
    if(mode == 'play'){
        repeat = setInterval(tick, 1000);
    }
}