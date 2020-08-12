class Controller {

    constructor(document) {
        this.document = document;
    };

    apiLink;

    sendData(link) {
        $.ajax({
            type: "POST",
            url: "/section",
            dataType: "string",
            data: { section: link }
        })
    }
    sendRequest() {
        const sb = document.querySelector("#inpSearch");
        sb.addEventListener("keypress", (e) => {
            if (e.key === "Enter") {
                console.log(e.target.value);
            }
        });
    }

    getNewsBySection() {
        document.querySelectorAll(".genre").forEach((genre) => {
            genre.addEventListener("click", () => {
                this.apiLink = genre.id;
                console.log(genre.id);
            })
        })
    }
}