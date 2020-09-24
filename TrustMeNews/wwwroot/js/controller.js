class Controller {

    constructor(document) {
        this.document = document;
    };

    outputResponse(dataContainer, data) {
        dataContainer.innerHTML += `
            <div class="article" id="${data.id}">
                <img class="image" src="${data.fields.thumbnail}" />
                <p>${data.webPublicationDate}</p>
                <h5>${data.webTitle}</h5>
                <p>${data.fields.trailText}</p>
                <h6>${data.fields.byline}</h6>
            </div>`
    }


    sendRequest() {
        const sb = document.querySelector("#inpSearch");
        sb.addEventListener("keypress", (e) => {
            if (e.key === "Enter") {
                fetch(`https://localhost:44313/search?content=${e.target.value}`, {
                    method: "get"
                })
                    .then((resp) => resp.json())
                    .then((data) => {
                        let articles = this.document.querySelector(".articles");
                        articles.innerHTML = "";
                        data.forEach(article => {
                            this.outputResponse(articles, article)
                        })
                    })
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
                    .then((resp) => resp.json())
                    .then((data) => {
                        let articles = this.document.querySelector(".articles");
                        articles.innerHTML = "";
                        data.forEach(article => {
                            this.outputResponse(articles, article);
                        })
                    })

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
                    .then((resp) => resp.json())
                    .then((data) => {
                        let articles = this.document.querySelector(".articles");
                        articles.innerHTML = "";
                        articles.innerHTML += `
                                <div class="one-article" id="${data.id}">
                                    <img class="image" src="${data.fields.thumbnail}" />
                                    <p>${data.webPublicationDate}</p>
                                    <h5>${data.webTitle}</h5>
                                    <h6 class="article-body">${data.fields.bodyText}</h6>
                                </div>`
                    })

            })
        })
    }

}