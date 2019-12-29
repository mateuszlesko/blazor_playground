document.cookie ="profile=Matt13;"
const cookie = document.cookie
function getCookie(name) {
    var v = document.cookie.match('(^|;) ?' + name + '=([^;]*)(;|$)');
    return v ? v[2] : null;
}
const profile = getCookie("profile");
document.querySelector("#profile").innerHTML = profile;
console.log(profile);