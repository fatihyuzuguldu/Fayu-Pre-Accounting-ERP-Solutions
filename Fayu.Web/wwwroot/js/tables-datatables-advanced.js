/**
 * DataTables Advanced (jquery)
 */

'use strict';

$(function () {
    var dt_ajax_table = $('.datatables-ajax'),
        dt_filter_table = $('.dt-column-search'),
        dt_adv_filter_table = $('.dt-advanced-search'),
        dt_responsive_table = $('.dt-responsive'),
        startDateEle = $('.start_date'),
        endDateEle = $('.end_date');

    // Ajax Sourced Server-side
    // --------------------------------------------------------------------

    // Filter form control to default size
    // ? setTimeout used for multilingual table initialization
    setTimeout(() => {
        $('.dataTables_filter .form-control').removeClass('form-control-sm');
        $('.dataTables_length .form-select').removeClass('form-select-sm');
    }, 300);
});
