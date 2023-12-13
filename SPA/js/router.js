const routes = {
    "/" : "/pages/home.html",
    "/settings" : "/pages/settings.html",
    "/about" : "/pages/about.html",
    404 : "/pages/404.html", 
}

const route = (event) => {
    event = event || window.event;
    event.preventDefault();
    window.history.pushState({}, "", event.target.href);
    handleLocation();
};

const handleLocation = async () => {
    const path = window.location.pathname;
    const route = routes[path] || routes[404];
    const html = await fetch(route).then((page) => page.text());
    document.getElementById("main-page").innerHTML = html;
};

window.onpopstate = handleLocation;
window.route = route;
handleLocation();