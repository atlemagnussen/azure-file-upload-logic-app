class Uploader {
    async post() {
        var oFormElement = document.getElementById("uploader-form");
        var resultElement = oFormElement.elements.namedItem("result");
        const formData = new FormData(oFormElement);

        try {
            const response = await fetch(oFormElement.action, {
                method: "POST",
                body: formData
            });

            if (response.ok) {
                // window.location.href = "/";
            }

            resultElement.value = "Result: " + response.status + " " + response.statusText;
        } catch (error) {
            console.error("Error:", error);
        }
    }
    init() {
        console.log("init");
        var btn = document.getElementById("btn-uploader");
        btn.addEventListener("click", async (e) => {
            e.preventDefault();
            await this.post();
        });
    }
}

export default new Uploader();