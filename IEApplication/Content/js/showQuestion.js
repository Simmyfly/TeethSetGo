$(document).ready(function () {
    $('#submitButton').click(function () {
        document.getElementById('content').style.display = 'none';
        //document.getElementById('content').removeClass("tab - pane active");
        //document.getElementById('ClinicsMap').addClass("tab-pane active");
        document.getElementById('ClinicsMap').style.display = 'inline';
        $('#priceTab').removeClass();
        document.getElementById('clinicsTab').style.color = '#57b87b';
    });
    $(document).on('click', '#goBack', function () {
        document.getElementById('content').style.display = 'inline';
        document.getElementById('ClinicsMap').style.display = 'none';
    });
});
