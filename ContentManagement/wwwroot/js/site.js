
// Write your Javascript code.
let images = document.getElementsByClassName('high');
let imagesLen = images.length;
let attribute = 'marked';
let oldAttribute = '';

// loop through each image and and addEventListener for each one
for (var i = 0; i < imagesLen; i++) {
    images[i].addEventListener('click', function () {
        resetBorder();
        addBorderTo(this);
    });
}


// make a new loop for each click and reset images by it
function resetBorder() {

    for (var v = 0; v < imagesLen; v++) {
        images[v].style.border = '';
        if (images[v].hasAttribute('id')) {
            images[v].removeAttribute('id')
            images[v].style.paddingBottom = '0.2em';
        }
    }
}

function addBorderTo(thisImage) {
    thisImage.style.border = '2px solid #0293fc';
    thisImage.setAttribute('id', attribute);
    thisImage.style.paddingBottom = '0em'
}

function setImg(id) {
    let element = document.getElementById(id);
    oldAttribute = element.id;
    element.setAttribute('id', 'picked');

}

// #region functions, crud code and logic for sponsor images

//  #EndRegion