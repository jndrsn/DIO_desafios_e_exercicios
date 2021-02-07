const dino = document.querySelector('.dino');
const background = document.querySelector('.background');
let isJumping = false;
let position = 0;

function handleKeyUp(event){
    if(event.keyCode === 32){
        if(!isJumping){
            jump();
        }
    }
}
// Movimentação Dinossauro
function jump(){
  
    isJumping = true;
    let upInternal = setInterval(() => {    
        if(position>=150){
           clearInterval(upInternal);
          let downInterval = setInterval(() =>{  
            if(position <= 0){
                clearInterval(downInterval);
                isJumping = false;
            }else{ 
                //descendo
                position -= 20;      
                dino.style.bottom = position + 'px';
            }
          },20);   
        }else{
            //subindo
           position += 20;
           dino.style.bottom = position + 'px';
       }
    }, 20);
}

//Movimentação Cactus
function createCactus(){
    const cactus = document.createElement('div');
    let cactusPosition = 1000;
    let randomTime = Math.random()*6000;
    
    cactus.classList.add('cactus');
    cactus.style.left = 1000 + 'px';
    background.appendChild(cactus);

    let leftInterval = setInterval(() => {
        if(cactusPosition < -60){
            clearInterval(leftInterval);
            background.removeChild(cactus);
        }else if(cactusPosition>0 && cactusPosition<60 && position < 60){
            //Gamer Over
            clearInterval(leftInterval);
            document.body.innerHTML = '<h1 class="gamer-over"> Fim do Jogo</h1>'
        }else{
            cactusPosition -= 10;
            cactus.style.left = cactusPosition + 'px';
        }
    },20);

    setTimeout(createCactus, randomTime);

}
createCactus();
document.addEventListener('keyup', handleKeyUp);