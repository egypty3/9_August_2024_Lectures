$(
    function () {

        $('#p1').on(
            {
                'mouseenter':
                function () {
                    $('#messages').text('you enter the paragraph with an id of #p1');
                }
            },
            {
                'mouseleave':
                function() {
                    $('#messages').text('Hatwhashna !!!');
                }

            }
        );


        $('#p2').on(
            {
                'mousedown':
                function (eventData) {
                    $('#messages').text(
                        `mouse down on  #p2 with button ${eventData.button}`
                    );
                }
            },
            {
                'mouseup':
                function(eventData) {
                    $('#messages').text(
                        `mouse up on  #p2 with button ${eventData.button}`);
                }
            }
        );       

        //$('input[type="text"]').on('focus',
        //    function(){
        //        $(this).css('background-color', 'hotpink');

        //    }
        //);

        //$('input[type="text"]').on('blur',
        //    function () {
        //        $(this).css('background-color', 'white');

        //    }
        //);

        $('input[type="text"]').on(
            {
                'focus':
                function() {
                    $(this).css('background-color', 'hotpink');

                }
            },

            {
                'blur':
                function() {
                    $(this).css('background-color', 'white');

                }
            }
        );

       

    }

);