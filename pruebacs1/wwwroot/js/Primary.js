class Primary {
    userLink(URLactual) {
        let url = "";
        let chain = URLactual.split("/");
        for (var i = 0; i < chain.length; i++) {
            if (chain[i] != "Index") {
                url += chain[i];
            }
        }
        switch (url) {
            case "UsersAccountRegister":
                document.getElementById('files').addEventListener('change', imageUser, false);
                console.log( url);
                break;
        }
    }
}