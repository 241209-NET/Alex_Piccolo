
function buttonHandler(){
    console.log("Alex says hello world"); 
}

function seymourButton(){
    const newImage = document.createElement('img'); 
    newImage.src = "C:/Users/ajpic/OneDrive/Documents/Desktop/24012-NET/Alex_Piccolo/HTML/Images/Feed Me Seymour.webp"; 
    const ul = document.getElementById('img-div'); 
    ul.appendChild(newImage); 
}

function specialButton(){
    document.body.style.backgroundColor="red"; 
    console.log("Uh oh, what did you DO?!")
}
