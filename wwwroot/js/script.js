var x = document.querySelector('.singleOffer #carPrice')
var y = parseInt(x.innerHTML.replace(/[^0-9]/g, ''));

var days = document.querySelector('.singleOffer #days');

var form = document.querySelector('.singleOffer form');

var cost = document.querySelector('.singleOffer #cost');

var submitButton = document.querySelector('.singleOffer #submitCheck');

var submitAlert = document.querySelector('.singleOffer #submitAlert');

var priceDiv = document.querySelector('.singleOffer #priceDiv');

days.addEventListener('change', () => {
    if (days.value < 31 && days.value > 0) {
        submitButton.style.pointerEvents = "all";
        var res = parseInt(days.value) * y;
        cost.innerHTML = "Cena: <span asp-for='orderPrice'>" + res + "</span>zł";
        priceDiv.innerHTML = "<input type='hidden' name='orderPrice' id='orderPrice' value='" + res + "'/>";
        cost.display = "block";
        cost.color = "black";
        submitAlert.style.display = "none";
    } else {
        submitButton.style.pointerEvents = "none";
        submitAlert.style.display = "block";
    }
});