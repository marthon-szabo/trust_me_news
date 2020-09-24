// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

class Site {

    constructor(document) {
        this.document = document;
    };

    changeToDarkTheme() {
        this.document.querySelector(".darktheme").addEventListener("click", () => {
            document.querySelectorAll(".dark").forEach((e) => {
                e.classList.remove("dark");
                e.classList.add("light");
            });
            document.querySelectorAll(".navbar").forEach((e) => {
                e.classList.remove("background-light");
                e.classList.add("background-dark");
            });
            document.querySelectorAll(".light-theme").forEach((e) => {
                e.classList.remove("light-theme");
                e.classList.add("dark-theme");
            });
            this.document.querySelector(".dropdown-content").style.color = "indianred";
            this.document.querySelectorAll(".article").forEach((e) => {
                e.classList.remove("article-light");
                e.classList.add("article-dark");
            });
            this.document.querySelector(".articles").style.background = "black";
        })
    }

    changeToLightTheme() {
        this.document.querySelector(".lighttheme").addEventListener("click", () => {
            document.querySelectorAll(".light").forEach((e) => {
                e.classList.remove("light");
                e.classList.add("dark");
            });
            document.querySelectorAll(".navbar").forEach((e) => {
                e.classList.remove("background-dark");
                e.classList.add("background-light");
            });
            document.querySelectorAll(".dark-theme").forEach((e) => {
                e.classList.remove("dark-theme");
                e.classList.add("light-theme");
            });
            this.document.querySelector(".dropdown-content").style.color = "black";
            this.document.querySelectorAll(".article").forEach((e) => {
                e.classList.remove("article-dark");
                e.classList.add("article-light");
            });
            this.document.querySelector(".articles").style.background = "white";
        })
    }

}
