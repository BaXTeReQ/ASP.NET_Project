var dropdown = document.querySelector(".dropdown");
var dropdownContent = document.querySelector(".dropdown .dropdown-content");;

dropdown.addEventListener('click', () => {
    dropdownContent.classList.toggle("show");
});