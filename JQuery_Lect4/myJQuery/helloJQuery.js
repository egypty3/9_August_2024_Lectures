$(
       function () {

                // depricated way
                //$('input').click(
                //    function () {
                //        $('body').css('background-color', 'yellow');
                //        $('#hh').hide(1000);
                //    }
                //);

        $('input').on('click',
            function () {
                $('body').css('background-color', 'yellow');
                $('#hh').hide(1000);
            });

        $('p').on('click',
            function () {
                $(this).hide(1000);
            }
        );

    }

);