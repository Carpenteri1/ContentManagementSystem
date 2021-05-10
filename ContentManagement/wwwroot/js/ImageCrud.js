function pickSponsorImage(id) {
    let thisImage = document.getElementById(id).src;
    document.getElementById("SponsorImage").src = thisImage;

    let hostname = location.origin;
    let pathname = location.search;
    let data = { imgsrc: thisImage, id: pathname, domain: hostname };
    $.ajax({
        url: '/Adverts/SetImage',
        type: "post",
        contentType: 'application/x-www-form-urlencoded',
        data: data,
        success: function (result) {
            console.log(result);
        }
    });
}

function deletSponsorImage() {
    let thisImage = document.getElementById(attribute).src;//image with border
    let hostname = location.origin;
    let pathname = location.search;
    let data = { imgsrc: thisImage, id: pathname, domain: hostname };
    $.ajax({
        url: '/Adverts/DeleteImage',
        type: "post",
        contentType: 'application/x-www-form-urlencoded',
        data: data,
        success: function (result) {
            console.log(result);
            location.reload()//TODO try get data from db context or store old data and past it in again after reload.
        }
    })
}

function setSponsorImage() {
    let formData = new FormData();
    let file = $("#UploadAdd").prop('files')[0];
    let pathname = location.search;
    formData.append("file", file);
    formData.append("id", pathname)
    $.ajax({
        url: '/Adverts/UploadImage',
        type: "POST",
        enctype: 'multipart/form-data',
        data: formData,
        contentType: false,
        processData: false,
        success: function (response) {
            location.reload()//TODO try get data from db context or store old data and past it in again after reload.
        }
    })
}

function postSponsorImage(url) {

    let newAdvert = new Array();
    newAdvert[0] = $('#AdvertLinkTitle').val();
    newAdvert[1] = $('#AdvertLinkTo').val();
    newAdvert[2] = $('#AdvertIsActive').val();
    newAdvert[3] = $('#AdvertSeletecDropDown').val();
    newAdvert[4] = $('#SponsorImage').prop('src');
    newAdvert[5] = location.origin;
    newAdvert[6] = $('#hiddeforAdvertId').val();

    let postData = { values: newAdvert };
    $.ajax({
        type: "POST",
        url: url,
        data: postData,
        crossDomain: true,
        success: function (result) {
            window.location.href = "/Adverts?selecterDropDownValue=" + newAdvert[3];
        },
        error: function (err) {
            console.log("AJAX error in request: " + JSON.stringify(err, null, 2));
        }
    });
}

