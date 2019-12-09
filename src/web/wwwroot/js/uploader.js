class Uploader {
    async post() {
        var oFormElement = document.getElementById("uploader-form");
        var resultElement = oFormElement.elements.namedItem("result");
        resultElement.value = "Uploading...";
        const formData = new FormData(oFormElement);
        const endpoint = this.sel.value;
        try {
            const response = await fetch(endpoint, {
                method: "POST",
                body: formData,
            });

            if (response.ok) {
                // window.location.href = "/";
            }

            resultElement.value = "Result: " + response.status + " " + response.statusText;
        } catch (error) {
            console.error(error);
            resultElement.value = "Error...";
            var errmsg = "Error..." + error.message;
            resultElement.value = errmsg;
        }
    }
    init() {
        console.log("init");
        var btn = document.getElementById("btn-uploader");
        btn.addEventListener("click", async e => {
            e.preventDefault();
            await this.post();
        });
        this.sel = document.getElementById("endpoint");
    }
}

export default new Uploader();
