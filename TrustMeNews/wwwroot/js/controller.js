class Controller {

    constructor(document) {
        this.document = document;
    };

    returnGenre(genre) {
        return genre;
    }

    sendRequest() {
        const sb = document.querySelector("#inpSearch");
        sb.addEventListener("keypress", (e) => {
            if (e.key === "Enter") {
                fetch(`https://localhost:44313/Home?content=${e.target.value}`, {
                    method: "get"
                })
                    .then((resp) => window.location.replace("https://localhost:44313/SearchBar/Result"))
            }
        });
    }

    getNewsBySection() {
        document.querySelectorAll(".genre").forEach((genre) => {
            genre.addEventListener("click", () => {
                genreId = genre.id;
                this.returnGenre(genreId);
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