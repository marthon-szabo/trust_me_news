class Controller {

    constructor(document) {
        this.document = document;
    };

    sendRequest() {
        const sb = document.querySelector("#inpSearch");
        sb.addEventListener("keypress", (e) => {
            if (e.key === "Enter") {
                fetch(`https://localhost:44313/Home?content=${e.target.value}`, {
                    method: "get"
                })
                    .then((resp) => console.log(resp))
            }
        });
    }

    getNewsBySection() {
        document.querySelectorAll(".genre").forEach((genre) => {
            genre.addEventListener("click", () => {
                var genreId = genre.id;
                fetch(`https://localhost:44313/section?section=${genreId}`, {
                    method: "get"
                })
                    .then((resp) => console.log(resp.json))
            })
        })
    }

    getArticle() {
        this.document.querySelectorAll(".article").forEach((article) => {
            article.addEventListener("dblclick", () => {
                var articleId = article.id;
                fetch(`https://localhost:44313/article?article=${articleId}`, {
                    method: "get"
                })
                    .then((resp) => console.log(resp.json))
            })
        })
    }
}