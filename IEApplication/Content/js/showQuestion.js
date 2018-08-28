$(document).ready(function () {
$('.notUrgent').click(function () {
    document.getElementById('courses').style.display = 'none';
    document.getElementById('feature').style.display = 'inline';
    });
    $(document).on('click', '#goBackButton', function () {
        document.getElementById('courses').style.display = 'inline';
        document.getElementById('feature').style.display = 'none';
    });
});
