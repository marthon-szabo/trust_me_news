class Controller {

    constructor(document) {
        this.document = document;
    };

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
                var genreId = genre.id;
                $.ajax({
                    type: "GET",
                    url: "/section",
                    dataType: "string",
                    data: { section: genreId }
                });
            })
        })
    }

    getArticle() {
        this.document.querySelectorAll(".article").forEach((article) => {
            article.addEventListener("dblclick", () => {
                var articleId = article.id;
                $.ajax({
                    type: "GET",
                    url: "/article",
                    dataType: "string",
                    data: { article: articleId }
                });
                console.log(articleId);
            })
        })
    }
}