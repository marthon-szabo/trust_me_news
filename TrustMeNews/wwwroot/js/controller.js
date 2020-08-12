﻿class Controller {

    constructor(document) {
        this.document = document;
    };

    sendRequest() {
        const sb = document.querySelector("#inpSearch");
        sb.addEventListener("keypress", (e) => {
            if (e.key === "Enter") {
                console.log(e.target.value)
            }
        });
    }

    getNewsBySection() {
        document.querySelectorAll(".genre").forEach((genre) => {
            genre.addEventListener("click", () => {
                console.log(genre.id);
            })
        })
    }
}