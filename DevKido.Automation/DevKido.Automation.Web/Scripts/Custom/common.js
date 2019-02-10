function TestFeature(siteUrl, siteSuccess, siteFail, siteLoader) {
    $("#" + siteSuccess).css('visibility', 'hidden');
    $("#" + siteFail).css('visibility', 'hidden');
    $("#" + siteLoader).show();
    $.ajax({
        type: 'POST',
        url: siteUrl,
        dataType: 'json',
        data: { id: 2 },
        success: function (returnResult) {
            if (returnResult.data === 'success') {
                $("#" + siteSuccess).css('visibility', 'visible');
            }
            else {
                $("#" + siteFail).css('visibility', 'visible');
            }
            $("#" + siteLoader).hide();
        },
        error: function (ex) {
            alert('Failed to retrieve states.' + ex);
            $("#" + siteFail).css('visibility', 'visible');
            $("#" + siteLoader).hide();
        }
    });
}