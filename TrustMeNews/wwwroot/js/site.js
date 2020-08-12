// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let apiKey = "https://content.guardianapis.com/search?api-key=d0bd9a0e-8101-4525-8604-4ad01023d10c&order-by=newest&show-fields=all&page-size=6";

function getNewsBySection() {

    let genre = document.querySelector(".genre").addEventListener("click", function () {
        apiKey = apiKey + "&section=" + genre.data.genre;
        console.log(apiKey);
    })
}
