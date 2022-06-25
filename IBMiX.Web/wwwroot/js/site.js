$(document).ready(function () {
    $('#books').DataTable();

    $('button.returnButton').click(function () {
        var title = $(this).closest('tr').find('td.book-title').text();
        var borrowed = $(this).closest('tr').find('td.book-borrowed').text();
        var id = $(this).closest('tr').find('td.book-id').text();
        $('#returnModalData').text("Return " + title + " from " + borrowed + "?");
        $('#returnBookId').attr("value", id);
    });

    $('button.borrowButton').click(function () {
        var title = $(this).closest('tr').find('td.book-title').text();
        console.log($(this).closest('tr').find('td.book-title'));
        console.log($(this).closest('tr').find('td.book-title').text());
        var id = $(this).closest('tr').find('td.book-id').text();
        $('#borrowModalData').text("Borrow " + title + " to:");
        $('#borrowBookId').attr("value", id);
    });
});