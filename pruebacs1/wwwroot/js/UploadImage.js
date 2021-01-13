class UploadImage {
    file(evt, id) {
        var id = 'files';
        let files = evt.target.files;
        let f = files[0];
        if (f.type.match('image.*')) {
            let reader = new FileReader();
            reader.onload = ((theFile) => {
                return (e) => {
                    document.getElementById(id).innerHTML = ['<img class="imageUser" src="',
                        e.target.result, '" title ="', escape(theFile.name), '"/>'].join('');
                    console.log(e);
                }
            })(f);
            reader.readAsDataURL(f);
            
        }
        
    }
}