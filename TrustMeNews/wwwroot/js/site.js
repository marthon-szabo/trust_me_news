// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

class Site {

    constructor(document) {
        this.document = document;
    };

    changeTheme() {
        this.document.querySelector(".themes").addEventListener("click", () => {
            document.querySelectorAll(".dark").forEach((e) => {
                e.classList.remove("dark");
                e.classList.add("light");
            });
            document.querySelectorAll(".navbar").forEach((e) => {
                e.classList.remove("background-light");
                e.classList.add("background-dark");
            })
        })
    }

}
