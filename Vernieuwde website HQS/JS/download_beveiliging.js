if ('matchMedia' in window) {
    // Chrome, Firefox, and IE 10 support mediaMatch listeners
    window.matchMedia('print').addListener(function (media) {
        if (media.matches) {
            beforePrint();
        } else {
            // Fires immediately, so wait for the first mouse movement
            $(document).one('mouseover', afterPrint);
            //als er in die window geprint is dan gaat hij naar de functie before print, anders laat hij de content weer zien
        }
    });
} else {
    // IE and Firefox fire before/after events
    $(window).on('beforeprint', beforePrint);
    $(window).on('afterprint', afterPrint);
} // dit is voor internet explorer en firefox

function beforePrint() {
    $("#AllContent").hide();
    $(".PrintMessage").show();
}

function afterPrint() {
    $(".PrintMessage").hide();
    $("#AllContent").show(); //dit laat print message hiden en all content showwen
} /*dit is voor print screen*/

function schakelCtrlUit(e)
{
//list all CTRL + key combinations you want to disable
    var verbodenToetsen = ['a', 'n', 'c', 'x', 'v', 'j' , 'w', 'i','j','p'];
    var toets;
    var isCtrl;
    if(window.event)
    {
        toets = window.event.keyCode;     //Internet Explorer
        if(window.event.ctrlKey)
            isCtrl = true;
        else
            isCtrl = false;
    }
    else
    {
        toets = e.which;     //Firefox
        if(e.ctrlKey)
            isCtrl = true;
        else
            isCtrl = false;
    }
//Wanneer Ctrl is ingedrukt, kijk of er ook een andere toets is ingedrukt die in de Array voorkomt.
    if(isCtrl)
    {
        for(i=0; i<verbodenToetsen.length; i++)
        {
//Hoofdlettergevoeligheid eruitgehaald.
            if(verbodenToetsen[i].toLowerCase() === String.fromCharCode(toets).toLowerCase())
            {
                alert('Toets combinatie CTRL + '+String.fromCharCode(toets) +' is uitgeschakeld.');
                /*document.getElementById("bs_Warning").scrollIntoView({behavior: 'smooth'});*/
                /*window.location.hash = "bs_Warning";*/
                return false;
            }
        }
    }
    return true;
}

document.onkeydown = function(e) {
    if(event.keyCode == 123) {
        $('#bs_Warning').show();
        document.getElementById("myPage").scrollIntoView({behavior: 'smooth'});
        window.setTimeout(hide, 5000);
        return false;
    } //Tegen F12
    else if (e.ctrlKey && (event.keyCode === 86 || event.keyCode === 73 || event.keyCode === 74 || event.keyCode === 117 || event.keyCode === 85 || event.keyCode === 67 || event.keyCode === 123 || event.keyCode === 80)){
        $('#bs_Warning').show();
        document.getElementById("myPage").scrollIntoView({behavior: 'smooth'});
        window.setTimeout(hide, 5000);
        return false;
    } else {
        return true;
    }
}
function hide (){
    $('#bs_Warning').hide();
} // deze functie is aangemaakt om de alert te hiden na een bepaalde tijd

//Download Teller
function klikTeller() {
    if (typeof(Storage) !== "undefined") {
        if (localStorage.clickcount) {
            localStorage.clickcount = Number(localStorage.clickcount)+1;
        } else {
            localStorage.clickcount = 1;
        }
        document.getElementById("result").innerHTML = "Dit bestand is " + localStorage.clickcount + " keer gedownload.";
    } else {
        document.getElementById("result").innerHTML = "Sorry, jou browser ondersteund dit niet.";
    }
}