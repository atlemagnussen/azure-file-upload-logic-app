let auther = (function() {
    let resultElement, inputApiKey;
    const callNoAuth = async () => {
        resultElement.value = "fetching no auth...";
        const endpoint = "/api/user/anyone";
        try {
            const response = await fetch(endpoint);

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

    const callAuth = async endpoint => {
        resultElement.value = "fetching no auth...";
        const myHeaders = new Headers();
        myHeaders.append("X-Api-Key", inputApiKey.value);
        try {
            const response = await fetch(endpoint, {
                method: "GET",
                headers: myHeaders,
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
        resultElement = document.getElementById("output-field");
        inputApiKey = document.getElementById("inputApiKey");
        const btnNoAuth = document.getElementById("btnNoAuth");
        btnNoAuth.addEventListener("click", () => {
            callNoAuth();
        });
        const btnAuth = document.getElementById("btnAuth");
        btnAuth.addEventListener("click", () => {
            callAuth("/api/user/only-authenticated");
        });
        const btnAuthEmployee = document.getElementById("btnAuthEmployee");
        btnAuthEmployee.addEventListener("click", () => {
            callAuth("/api/user/only-employees");
        });
    };
    return {
        init,
    };
})();
