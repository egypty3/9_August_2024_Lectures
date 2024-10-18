$(function () {
    $("#sampleForm").on('submit',
        function (e) {

            var isValid = true;
            e.preventDefault();

            $('input,select').removeClass('error');

            //Validate name field
            if ($('#name').val().trim() == '') {
                isValid = false;

                $('#name').addClass('error');
            }

            //Validate email field
            if ($('#email').val().trim() == '') {
                isValid = false;

                $('#email').addClass('error');
            }
            //Validate gender field
            if ($('#gender').val() == '') {
                isValid = false;

                $('#gender').addClass('error');
            }

            //Validate age field
            if ($('#age').val() == '') {
                isValid = false;

                $('#age').addClass('error');
            }

            //Validate phone field
            if ($('#phone').val() == '') {
                isValid = false;

                $('#phone').addClass('error');
            }

            if (isValid) {
                alert('Form submitted successfully');
            }
        }
    );
});