var uploader = (function() {
    let sel;
    const post = async () => {
        var oFormElement = document.getElementById("uploader-form");
        var resultElement = oFormElement.elements.namedItem("result");
        resultElement.value = "Uploading...";
        const formData = new FormData(oFormElement);
        const endpoint = sel.value;
        try {
            const response = await fetch(endpoint, {
                method: "POST",
                body: formData,
            });

            if (response.ok) {
                console.log("all good");
            }

            const res = await response.text();
            console.log(res);
            resultElement.value = "Result: " + response.status + " " + response.statusText + " - " + res;
        } catch (error) {
            console.error(error);
            resultElement.value = "Error...";
            var errmsg = "Error..." + error.message;
            resultElement.value = errmsg;
        }
    };
    const init = () => {
        console.log("init");
        var btn = document.getElementById("btn-uploader");
        btn.addEventListener("click", async e => {
            e.preventDefault();
            await post();
        });
        sel = document.getElementById("endpoint");
        sel.value = "http://localhost:44397/api/upload"; // default
    };
    return {
        post,
        init,
    };
})();
