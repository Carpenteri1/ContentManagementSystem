// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
let images = document.getElementsByClassName('high');
let imagesLen = images.length;
let attribute = 'marked';

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
        }
    }
}

function addBorderTo(thisImage) {
    thisImage.style.border = '4px solid #00f';
    thisImage.setAttribute('id', attribute);
}





