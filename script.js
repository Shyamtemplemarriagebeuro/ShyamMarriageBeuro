
// script.js

// Scroll fade-up animation
window.addEventListener("scroll", () => {
  document.querySelectorAll(".fade-up").forEach(el => {
    const top = el.getBoundingClientRect().top;
    if (top < window.innerHeight - 50) {
      el.classList.add("visible");
    }
  });
});

function toggleMenu() {
  const navbar = document.getElementById('navbar');
  navbar.classList.toggle('show');
}
