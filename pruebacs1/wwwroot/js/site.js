// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var primary = new Primary();
var User = new Users();
var imageUser = (evt) => {
    User.file(evt, "ImageUser");
}

$().ready(() => {
    let URLactual = window.location.pathname;
    primary.userLink(URLactual);
    console.log(URLactual);
});