// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

class Site {

    constructor(document) {
        this.document = document;
    };

    changeTheme() {
        this.document.querySelector(".themes").addEventListener("click", () => {
            document.body.classList.add("dark");
        })
    }

}
