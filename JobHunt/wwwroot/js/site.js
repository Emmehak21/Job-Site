
document.querySelectorAll('.read-more').forEach(link => {
    link.addEventListener('click', event => {
        event.preventDefault();
        const post = link.parentNode;
        const content = post.querySelector('.post-content');
        content.classList.toggle('show');
    });
});

