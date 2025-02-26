(() => {

    const openNavMenu = document.querySelector(".open-nav-menu"),
        closeNavMenu = document.querySelector(".close-nav-menu"),
        navMenu = document.querySelector(".nav-menu"),
        menuOverlay = document.querySelector(".menu-overlay"),
        mediaSize = 991;

    openNavMenu.addEventListener("click", toggleNav);
    closeNavMenu.addEventListener("click", toggleNav);
    // close the navMenu by clicking outside
    menuOverlay.addEventListener("click", toggleNav);

    function toggleNav() {
        navMenu.classList.toggle("open");
        menuOverlay.classList.toggle("active");
        document.body.classList.toggle("hidden-scrolling");
    }

    navMenu.addEventListener("click", (event) => {
        if (event.target.hasAttribute("data-toggle") &&
            window.innerWidth <= mediaSize) {
            // prevent default anchor click behavior
            event.preventDefault();
            const menuItemHasChildren = event.target.parentElement;
            // if menuItemHasChildren is already expanded, collapse it
            if (menuItemHasChildren.classList.contains("active")) {
                collapseSubMenu();
            }
            else {
                // collapse existing expanded menuItemHasChildren
                if (navMenu.querySelector(".menu-item-has-children.active")) {
                    collapseSubMenu();
                }
                // expand new menuItemHasChildren
                menuItemHasChildren.classList.add("active");
                const subMenu = menuItemHasChildren.querySelector(".sub-menu");
                subMenu.style.maxHeight = subMenu.scrollHeight + "px";
            }
        }
    });
    function collapseSubMenu() {
        navMenu.querySelector(".menu-item-has-children.active .sub-menu")
            .removeAttribute("style");
        navMenu.querySelector(".menu-item-has-children.active")
            .classList.remove("active");
    }
    function resizeFix() {
        // if navMenu is open ,close it
        if (navMenu.classList.contains("open")) {
            toggleNav();
        }
        // if menuItemHasChildren is expanded , collapse it
        if (navMenu.querySelector(".menu-item-has-children.active")) {
            collapseSubMenu();
        }
    }

    window.addEventListener("resize", function () {
        if (this.innerWidth > mediaSize) {
            resizeFix();
        }
    });

})();


// ---------------------------------------NAVBAR END------------------------------------------------

// mousemove home img 
document.addEventListener('mousemove', move);
function move(e) {
    this.querySelectorAll('.move').forEach(layer => {
        const speed = layer.getAttribute('data-speed')

        const x = (window.innerWidth - e.pageX * speed) / 120
        const y = (window.innerWidth - e.pageY * speed) / 120
        layer.style.transform = translateX($,{ x },px); translateY($,{ y },px)

    })
}

gsap.from('.logo', { opacity: 0, duration: 1, delay: 2, y: 10 })
gsap.from('.nav-menu.javanav', { opacity: 0, duration: 1, delay: 2.1, y: 30, stagger: 0.2 })
gsap.from('.T1', { opacity: 0, duration: 1, delay: 1.6, y: 30 })
gsap.from('.disc1', { opacity: 0, duration: 1, delay: 1.8, y: 30 })
gsap.from('.button22', { opacity: 0, duration: 1, delay: 2.1, y: 30 })
gsap.from('.imgs1', { opacity: 0, duration: 1, delay: 2.6, y: 30 })


// ---------------------------section one js enddddd---------------------------
//  ---------------------------------------scroll js---------------------------------------
const sr = ScrollReveal({
    origin: 'top',
    distance: '80px',
    duration: 2500,
    delay: 300,
})
sr.reveal(Ho4)