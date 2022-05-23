/*!
    * Start Bootstrap - SB Admin v7.0.4 (https://startbootstrap.com/template/sb-admin)
    * Copyright 2013-2021 Start Bootstrap
    * Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-sb-admin/blob/master/LICENSE)
    */
    // 
// Scripts
// 
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (senderid, message) {

    var reciverid = document.getElementById("reciverid").value;
    if (reciverid == senderid) {
        var div = document.createElement("div");
        div.classList.add("reciver");
        div.textContent = message;
        document.getElementsByClassName("message")[0].appendChild(div);
        var div = document.getElementsByClassName("message")[0];
        div.scrollTop = div.scrollHeight;
    }
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendMessage").addEventListener("click", function (event) {
    var reciverid = document.getElementById("reciverid").value;
    var senderid = document.getElementById("senderid").value;
    var message = document.getElementById("message").value;
    if (message !== "" && reciverid !== "" && senderid !== "") {

        connection.invoke("SendPrivate", reciverid, senderid, message).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();

        var div = document.createElement("div");
        div.classList.add("sender")
        div.textContent = message;



        document.getElementsByClassName("message")[0].appendChild(div);
        document.getElementById("message").value = "";

        var div = document.getElementsByClassName("message")[0];
        div.scrollTop = div.scrollHeight;
    }
});

var input = document.getElementById("message");

// Execute a function when the user releases a key on the keyboard
input.addEventListener("keypress", function (event) {
    // Number 13 is the "Enter" key on the keyboard

    if (event.keyCode === 13) {
        // Cancel the default action, if needed
        event.preventDefault();
        // Trigger the button element with a click
        //document.getElementById("sendMessage").click();
        var reciverid = document.getElementById("reciverid").value;
        var senderid = document.getElementById("senderid").value;
        var message = document.getElementById("message").value;
        if (message !== "" && reciverid !== "" && senderid !== "") {

            connection.invoke("SendPrivate", reciverid, senderid, message).catch(function (err) {
                return console.error(err.toString());
            });
            event.preventDefault();

            var div = document.createElement("div");
            div.classList.add("sender")
            div.textContent = message;



            document.getElementsByClassName("message")[0].appendChild(div);
            document.getElementById("message").value = "";

            var div = document.getElementsByClassName("message")[0];
            div.scrollTop = div.scrollHeight;
        }

    }

});

var div = document.getElementsByClassName("message")[0];
div.scrollTop = div.scrollHeight;



window.addEventListener('DOMContentLoaded', event => {

    // Toggle the side navigation
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
        // Uncomment Below to persist sidebar toggle between refreshes
        // if (localStorage.getItem('sb|sidebar-toggle') === 'true') {
        //     document.body.classList.toggle('sb-sidenav-toggled');
        // }
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            document.body.classList.toggle('sb-sidenav-toggled');
            localStorage.setItem('sb|sidebar-toggle', document.body.classList.contains('sb-sidenav-toggled'));
        });
    }
    


    //$("#addNewItem").click(function () {

    //    let ColorImageItems = $(".ColorImageItem");
    //    let firstItem = $(ColorImageItems[0].cloneNode(true));
    //    let formControls = firstItem.find(".form-control");

    //    formControls[0].setAttribute("name", `[${ColorImageItems.length}].ColorId`);
    //    formControls[1].setAttribute("name", `[${ColorImageItems.length}].Image`);
    //    formControls[1].value = "";

    //    let itemContainer = $(".itemContainer");
    //    itemContainer.append(firstItem);
    //});

    //$(".addNewItem").click(function () {

    //    let index = $(this).data("index");
    //    let ColorImageItem = $(".ColorImageItem");
    //    let SizeToColorItems = $(".SizeToColorItem");

    //    for (var i = 0; i < ColorImageItem.length; i++) {
    //        if (ColorImageItem[i].dataset.index == index) {
    //            let SizeToColorContainer = $(ColorImageItem[i]).find(".SizeToColorContainer");
    //            let SizeToColorItem = ($(ColorImageItem[i]).find(".SizeToColorItem"))[0].cloneNode(true);

    //            let formControls = $(SizeToColorItem).find(".form-control");

    //            formControls[0].setAttribute("name", `[${SizeToColorItems.length}].SizeId`);
    //            formControls[1].setAttribute("name", `[${SizeToColorItems.length}].Price`);
    //            formControls[2].setAttribute("name", `[${SizeToColorItems.length}].Quantity`);
    //            formControls[3].setAttribute("name", `[${SizeToColorItems.length}].ColorId`);

    //            //console.log(SizeToColorItem);
    //            //console.log(formControls);
    //            //console.log(SizeToColorItems);
    //            //console.log(SizeToColorItems.length);

    //            SizeToColorContainer.append(SizeToColorItem);
    //        }
    //    }
    });


