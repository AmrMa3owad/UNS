document.addEventListener("DOMContentLoaded", function () {

    // Product Search Functionality
    const searchInput = document.getElementById("search");
    if (searchInput) {
        searchInput.addEventListener("keyup", function () {
            let filter = searchInput.value.toLowerCase();
            let products = document.querySelectorAll(".product");

            products.forEach(product => {
                let title = product.querySelector("h3").innerText.toLowerCase();
                product.style.display = title.includes(filter) ? "block" : "none";
            });
        });
    }

    const sections = document.querySelectorAll("section");

    function revealOnScroll() {
        sections.forEach(section => {
            const sectionTop = section.getBoundingClientRect().top;
            const windowHeight = window.innerHeight;

            if (sectionTop < windowHeight * 0.85) {
                section.style.opacity = "1";
            }
        });
    }

    window.addEventListener("scroll", revealOnScroll);
    revealOnScroll(); // Run once on load

    // Form Submission Handling
    const form = document.getElementById("inquiry-form");
    if (form) {
        form.addEventListener("submit", function (event) {
            event.preventDefault();
            document.getElementById("confirmation").style.display = "block";
            form.reset();
        });
    }

});
