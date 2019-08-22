$(function () {
    var ctx = document.getElementById('myChart').getContext('2d');
    var chart = new Chart(ctx, {
        // The type of chart we want to create
        type: 'line',

        // The data for our dataset
        data: {
            labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
            datasets: [
                {
                    label: 'Totali',
                    backgroundColor: 'rgb(34, 186, 160)',
                    borderColor: 'rgb(34, 186, 160)',
                    data: [8000, 6000, 5600, 7200, 7800, 6000, 5500, 4877, 6578, 8041, 7451, 7999],
                    fill: false,
                    lineTension: 0
                },
                {
                    label: 'Kosto',
                    backgroundColor: 'rgb(242, 86, 86)',
                    borderColor: 'rgb(242, 86, 86)',
                    data: [6001, 5500, 6141, 5748, 5784, 6780, 6001, 5487, 7781, 6157, 6201, 5987],
                    fill: false,
                    lineTension: 0
                },
                {
                    label: 'Net',
                    backgroundColor: 'rgb(3, 155, 229)',
                    borderColor: 'rgb(3, 155, 229)',
                    data: [1001, 1200, 3320, 3587, 2358, 1567, 2451, 2368, 3545, 2478, 3689, 4578],
                    fill: false,
                    lineTension: 0
                }
            ]
        },

        // Configuration options go here
        options: {
            legend: {
                position: 'bottom'
            }
        }
    });

    // tab
    $(function () {
        var $li = $('ul.tab-title li');
        $(
            $li
                .eq(0)
                .addClass('active')
                .find('a')
                .attr('href')
        )
            .siblings('.tab-inner')
            .hide();
        $li.click(function () {
            $(
                $(this)
                    .find('a')
                    .attr('href')
            )
                .show()
                .siblings('.tab-inner')
                .hide();
            $(this)
                .addClass('active')
                .siblings('.active')
                .removeClass('active');
            return false;
        });
    });
});