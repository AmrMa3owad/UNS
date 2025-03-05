/**
* Template Name: Medilab
* Template URL: https://bootstrapmade.com/medilab-free-medical-bootstrap-theme/
* Updated: Aug 07 2024 with Bootstrap v5.3.3
* Author: BootstrapMade.com
* License: https://bootstrapmade.com/license/
*/

(function () {
    "use strict";

    /**
     * Apply .scrolled class to the body as the page is scrolled down
     */
    function toggleScrolled() {
        const selectBody = document.querySelector('body');
        const selectHeader = document.querySelector('#header');
        if (!selectHeader.classList.contains('scroll-up-sticky') && !selectHeader.classList.contains('sticky-top') && !selectHeader.classList.contains('fixed-top')) return;
        window.scrollY > 100 ? selectBody.classList.add('scrolled') : selectBody.classList.remove('scrolled');
    }
    document.addEventListener('scroll', toggleScrolled);
    window.addEventListener('load', toggleScrolled);

    /**
     * Mobile nav toggle
     */
    const mobileNavToggleBtn = document.querySelector('.mobile-nav-toggle');
    function mobileNavToogle() {
        document.querySelector('body').classList.toggle('mobile-nav-active');
        mobileNavToggleBtn.classList.toggle('bi-list');
        mobileNavToggleBtn.classList.toggle('bi-x');
    }
    mobileNavToggleBtn.addEventListener('click', mobileNavToogle);

    /**
     * Hide mobile nav on same-page/hash links
     */
    document.querySelectorAll('#navmenu a').forEach(navmenu => {
        navmenu.addEventListener('click', () => {
            if (document.querySelector('.mobile-nav-active')) {
                mobileNavToogle();
            }
        });
    });

    /**
     * Toggle mobile nav dropdowns
     */
    document.querySelectorAll('.navmenu .toggle-dropdown').forEach(navmenu => {
        navmenu.addEventListener('click', function (e) {
            e.preventDefault();
            this.parentNode.classList.toggle('active');
            this.parentNode.nextElementSibling.classList.toggle('dropdown-active');
            e.stopImmediatePropagation();
        });
    });

    /**
     * Preloader
     */
    const preloader = document.querySelector('#preloader');
    if (preloader) {
        window.addEventListener('load', () => {
            preloader.remove();
        });
    }

    /**
     * Scroll top button
     */
    let scrollTop = document.querySelector('.scroll-top');
    function toggleScrollTop() {
        if (scrollTop) {
            window.scrollY > 100 ? scrollTop.classList.add('active') : scrollTop.classList.remove('active');
        }
    }
    scrollTop.addEventListener('click', (e) => {
        e.preventDefault();
        window.scrollTo({
            top: 0,
            behavior: 'smooth'
        });
    });
    window.addEventListener('load', toggleScrollTop);
    document.addEventListener('scroll', toggleScrollTop);

    /**
     * Animation on scroll function and init
     */
    function aosInit() {
        AOS.init({
            duration: 600,
            easing: 'ease-in-out',
            once: true,
            mirror: false
        });
    }
    window.addEventListener('load', aosInit);

    /**
     * Initiate glightbox
     */
    const glightbox = GLightbox({
        selector: '.glightbox'
    });

    /**
     * Initiate Pure Counter
     */
    new PureCounter();

    /**
     * Frequently Asked Questions Toggle
     */
    document.querySelectorAll('.faq-item h3, .faq-item .faq-toggle').forEach((faqItem) => {
        faqItem.addEventListener('click', () => {
            faqItem.parentNode.classList.toggle('faq-active');
        });
    });

    /**
     * Init swiper sliders
     */
    function initSwiper() {
        document.querySelectorAll(".init-swiper").forEach(function (swiperElement) {
            let config = JSON.parse(
                swiperElement.querySelector(".swiper-config").innerHTML.trim()
            );
            if (swiperElement.classList.contains("swiper-tab")) {
                initSwiperWithCustomPagination(swiperElement, config);
            } else {
                new Swiper(swiperElement, config);
            }
        });
    }
    window.addEventListener("load", initSwiper);

    /**
     * Correct scrolling position upon page load for URLs containing hash links.
     */
    window.addEventListener('load', function (e) {
        if (window.location.hash) {
            if (document.querySelector(window.location.hash)) {
                setTimeout(() => {
                    let section = document.querySelector(window.location.hash);
                    let scrollMarginTop = getComputedStyle(section).scrollMarginTop;
                    window.scrollTo({
                        top: section.offsetTop - parseInt(scrollMarginTop),
                        behavior: 'smooth'
                    });
                }, 100);
            }
        }
    });

    /**
     * Navmenu Scrollspy
     */
    let navmenulinks = document.querySelectorAll('.navmenu a');
    function navmenuScrollspy() {
        navmenulinks.forEach(navmenulink => {
            if (!navmenulink.hash) return;
            let section = document.querySelector(navmenulink.hash);
            if (!section) return;
            let position = window.scrollY + 200;
            if (position >= section.offsetTop && position <= (section.offsetTop + section.offsetHeight)) {
                document.querySelectorAll('.navmenu a.active').forEach(link => link.classList.remove('active'));
                navmenulink.classList.add('active');
            } else {
                navmenulink.classList.remove('active');
            }
        });
    }
    window.addEventListener('load', navmenuScrollspy);
    document.addEventListener('scroll', navmenuScrollspy);

    /**
     * Activate Bootstrap tab based on URL hash on page load.
     * This code will run on every page. If a tab trigger exists that matches the URL hash,
     * it will activate that tab. Otherwise, it will attempt a smooth scroll to the element.
     */
    window.addEventListener('load', function () {
        var hash = window.location.hash;
        if (hash) {
            // Try to activate a tab if it exists
            var triggerEl = document.querySelector('a[data-bs-toggle="tab"][href="' + hash + '"]');
            if (triggerEl) {
                var tab = new bootstrap.Tab(triggerEl);
                tab.show();
            } else if (document.querySelector(hash)) {
                let section = document.querySelector(hash);
                let scrollMarginTop = getComputedStyle(section).scrollMarginTop;
                window.scrollTo({
                    top: section.offsetTop - parseInt(scrollMarginTop),
                    behavior: 'smooth'
                });
            }
        }
    });

    /**
     * Advanced Search Functionality
     * - If a search query parameter (?q=...) is present, this code will check our searchData mapping.
     * - If a match is found, it will redirect to the target URL (which can include an anchor).
     * - If no match is found, it will redirect to not-found.html.
     * - Additionally, as the user types in the search field, suggestions will be displayed.
     */
    window.addEventListener('DOMContentLoaded', function () {
        // Select the search input field in the header
        const searchInput = document.querySelector('.header-search input[name="q"]');
        if (!searchInput) return;

        // Create a suggestion box and insert it after the search input
        const suggestionBox = document.createElement('div');
        suggestionBox.classList.add('search-suggestions');
        searchInput.parentNode.appendChild(suggestionBox);

        // Define our search mapping data. Use lowercase keywords for matching.
        const searchData = [
            { keyword: "unicid forte", url: "instrumental.html#departments-tab-1" },
            { keyword: "unicid forte plus", url: "instrumental.html#departments-tab-2" },
            { keyword: "instrumental", url: "instrumental.html" },
            { keyword: "surfaces", url: "surfaces.html" },
            { keyword: "unicid spray", url: "surfaces.html#departments-tab-1" },
            { keyword: "Unicid Free", url: "surfaces.html#departments-tab-2" },
            { keyword: "hand antiseptic", url: "hand-antiseptic.html" },
            { keyword: "uniguard", url: "hand-antiseptic.html#departments-tab-1" },
            { keyword: "uniscrub 4%", url: "hand-antiseptic.html#departments-tab-2" },
            { keyword: "floors", url: "floors.html" },
            { keyword: "uni-surf", url: "floors.html#departments-tab-1" },
            { keyword: "dental suction", url: "dental-suction.html" },
            { keyword: "unijet dd", url: "dental-suction.html#departments-tab-1" },
            { keyword: "irrigation solutions", url: "irrigation-solutions.html" },
            { keyword: "hexiroot 2%", url: "irrigation-solutions.html#departments-tab-1" },
            { keyword: "hyporoot 2%", url: "irrigation-solutions.html#departments-tab-2" },
            { keyword: "hyporoot 5.25%", url: "irrigation-solutions.html#departments-tab-3" }

            // Add more entries as needed
        ];

        // Function to display suggestions in the suggestion box
        function showSuggestions(filtered) {
            suggestionBox.innerHTML = '';
            if (filtered.length === 0) {
                const noResult = document.createElement('div');
                noResult.textContent = 'No suggestions found';
                suggestionBox.appendChild(noResult);
            } else {
                filtered.forEach(item => {
                    const suggestionItem = document.createElement('div');
                    suggestionItem.textContent = item.keyword;
                    suggestionItem.classList.add('suggestion-item');
                    suggestionItem.addEventListener('click', function () {
                        window.location.href = item.url;
                    });
                    suggestionBox.appendChild(suggestionItem);
                });
            }
            suggestionBox.style.display = filtered.length > 0 ? 'block' : 'none';
        }

        // Event listener for search input keyup to display suggestions
        searchInput.addEventListener('keyup', function (e) {
            const query = searchInput.value.toLowerCase().trim();
            if (query.length === 0) {
                suggestionBox.style.display = 'none';
                return;
            }
            const filtered = searchData.filter(item => item.keyword.includes(query));
            showSuggestions(filtered);
        });

        // Hide suggestions when clicking outside the search field
        document.addEventListener('click', function (e) {
            if (!suggestionBox.contains(e.target) && e.target !== searchInput) {
                suggestionBox.style.display = 'none';
            }
        });

        // Handle search form submission
        const searchForm = document.querySelector('.header-search form');
        if (searchForm) {
            searchForm.addEventListener('submit', function (e) {
                e.preventDefault();
                const query = searchInput.value.toLowerCase().trim();
                let found = searchData.find(item => item.keyword === query || item.keyword.includes(query));
                if (found) {
                    window.location.href = found.url;
                } else {
                    window.location.href = 'not-found.html';
                }
            });
        }
    });

})();