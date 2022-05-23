$(document).ready(function () {
    setTimeout(function () {
        $(".loader-wrapper").remove();
    }, 1000);


    $('.nav-link').click(function () {
        console.log("Clicked");
        $('.nav-link.active').removeClass('active');
        $('nav-link').addClass('active');
    });
   

    // $('.dropendd').click(function() {
    //     console.log("Clicked");
    //     $('.submenu-1.active').removeClass('active');
    //     $(".submenu-1").addClass('active');
    // });
    window.addEventListener("scroll", function () {
        var nav = document.querySelector("nav");
        nav.classList.toggle("fixed-top", window.scrollY > 58);
    })


    window.addEventListener("scroll", function () {
        var nav = document.getElementsByClassName("top_button")[0];
        nav.classList.toggle("fixedd-top", window.scrollY > 20);



    })

    //window.addEventListener("scroll", function () {
    //    var nav = document.getElementsByClassName("forchat");
    //    nav.classList.toggle("fixedd-top", window.scrollY > 20);



    //})



    setTimeout(function () {
        $(".loader-wrapper").remove();
    }, 1000);

    const deadline = '2022-06-12';

    function getTimeRemaining(endtime) {
        const t = Date.parse(endtime) - Date.parse(new Date()),
            days = Math.floor(t / (1000 * 60 * 60 * 24)),
            hours = Math.floor((t / (1000 * 60 * 60) % 24)),
            minutes = Math.floor((t / 1000 / 60) % 60),
            seconds = Math.floor((t / 1000) % 60);

        return {
            'total': t,
            'days': days,
            'hours': hours,
            'minutes': minutes,
            'seconds': seconds
        };
    }

    function getZero(num) {
        if (num >= 0 && num < 10) {
            return `0${num}`;
        } else {
            return num;
        }
    }

    function setClock(selector, endtime) {
        const timer = document.querySelector(selector),
            days = timer.querySelector('#days'),
            hours = timer.querySelector('#hours'),
            minutes = timer.querySelector('#minutes'),
            seconds = timer.querySelector('#seconds'),
            timeInterval = setInterval(updateClock, 1000);

        updateClock();

        function updateClock() {
            const t = getTimeRemaining(endtime);

            days.innerHTML = getZero(t.days);
            hours.innerHTML = getZero(t.hours);
            minutes.innerHTML = getZero(t.minutes);
            seconds.innerHTML = getZero(t.seconds);

            if (t.total <= 0) {
                clearInterval(timeInterval);
            }
        }
    }

    setClock('.timer', deadline);


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
        var div = document.getElementsByClassName("message")[0];
        div.scrollTop = div.scrollHeight;
    });

 


});

