

class Controller{
    
    constructor(document) {
        this.document = document;
    };

    sendRequest() {
        const sb = document.querySelector("#inpSearch");
        sb.addEventListener("keypress", (e) => {
            if (e.key === "Enter") {
                console.log(e.target.value);
                fetch(`https://localhost:44313/search?content=${e.target.value}`, {
                    method: "get"
                })
                    .then((resp) => console.log(resp))
            }
        });
    }
    

}