class Controller {

    constructor(document) {
        this.document = document;
    };

    sendRequest() {
        const sb = document.querySelector("#inpSearch");
        sb.addEventListener("keypress", (e) => {
            if (e.key === "Enter") {
                fetch(`https://localhost:44313/search?content=${e.target.value}`, {
                    method: "get"
                })
                    .then((resp) => console.log(resp.json))
            }
        });
    }

    getNewsBySection() {
        document.querySelectorAll(".genre").forEach((genre) => {
            genre.addEventListener("click", () => {
                var genreId = genre.id;
                fetch(`https://localhost:44313/search?section=${genreId}`, {
                    method: "get"
                })
                    .then((resp) => console.log(resp.json))
                $.ajax({
                    type: "GET",
                    url: `/section/${genreId}`,
                    //dataType: "string",
                    //data: { section: genreId }
                }).then((resp) => console.log(resp));
            })
        })
    }

    getArticle() {
        this.document.querySelectorAll(".article").forEach((article) => {
            article.addEventListener("dblclick", () => {
                var articleId = article.id;
                fetch(`https://localhost:44313/search?article=${articleId}`, {
                    method: "get"
                })
                    .then((resp) => console.log(resp.json))
            })
        })
    }
}