class Controller {

    constructor(document) {
        this.document = document;
    };

    apiLink;

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
                $.ajax({
                    type: "GET",
                    url: "/section",
                    dataType: "string",
                    data: { section: apiLink }
                });
                console.log(genre.id);
            })
        })
    }
}